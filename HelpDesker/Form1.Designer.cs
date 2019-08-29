namespace HelpDesker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hide_Button = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttachPanel2 = new System.Windows.Forms.Panel();
            this.Attach2 = new System.Windows.Forms.Label();
            this.AttachICO2 = new System.Windows.Forms.PictureBox();
            this.RemoveAttach2 = new System.Windows.Forms.PictureBox();
            this.ErrorConfPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorConfButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ErrorConfTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AttachPanel1 = new System.Windows.Forms.Panel();
            this.Attach1 = new System.Windows.Forms.Label();
            this.AttachICO1 = new System.Windows.Forms.PictureBox();
            this.RemoveAttach1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.RemoveAttach3 = new System.Windows.Forms.PictureBox();
            this.ScreenPIC = new System.Windows.Forms.PictureBox();
            this.AttachEmpty1 = new System.Windows.Forms.Panel();
            this.AttachEmpty2 = new System.Windows.Forms.Panel();
            this.ChooseFile_Label = new System.Windows.Forms.Label();
            this.ScreenEmpty = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuccessfullySended = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupsPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AttachPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttachICO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttach2)).BeginInit();
            this.ErrorConfPanel.SuspendLayout();
            this.AttachPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttachICO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttach1)).BeginInit();
            this.ScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttach3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenPIC)).BeginInit();
            this.SuccessfullySended.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HelpDesker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::HelpDesker.Properties.Resources.exit;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Hide_Button
            // 
            this.Hide_Button.BackColor = System.Drawing.Color.Transparent;
            this.Hide_Button.ContextMenuStrip = this.contextMenuStrip1;
            this.Hide_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hide_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hide_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Hide_Button.Location = new System.Drawing.Point(273, 3);
            this.Hide_Button.Name = "Hide_Button";
            this.Hide_Button.Size = new System.Drawing.Size(25, 25);
            this.Hide_Button.TabIndex = 5;
            this.Hide_Button.TabStop = false;
            this.Hide_Button.Text = "X";
            this.Hide_Button.UseVisualStyleBackColor = false;
            this.Hide_Button.Click += new System.EventHandler(this.Hide_Button_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(204)))), ((int)(((byte)(65)))));
            this.Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Submit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(12, 346);
            this.Submit.Margin = new System.Windows.Forms.Padding(10);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(270, 37);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Отправить";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleTextBox.Location = new System.Drawing.Point(12, 69);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(270, 23);
            this.TitleTextBox.TabIndex = 2;
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.MessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(12, 113);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(287, 106);
            this.MessageTextBox.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(40, 8);
            this.NameLabel.MaximumSize = new System.Drawing.Size(165, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(76, 20);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Username";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Тема";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Описание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Multiselect = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.AttachPanel2);
            this.panel1.Controls.Add(this.ErrorConfPanel);
            this.panel1.Controls.Add(this.AttachPanel1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ScreenPanel);
            this.panel1.Controls.Add(this.AttachEmpty1);
            this.panel1.Controls.Add(this.AttachEmpty2);
            this.panel1.Controls.Add(this.ChooseFile_Label);
            this.panel1.Controls.Add(this.ScreenEmpty);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.TitleTextBox);
            this.panel1.Controls.Add(this.MessageTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 396);
            this.panel1.TabIndex = 27;
            // 
            // AttachPanel2
            // 
            this.AttachPanel2.BackgroundImage = global::HelpDesker.Properties.Resources.dragdrop_blank;
            this.AttachPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AttachPanel2.Controls.Add(this.Attach2);
            this.AttachPanel2.Controls.Add(this.AttachICO2);
            this.AttachPanel2.Controls.Add(this.RemoveAttach2);
            this.AttachPanel2.Location = new System.Drawing.Point(104, 230);
            this.AttachPanel2.Name = "AttachPanel2";
            this.AttachPanel2.Size = new System.Drawing.Size(86, 86);
            this.AttachPanel2.TabIndex = 43;
            this.AttachPanel2.Visible = false;
            // 
            // Attach2
            // 
            this.Attach2.AutoEllipsis = true;
            this.Attach2.BackColor = System.Drawing.Color.Transparent;
            this.Attach2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attach2.Location = new System.Drawing.Point(5, 61);
            this.Attach2.Name = "Attach2";
            this.Attach2.Size = new System.Drawing.Size(84, 29);
            this.Attach2.TabIndex = 27;
            // 
            // AttachICO2
            // 
            this.AttachICO2.Image = global::HelpDesker.Properties.Resources.file;
            this.AttachICO2.Location = new System.Drawing.Point(30, 28);
            this.AttachICO2.Name = "AttachICO2";
            this.AttachICO2.Size = new System.Drawing.Size(32, 32);
            this.AttachICO2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttachICO2.TabIndex = 32;
            this.AttachICO2.TabStop = false;
            // 
            // RemoveAttach2
            // 
            this.RemoveAttach2.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAttach2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAttach2.Image = ((System.Drawing.Image)(resources.GetObject("RemoveAttach2.Image")));
            this.RemoveAttach2.Location = new System.Drawing.Point(61, 4);
            this.RemoveAttach2.Name = "RemoveAttach2";
            this.RemoveAttach2.Size = new System.Drawing.Size(20, 20);
            this.RemoveAttach2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemoveAttach2.TabIndex = 30;
            this.RemoveAttach2.TabStop = false;
            this.RemoveAttach2.Click += new System.EventHandler(this.RemoveAttach2_Click);
            // 
            // ErrorConfPanel
            // 
            this.ErrorConfPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ErrorConfPanel.Controls.Add(this.label9);
            this.ErrorConfPanel.Controls.Add(this.ErrorConfButton);
            this.ErrorConfPanel.Controls.Add(this.label7);
            this.ErrorConfPanel.Controls.Add(this.ErrorConfTextBox);
            this.ErrorConfPanel.Controls.Add(this.label6);
            this.ErrorConfPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorConfPanel.Location = new System.Drawing.Point(0, 0);
            this.ErrorConfPanel.Name = "ErrorConfPanel";
            this.ErrorConfPanel.Size = new System.Drawing.Size(299, 396);
            this.ErrorConfPanel.TabIndex = 47;
            this.ErrorConfPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(2, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 23);
            this.label9.TabIndex = 4;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorConfButton
            // 
            this.ErrorConfButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(204)))), ((int)(((byte)(64)))));
            this.ErrorConfButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ErrorConfButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorConfButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorConfButton.Location = new System.Drawing.Point(3, 197);
            this.ErrorConfButton.Name = "ErrorConfButton";
            this.ErrorConfButton.Size = new System.Drawing.Size(293, 33);
            this.ErrorConfButton.TabIndex = 3;
            this.ErrorConfButton.Text = "Продолжить";
            this.ErrorConfButton.UseVisualStyleBackColor = false;
            this.ErrorConfButton.Click += new System.EventHandler(this.ErrorConfButton_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Укажите путь к новому конфигу";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorConfTextBox
            // 
            this.ErrorConfTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.ErrorConfTextBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorConfTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ErrorConfTextBox.Location = new System.Drawing.Point(3, 163);
            this.ErrorConfTextBox.Name = "ErrorConfTextBox";
            this.ErrorConfTextBox.Size = new System.Drawing.Size(293, 23);
            this.ErrorConfTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Конфиг не найден";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttachPanel1
            // 
            this.AttachPanel1.BackgroundImage = global::HelpDesker.Properties.Resources.dragdrop_blank;
            this.AttachPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AttachPanel1.Controls.Add(this.Attach1);
            this.AttachPanel1.Controls.Add(this.AttachICO1);
            this.AttachPanel1.Controls.Add(this.RemoveAttach1);
            this.AttachPanel1.Location = new System.Drawing.Point(12, 230);
            this.AttachPanel1.Name = "AttachPanel1";
            this.AttachPanel1.Size = new System.Drawing.Size(86, 86);
            this.AttachPanel1.TabIndex = 42;
            this.AttachPanel1.Visible = false;
            // 
            // Attach1
            // 
            this.Attach1.AutoEllipsis = true;
            this.Attach1.BackColor = System.Drawing.Color.Transparent;
            this.Attach1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attach1.Location = new System.Drawing.Point(3, 61);
            this.Attach1.Name = "Attach1";
            this.Attach1.Size = new System.Drawing.Size(88, 29);
            this.Attach1.TabIndex = 26;
            // 
            // AttachICO1
            // 
            this.AttachICO1.Image = global::HelpDesker.Properties.Resources.file;
            this.AttachICO1.InitialImage = null;
            this.AttachICO1.Location = new System.Drawing.Point(29, 28);
            this.AttachICO1.Name = "AttachICO1";
            this.AttachICO1.Size = new System.Drawing.Size(32, 32);
            this.AttachICO1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttachICO1.TabIndex = 31;
            this.AttachICO1.TabStop = false;
            // 
            // RemoveAttach1
            // 
            this.RemoveAttach1.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAttach1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveAttach1.BackgroundImage")));
            this.RemoveAttach1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveAttach1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAttach1.Location = new System.Drawing.Point(61, 4);
            this.RemoveAttach1.Name = "RemoveAttach1";
            this.RemoveAttach1.Size = new System.Drawing.Size(20, 20);
            this.RemoveAttach1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemoveAttach1.TabIndex = 29;
            this.RemoveAttach1.TabStop = false;
            this.RemoveAttach1.Click += new System.EventHandler(this.RemoveAttach1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(179, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(165, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "*";
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.BackgroundImage = global::HelpDesker.Properties.Resources.dragdrop_blank;
            this.ScreenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScreenPanel.Controls.Add(this.RemoveAttach3);
            this.ScreenPanel.Controls.Add(this.ScreenPIC);
            this.ScreenPanel.Location = new System.Drawing.Point(196, 230);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Size = new System.Drawing.Size(86, 86);
            this.ScreenPanel.TabIndex = 44;
            this.ScreenPanel.Visible = false;
            // 
            // RemoveAttach3
            // 
            this.RemoveAttach3.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAttach3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveAttach3.Image = ((System.Drawing.Image)(resources.GetObject("RemoveAttach3.Image")));
            this.RemoveAttach3.Location = new System.Drawing.Point(59, 4);
            this.RemoveAttach3.Name = "RemoveAttach3";
            this.RemoveAttach3.Size = new System.Drawing.Size(20, 20);
            this.RemoveAttach3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemoveAttach3.TabIndex = 31;
            this.RemoveAttach3.TabStop = false;
            this.RemoveAttach3.Click += new System.EventHandler(this.RemoveAttach3_Click);
            // 
            // ScreenPIC
            // 
            this.ScreenPIC.Location = new System.Drawing.Point(6, 6);
            this.ScreenPIC.Name = "ScreenPIC";
            this.ScreenPIC.Size = new System.Drawing.Size(74, 74);
            this.ScreenPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ScreenPIC.TabIndex = 33;
            this.ScreenPIC.TabStop = false;
            // 
            // AttachEmpty1
            // 
            this.AttachEmpty1.AllowDrop = true;
            this.AttachEmpty1.BackgroundImage = global::HelpDesker.Properties.Resources.dragdrop;
            this.AttachEmpty1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AttachEmpty1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttachEmpty1.Location = new System.Drawing.Point(12, 230);
            this.AttachEmpty1.Name = "AttachEmpty1";
            this.AttachEmpty1.Size = new System.Drawing.Size(86, 86);
            this.AttachEmpty1.TabIndex = 41;
            this.AttachEmpty1.Click += new System.EventHandler(this.ChooseFile_Click);
            this.AttachEmpty1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChooseFile_DragDrop);
            this.AttachEmpty1.DragEnter += new System.Windows.Forms.DragEventHandler(this.AttachDragEnter);
            // 
            // AttachEmpty2
            // 
            this.AttachEmpty2.AllowDrop = true;
            this.AttachEmpty2.BackgroundImage = global::HelpDesker.Properties.Resources.dragdrop;
            this.AttachEmpty2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AttachEmpty2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttachEmpty2.Location = new System.Drawing.Point(104, 230);
            this.AttachEmpty2.Name = "AttachEmpty2";
            this.AttachEmpty2.Size = new System.Drawing.Size(86, 86);
            this.AttachEmpty2.TabIndex = 41;
            this.AttachEmpty2.Click += new System.EventHandler(this.ChooseFile_Click);
            this.AttachEmpty2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChooseFile_DragDrop);
            this.AttachEmpty2.DragEnter += new System.Windows.Forms.DragEventHandler(this.AttachDragEnter);
            // 
            // ChooseFile_Label
            // 
            this.ChooseFile_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseFile_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChooseFile_Label.Location = new System.Drawing.Point(3, 327);
            this.ChooseFile_Label.Name = "ChooseFile_Label";
            this.ChooseFile_Label.Size = new System.Drawing.Size(279, 16);
            this.ChooseFile_Label.TabIndex = 26;
            this.ChooseFile_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenEmpty
            // 
            this.ScreenEmpty.BackgroundImage = global::HelpDesker.Properties.Resources.takescreenshot;
            this.ScreenEmpty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ScreenEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScreenEmpty.Location = new System.Drawing.Point(196, 230);
            this.ScreenEmpty.Name = "ScreenEmpty";
            this.ScreenEmpty.Size = new System.Drawing.Size(86, 86);
            this.ScreenEmpty.TabIndex = 40;
            this.ScreenEmpty.Click += new System.EventHandler(this.TakeScreenshot);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Проблема";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 10);
            this.panel2.TabIndex = 32;
            // 
            // SuccessfullySended
            // 
            this.SuccessfullySended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.SuccessfullySended.Controls.Add(this.button1);
            this.SuccessfullySended.Controls.Add(this.label8);
            this.SuccessfullySended.Controls.Add(this.button2);
            this.SuccessfullySended.Location = new System.Drawing.Point(-1, 35);
            this.SuccessfullySended.Name = "SuccessfullySended";
            this.SuccessfullySended.Size = new System.Drawing.Size(299, 396);
            this.SuccessfullySended.TabIndex = 48;
            this.SuccessfullySended.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(85)))), ((int)(((byte)(55)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(13, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Свернуть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.HideButtonSuccess);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(2, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Успешно отправлено!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(204)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(154, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Новая заявка";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NewRequestSuccess);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HelpDesker.Properties.Resources.SDP;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // GroupsPanel
            // 
            this.GroupsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.GroupsPanel.Controls.Add(this.label11);
            this.GroupsPanel.Controls.Add(this.comboBox2);
            this.GroupsPanel.Controls.Add(this.label10);
            this.GroupsPanel.Location = new System.Drawing.Point(254, 12);
            this.GroupsPanel.Name = "GroupsPanel";
            this.GroupsPanel.Size = new System.Drawing.Size(299, 47);
            this.GroupsPanel.TabIndex = 49;
            this.GroupsPanel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(170, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "*";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 21);
            this.comboBox2.MaxDropDownItems = 5;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(270, 26);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(296, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Группа";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(298, 435);
            this.Controls.Add(this.SuccessfullySended);
            this.Controls.Add(this.GroupsPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hide_Button);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HelpDesker";
            this.TopMost = true;
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AttachPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttachICO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttach2)).EndInit();
            this.ErrorConfPanel.ResumeLayout(false);
            this.ErrorConfPanel.PerformLayout();
            this.AttachPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttachICO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttach1)).EndInit();
            this.ScreenPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveAttach3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenPIC)).EndInit();
            this.SuccessfullySended.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupsPanel.ResumeLayout(false);
            this.GroupsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Hide_Button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox RemoveAttach3;
        private System.Windows.Forms.PictureBox RemoveAttach2;
        private System.Windows.Forms.PictureBox RemoveAttach1;
        private System.Windows.Forms.Label Attach2;
        private System.Windows.Forms.Label Attach1;
        private System.Windows.Forms.Label ChooseFile_Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AttachEmpty1;
        private System.Windows.Forms.Panel AttachEmpty2;
        private System.Windows.Forms.Panel ScreenEmpty;
        private System.Windows.Forms.Panel ScreenPanel;
        private System.Windows.Forms.Panel AttachPanel2;
        private System.Windows.Forms.Panel AttachPanel1;
        private System.Windows.Forms.PictureBox ScreenPIC;
        private System.Windows.Forms.PictureBox AttachICO2;
        private System.Windows.Forms.PictureBox AttachICO1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ErrorConfPanel;
        private System.Windows.Forms.Button ErrorConfButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ErrorConfTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel SuccessfullySended;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel GroupsPanel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

