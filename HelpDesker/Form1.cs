using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.DirectoryServices;
using System.Linq;
using System.Windows.Media.Imaging;

// Замены в определении домена, режим функции, отправка формы

namespace HelpDesker
{
    public partial class Form1 : Form
    {
        #region Глобальные переменные для конфигов

        private string[] GlobalConfig;// Общий конфиг
        private string[] LocalConfig;// Конфиг, расположенный рядом с программой
        private string PathToGlobalConf = String.Empty; // Путь к общему конфигу, при каждом запуске переписывается из действующего общего в локальный

        #endregion

        #region Глобальные переменные для вложений

        private List <string> Attachments = new List<string>(); // Пустой список вложений
        private string[] InvPaths = new string[2];// Пустые пути для вложений
        private string PathScreen = String.Empty;// Пустой путь для скриншота

        #endregion

        private string UserName = String.Empty;// Объявление имени пользователя
        private string Domain = String.Empty;// Пустое поле для домена
        private List<string> Groups = new List<string>();// Список групп, определяется из конфига
        private List<string> Category = new List<string>();// Список категорий, определяется из конфига
        private string SearchPatternForMode0 = String.Empty;// Критерий поиска проблем, в зависимости от площадки, используется только при режиме "0"
        private string Mode = String.Empty;// Режим работы формы, берется из конфига 

        public Form1()
        {
            InitializeComponent();

            Point pt = Screen.PrimaryScreen.WorkingArea.Location;                                           //
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);     // Помещение формы в нижний правый угол
            pt.Offset(-this.Width, -this.Height);                                                           //
            this.Location = pt;                                                                             //

            if (!Directory.Exists(Application.StartupPath + @"\.tmp"))
                Directory.CreateDirectory(Application.StartupPath + @"\.tmp");
            Startup();
        }

        private void Startup()
        {
            UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            if (UserName.Contains('\\'))
            {
                string[] splitter = UserName.Split('\\');    // Получение имени пользователя
                NameLabel.Text = splitter[1];                //
            }
            else
                NameLabel.Text = UserName;

            int IsConfigReaded = StartupReadConfig();// Проверка существования конфига

            if (IsConfigReaded == 1)
            {
                return;
            }
            else
                ErrorConfPanel.Visible = false;


            Mode = ReadConfig(GlobalConfig, "#Mode");// Получение режима работы программы

            if (Mode == "0")// Изменение внешнего вида формы в зависимости от режима
            {
                Size = new Size(298, 477);
                GroupsPanel.Visible = true;
                GroupsPanel.Location = new Point(-1, 39);
                panel1.Location = new Point(-1, 85);
                comboBox1.Enabled = false;
                SuccessfullySended.Size = new Size(298, 450);
                SuccessfullySended.Location = new Point(-1, 39);
            }

            Point pt = Screen.PrimaryScreen.WorkingArea.Location;                                           //
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);     // Помещение формы в нижний правый угол
            pt.Offset(-this.Width, -this.Height);                                                           //
            this.Location = pt;

            string domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;// Получение домена

            List <string> Domains = new List <string>();
            List <string> DomainNameForHelpDesk = new List <string>();

            ReadConfig(GlobalConfig, "#Domains", Domains, 2, null, DomainNameForHelpDesk);// Получение списка доменов и названий площадок для этих доменов

            if (domain == Domains[0]) // Получение списка групп и проблем/проблем для текущего домена
            {
                Domain = DomainNameForHelpDesk[0];
                if (Mode == "1")
                {
                    ReadConfig(GlobalConfig, "#Problems_MSK", Groups, 1, comboBox1, Category);
                }
                else if (Mode == "0")
                {
                    ReadConfig(GlobalConfig, "#Groups_List_MSK", Groups, 0,comboBox2);
                    SearchPatternForMode0 = "#Problems_For_Groups_MSK";
                }
                else
                {
                    NameLabel.Text = "Ошибка режима в конфиге";
                    panel1.Enabled = false;
                    return;
                }
            }
            else if (domain == Domains[1])
            {
                Domain = DomainNameForHelpDesk[1];
                if (Mode == "1")
                {
                    ReadConfig(GlobalConfig, "#Problems_Sibir", Groups, 1, comboBox1, Category);
                }
                else if (Mode == "0")
                {
                    ReadConfig(GlobalConfig, "#Groups_List_Sibir", Groups, 0, comboBox2);
                    SearchPatternForMode0 = "#Problems_For_Groups_Sibir";
                }
                else
                {
                    NameLabel.Text = "Ошибка режима в конфиге";
                    panel1.Enabled = false;
                    return;
                }
            }
            else if (domain == Domains[2])
            {
                Domain = DomainNameForHelpDesk[2];
                if (Mode == "1")
                {
                    ReadConfig(GlobalConfig, "#Problems_S", Groups, 1, comboBox1, Category);
                }
                else if (Mode == "0")
                {
                    ReadConfig(GlobalConfig, "#Groups_List_S", Groups, 0, comboBox2);
                    SearchPatternForMode0 = "#Problems_For_Groups_S";
                }
                else
                {
                    NameLabel.Text = "Ошибка режима в конфиге";
                    panel1.Enabled = false;
                    return;
                }
            }
            else if (domain == Domains[3])
            {
                Domain = DomainNameForHelpDesk[3];
                if (Mode == "1")
                {
                    ReadConfig(GlobalConfig, "#Problems_SPB", Groups, 1, comboBox1, Category);
                }
                else if (Mode == "0")
                {
                    ReadConfig(GlobalConfig, "#Groups_List_SPB", Groups, 0, comboBox2);
                    SearchPatternForMode0 = "#Problems_For_Groups_SPB";
                }
                else
                {
                    NameLabel.Text = "Ошибка режима в конфиге";
                    panel1.Enabled = false;
                    return;
                }
            }
            else
            {
                NameLabel.Text = "Ошибка домена";
                panel1.Enabled = false;
                return;
            }
        }// Запуск программы 

        private void Submit_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == String.Empty)
            {
                ChooseFile_Label.Text = "Поле тема не может быть пустым";
                return;
            }
            if (comboBox1.Text == String.Empty)
            {
                ChooseFile_Label.Text = "Выберите проблему";
                return;
            }

            ChooseFile_Label.Text = String.Empty;
            string Name = GetUserEmailAddress(NameLabel.Text);
            string Title = "@@@" + TitleTextBox.Text + "@@@";
            string Body = MessageTextBox.Text;
            

            if (!String.IsNullOrEmpty(PathScreen))
                Attachments.Add(PathScreen);

            string HelpDeskMail = ReadConfig(GlobalConfig, "#Helpdesk_mail");// Почта назначения
            List<string> Hosts = new List<string>();
            ReadConfig(GlobalConfig, "#PostServers", Hosts, 0);// Получение списка почтовых серверов

            MailMessage mail = new MailMessage();
            mail.SubjectEncoding = Encoding.GetEncoding(1251);
            mail.From = new MailAddress(Name);
            mail.To.Add(new MailAddress(HelpDeskMail));
            mail.Subject = Title;
            if (Mode == "0")
            {
                mail.Body = Body + "\n\n\n\n\n\n\n\n\n\n@@Site=" + Domain + "@@\n" + "@@GROUP=" + Groups[comboBox2.SelectedIndex] + "@@\n" + "@@CATEGORY=" + Category[comboBox1.SelectedIndex] + "@@\n";
            }
            else if (Mode == "1")
            {
                mail.Body = Body + "\n\n\n\n\n\n\n\n\n\n@@Site=" + Domain + "@@\n" + "@@GROUP=" + Groups[comboBox1.SelectedIndex] + "@@\n" + "@@CATEGORY=" + Category[comboBox1.SelectedIndex] + "@@\n";
            }
            else
            {
                NameLabel.Text = "Ошибка режима в конфиге";
                panel1.Enabled = false;
                return;
            }
            if (Attachments.Count != 0)
            {
                try
                {
                    mail.Attachments.Add(new Attachment(Attachments[0]));
                    switch (Attachments.Count)
                    {
                        case 2:
                            mail.Attachments.Add(new Attachment(Attachments[1]));
                            break;
                        case 3:
                            mail.Attachments.Add(new Attachment(Attachments[1]));
                            mail.Attachments.Add(new Attachment(Attachments[2]));
                            break;
                        default:
                            break;
                    }
                }
                catch (System.UnauthorizedAccessException)
                {
                    ChooseFile_Label.Text = "Нельзя отправлять папки";
                    return;
                }
            }
            SmtpClient client = new SmtpClient();
            client.Host = Hosts[0];
            client.Port = 25;
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(mail);
            }
            catch (System.Security.Authentication.AuthenticationException) 
            {
                try
                {
                    client.Host = Hosts[1];
                    client.Send(mail);
                }
                catch (System.Security.Authentication.AuthenticationException)
                {
                    try
                    {
                        client.Host = Hosts[2];
                        client.Send(mail);
                    }
                    catch (SmtpException)
                    {
                        ChooseFile_Label.Text = "Ошибка почтового сервера";
                        return;
                    }
                }
            }
            mail.Dispose();
            SuccessfullySended.Visible = true;

            //------------------------------------------Чистка после отправки
            if (Mode == "0")
            {
                comboBox1.Items.Clear();
                Category.Clear();
                comboBox1.Enabled = false;
                comboBox2.SelectedIndex = -1;
            }
            TitleTextBox.Text = String.Empty;
            MessageTextBox.Text = String.Empty;
            Attachments.Clear();
            comboBox1.SelectedIndex = -1;
            ChooseFile_Label.Text = String.Empty;
            ScreenPanel.Visible = false;
            ScreenPIC.Image = null;
            PathScreen = String.Empty;

            Label[] Labels = { Attach1, Attach2};
            Panel[] Panels = { AttachPanel1, AttachPanel2 };
            for (int i = 0; i < Labels.Length; i++)
            {
                Labels[i].Text = String.Empty;
                InvPaths[i] = String.Empty;
                Panels[i].Visible = false;
            }
        } // Отправка формы

        #region Методы для чтения конфига

        private int StartupReadConfig()
        {
            LocalConfig = File.ReadAllLines(Environment.CurrentDirectory + @"\config.ini", Encoding.GetEncoding(1251));// Чтение локального конфига
            PathToGlobalConf = ReadConfig(LocalConfig, "#PathToGlobalConfig");// Путь к глобальному конфигу, взятый из локального
            string NewPathToGlobalConf = String.Empty;// Пустой новый путь
            try
            {
                GlobalConfig = File.ReadAllLines(PathToGlobalConf, Encoding.GetEncoding(1251));// Чтение глобального конфига по пути из локального
                NewPathToGlobalConf = ReadConfig(GlobalConfig, "#PathToGlobalConfig");// Запись пути к глобальному конфигу из глобального конфига
                GlobalConfig = File.ReadAllLines(NewPathToGlobalConf, Encoding.GetEncoding(1251));// Чтение глобального конфига по пути из глобального конфига, нужно для работы программы с актуальным конфигом
            }
            catch (System.IO.FileNotFoundException)
            {
                ErrorConfPanel.Visible = true;
                panel1.Visible = true;
                SuccessfullySended.Visible = false;
                return 1;
            }

            File.WriteAllText(Application.StartupPath + @"\config.ini", "#PathToGlobalConfig\n\"" + NewPathToGlobalConf + "\"\n###", Encoding.GetEncoding(1251));//Перезапись пути в локальном конфиге
            return 0;
        }// Стартовое чтение конфига

        private void ReadConfig(string[] Input, string SearchPattern, List<string> Output, int mode, ComboBox comboBox = null, List <string> Output1 = null)
        {
            string buff = String.Empty;
            string[] splitter;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].Contains(SearchPattern))// Проверка содержания указанного критерия
                {
                    i++;
                    for (int k = 0; k < Input.Length; k++)
                    {
                        if (Input[i] == "###")// Для остановки чтения
                        {
                            break;
                        }
                        else if (Input[i] != "###")
                        {
                            if (mode == 0)// Режим 0 для обработки строк типа "значение"
                            {
                                buff = Input[i];
                                buff = buff.Remove(0, 1);
                                buff = buff.Remove(buff.Length - 1, 1);

                                Output.Add(buff);
                                i++;
                                if (comboBox != null)// Используется только при режиме "0" для занесения групп в комбобокс
                                {
                                    comboBox.Items.Add(buff);
                                }
                            }
                            else if (mode == 1)// Режим 1 для обработки строк типа {"значение";"значение";"значение"}
                            {
                                buff = Input[i];
                                splitter = buff.Split(';');
                                splitter[0] = splitter[0].Remove(0, 2);
                                splitter[0] = splitter[0].Remove(splitter[0].Length - 1, 1);
                                splitter[1] = splitter[1].Remove(0, 1);
                                splitter[1] = splitter[1].Remove(splitter[1].Length - 1, 1);
                                splitter[2] = splitter[2].Remove(0, 1);
                                splitter[2] = splitter[2].Remove(splitter[2].Length - 2, 2);

                                comboBox.Items.Add(splitter[0]);
                                Output.Add(splitter[1]);
                                Output1.Add(splitter[2]);
                                i++;
                            }
                            else if (mode == 2)// Режим 2 для обработки строк типа {"значение";"значение"}
                            {
                                buff = Input[i];
                                splitter = buff.Split(';');
                                splitter[0] = splitter[0].Remove(0, 2);
                                splitter[0] = splitter[0].Remove(splitter[0].Length - 1, 1);
                                splitter[1] = splitter[1].Remove(0, 1);
                                splitter[1] = splitter[1].Remove(splitter[1].Length - 2, 2);

                                Output.Add(splitter[0]);
                                Output1.Add(splitter[1]);
                                i++;
                            }
                        }
                    }
                    break;
                }
            }
        } // Чтение конфига. Ищет по одному критерию, используется в обоих режимах

        private void ReadConfig(string[] Input, string SearchPattern1, string SearchPattern2, List<string> OutputList, ComboBox comboBox)
        {
            string[] splitter;

            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].Contains(SearchPattern1))// Поиск совпадения по 1 критерию
                {
                    i++;
                    for (int k = 0; k < Input.Length; k++)
                    {
                        if (Input[i] == "###")// Для остановки
                        {
                            break;
                        }
                        else if (Input[i] != "###")
                        {
                            splitter = Input[i].Split(';');
                            if (splitter[0].Contains(SearchPattern2))// Поиск совпадения по второму критерию в значениях, найденных по 1 критерию
                            {
                                for (int j = 1; j < splitter.Length; j++)
                                {

                                    if (j == splitter.Length - 1)// Обработка последнего значения в строке
                                    {
                                        splitter[j] = splitter[j].Remove(0, 1);
                                        splitter[j] = splitter[j].Remove(splitter[j].Length - 2, 2);
                                        OutputList.Add(splitter[j]);
                                    }
                                    else
                                    {
                                        if (j % 2 != 0)// Если не четное отправляется в комбобокс
                                        {
                                            splitter[j] = splitter[j].Remove(0, 1);
                                            splitter[j] = splitter[j].Remove(splitter[j].Length - 1, 1);
                                            comboBox.Items.Add(splitter[j]);
                                        }
                                        else// Четное в лист
                                        {
                                            splitter[j] = splitter[j].Remove(0, 1);
                                            splitter[j] = splitter[j].Remove(splitter[j].Length - 1, 1);
                                            OutputList.Add(splitter[j]);
                                        }
                                    }
                                    
                                }
                            }
                            i++;
                        }
                    }
                    break;
                }
            }
        } // Чтение конфига. Ищет по двум критериям, используется только при режиме "0"

        private string ReadConfig(string[] Input, string SearchPattern)
        {
            string result = String.Empty;
            // Обрабатывает строки вида "значение"
            for (int i = 0; i < Input.Length; i++)
            {
                if (Input[i].Contains(SearchPattern))
                {
                    i++;
                    for (int k = 0; k < Input.Length; k++)
                    {
                        if (Input[i] == "###")
                        {
                            break;
                        }
                        else if (Input[i] != "###")
                        {
                            result = Input[i];
                            result = result.Remove(0, 1);
                            result = result.Remove(result.Length-1, 1);
                        }
                    }
                    break;
                }
            }
            return result;
        } // Чтение конфига. Вернет строку

        #endregion

        #region Кнопки, взаимодействие с формой

        private void ErrorConfButton_Click(object sender, EventArgs e)
        {
            label9.Text = String.Empty;
            if (String.IsNullOrEmpty(ErrorConfTextBox.Text))// Если строка пустая, то ничего не делать
                return;
            try
            {
                GlobalConfig = File.ReadAllLines(ErrorConfTextBox.Text, Encoding.GetEncoding(1251));// Запись конфига по указанному пути
            }
            catch (System.ArgumentException)
            {
                label9.Text = "Путь содержит недопустимые символы";
                return;
            }
            catch (System.IO.FileNotFoundException)
            {
                return;
            }
            File.WriteAllText(Application.StartupPath + @"\config.ini", "#PathToGlobalConfig\n\"" + ErrorConfTextBox.Text + "\"\n###", Encoding.GetEncoding(1251));// Запись нового пути в локальный конфиг
            Startup();
        }// Кнопка ошибки конфига 

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Visible == false)
            {
                SuccessfullySended.Visible = false;
                notifyIcon1.Visible = true;
                Visible = true;
            }
            else
            {
                notifyIcon1.Visible = true;
                Visible = false;
            }
        }// Разворачивание формы

        private void Hide_Button_Click(object sender, EventArgs e)
        {
            Submit.Text = "Отправить";
            Submit.BackColor = System.Drawing.Color.FromArgb((164), (204), (65));
            notifyIcon1.Visible = true;
            Visible = false;
        }// Сворачивание формы

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }// Выход из программы

        private void TakeScreenshot(object sender, EventArgs e)
        {
            Visible = false;
            Bitmap bmp1;
            System.Windows.Media.Color ColorBackScreen = System.Windows.Media.Colors.Black;
            System.Windows.Media.Brush BrushLinesRect = System.Windows.Media.Brushes.Red;
            BitmapSource bmpImage =
                ScreenFixCore.ScreenshotMaker.BeginSelectionImageFromScreen(BrushLinesRect, 1.0d, ColorBackScreen);
            Bitmap bitmap;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bmpImage));
                enc.Save(outStream);
                bitmap = new Bitmap(outStream);
            }
            bmp1 = new Bitmap(bitmap);
            bmp1.Save(Application.StartupPath + @"\.tmp\screenshot.png", ImageFormat.Png);
            ScreenPIC.Image = bmp1;

            ScreenPanel.Visible = true;
            PathScreen = Application.StartupPath + @"\.tmp\screenshot.png";
            Visible = true;
        }// Скриншот

        private void HideButtonSuccess(object sender, EventArgs e)
        {
            SuccessfullySended.Visible = false;
            notifyIcon1.Visible = true;
            Visible = false;
        }// Сворачивание после отправки

        private void NewRequestSuccess(object sender, EventArgs e)
        {
            SuccessfullySended.Visible = false;
        }// Новый запрос после отправки

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            Category.Clear();
            comboBox1.Enabled = true;
            ReadConfig(GlobalConfig, SearchPatternForMode0, comboBox2.Text, Category, comboBox1);// Получение списка проблем для выбранной группы
        }// Определение набора проблем в зависимости от групы

        #endregion

        #region Методы, отвечающие за вложения 

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (Attachments.Count >= 2)
            {
                ChooseFile_Label.Text = "Максимум 2 файла";
                return;
            }
            openFileDialog1.FileName = String.Empty;
            openFileDialog1.InitialDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            openFileDialog1.ShowDialog();// Открытие диалогового окна в папке пользователя

            FileInfo finfo;
            string[] ChoosedFiles = openFileDialog1.FileNames;
            if (ChoosedFiles.Length > 2)
            {
                ChooseFile_Label.Text = "Максимум 2 файла";
                return;
            }
            else if (ChoosedFiles.Length == 2 && Attachments.Count == 1)
            {
                ChooseFile_Label.Text = "Максимум 2 файла";
                return;
            }
            if (!String.IsNullOrEmpty(ChoosedFiles[0]))
            {
                List<string> BannedExtensions = new List<string>();
                ReadConfig(GlobalConfig, "#Banned_extensions", BannedExtensions, 0);

                for (int i = 0; i < ChoosedFiles.Length; i++)// Проверка расширения файлов
                {
                    for (int k = 0; k < BannedExtensions.Count; k++)
                    {
                        if (Regex.IsMatch(ChoosedFiles[i], BannedExtensions[k]))
                        {
                            finfo = new FileInfo(ChoosedFiles[i]);
                            ChooseFile_Label.Text = "Недопустимый формат" + finfo.Extension;
                            return;
                        }
                    }
                }
                    ChooseFile_Label.Text = "Вложения добавлены!";

            }
            else { ChooseFile_Label.Text = "Вложения не выбраны"; return; }

            for (int i = 0; i < ChoosedFiles.Length; i++)
            {
                Attachments.Add(ChoosedFiles[i]);
            }

            Label[] Labels = {Attach1,Attach2};
            Panel[] panels = { AttachPanel1, AttachPanel2 };

            for (int i = 0; i < Attachments.Count; i++)
            {
                panels[i].Visible = true;
                finfo = new FileInfo(Attachments[i]);
                Labels[i].Text = finfo.Name;

                InvPaths[i] = Attachments[i];
            }
        } // Выбор файла

        private void AttachDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        } // Drag&Drop

        private void ChooseFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop); // получение перетянутых файлов

            if (Attachments.Count >= 2)
            {
                ChooseFile_Label.Text = "Максимум 2 файла";
                return;
            }

            FileInfo finfo;

            if (files.Length > 2)
            {
                ChooseFile_Label.Text = "Максимум 2 файла";
                return;
            }
            else if (files.Length == 2 && Attachments.Count == 1)
            {
                ChooseFile_Label.Text = "Максимум 2 файла";
                return;
            }
            if (!String.IsNullOrEmpty(files[0]))
            {
                List<string> BannedExtensions = new List<string>();
                ReadConfig(GlobalConfig, "#Banned_extensions", BannedExtensions, 0);

                for (int i = 0; i < files.Length; i++) // проверка расширения файлов
                {
                    for (int k = 0; k < BannedExtensions.Count; k++)
                    {
                        if (Regex.IsMatch(files[i], BannedExtensions[k]))
                        {
                            finfo = new FileInfo(files[i]);
                            ChooseFile_Label.Text = "Недопустимый формат" + finfo.Extension;
                            return;
                        }
                    }
                }
                ChooseFile_Label.Text = "Вложения добавлены!";

            }
            else { ChooseFile_Label.Text = "Вложения не выбраны"; return; }

            for (int i = 0; i < files.Length; i++)
            {
                Attachments.Add(files[i]);
            }

            Label[] Labels = { Attach1, Attach2 };
            Panel[] panels = { AttachPanel1, AttachPanel2 };

            for (int i = 0; i < Attachments.Count; i++)
            {
                panels[i].Visible = true;
                finfo = new FileInfo(Attachments[i]);
                Labels[i].Text = finfo.Name;

                InvPaths[i] = Attachments[i];
            }
        } // Drag&Drop 

        //--------Удаление вложений---------
        private void RemoveAttachment(List<string> input, string hiddenpath, Panel panel, Label Attachname = null)
        {
            input.Remove(hiddenpath);
            if (Attachname != null)
                Attachname.Text = String.Empty;
            hiddenpath = String.Empty;
            panel.Visible = false;
        }// Удаление из листа вложений
        private void RemoveAttach1_Click(object sender, EventArgs e)
        {
            RemoveAttachment(Attachments, InvPaths[0], AttachPanel1, Attach1);
            if (Attach1.Text == String.Empty && Attach2.Text == String.Empty)
            {
                ChooseFile_Label.Text = String.Empty;
            }
        }// Первый крестик
        private void RemoveAttach2_Click(object sender, EventArgs e)
        {
            RemoveAttachment(Attachments, InvPaths[1], AttachPanel2, Attach2);
            if (Attach1.Text == String.Empty && Attach2.Text == String.Empty)
            {
                ChooseFile_Label.Text = String.Empty;
            }
        }// Второй крестик
        private void RemoveAttach3_Click(object sender, EventArgs e)
        {
            RemoveAttachment(Attachments, PathScreen, ScreenPanel);
            if (Attach1.Text == String.Empty && Attach2.Text == String.Empty)
            {
                ChooseFile_Label.Text = String.Empty;
            }
        }// Третий крестик
        //----------------------------------

        #endregion

        private string GetUserEmailAddress(string accountName)
        {
            if (accountName.Contains('\\'))
            {
                accountName = accountName.Split('\\')[1];
            }

            DirectorySearcher searcher = new DirectorySearcher();
            searcher.Filter = String.Format("(&(objectCategory=user)(sAMAccountName={0}))", accountName);
            searcher.PropertiesToLoad.Add("mail");

            SearchResult searchResult = searcher.FindOne();

            return Convert.ToString(searchResult.Properties["mail"][0]);
        }// Получение почты пользователя из AD
    }
}