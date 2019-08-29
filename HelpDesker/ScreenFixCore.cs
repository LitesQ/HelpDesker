using System;
using System.Windows.Media.Imaging;
using System.IO;
using System.Drawing.Imaging;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScreenFixCore
{
    static class ScreenshotMaker
    {
        static Window windowBackground; //Окно растягиваемое на экран
        static Point firstPoint; //Первая точка на экране, с которой начинается выделение прямоугольника (Левая верхняя)
        static Point secondPoint;//Вторая точка на экране, с которой продолжается выделение прямоугольника (Правая нижняя)
        static Rectangle rect;
        static Int32Rect rectForDraw;
        static Canvas canvas;

        public static Brush rectBrush { get; set; }// Кисть определяющая цвет выделяемого прямоугольника

        static Double rectThickness { get; set; }// Толщина линий прямоугольника

        static System.Windows.Controls.Image image;
        static BitmapSource bitmapSource; //Здесь должно содержаться изображение скриншота выделенного участка экрана
        static DrawingVisual drawingVisual;// Визуальный объект используемый для отрисовки
        static DrawingContext drawingContext;// Описывает визуальное содержимое с использованием команд рисования, проталкивания и выталкивания.
        static RenderTargetBitmap renderTargetBitmap;// То что преобразовывает объект в изображение
        static ImageSource imgSourceShaded;// Затенённое определённым цветом изображение
        static BitmapImage bmpImageOriginal;// Оригинальное изображение
        static SolidColorBrush solidColorBrush;// Кисть для затенения изображения 

        #region Методы делающие скриншоты всего экрана и прямоугольной области указанного размера с указанной позиции

        /// <summary>
        /// Сделать снимок экрана
        /// </summary>
        /// <param name="format">Формат в котором вернуть изображение</param>
        /// <returns></returns>
        public static BitmapImage CaptureScreen(ImageFormat format)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(new System.Drawing.Point(0, 0),
               new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width,
                   System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height));

            return CaptureRect(rect, System.Drawing.Imaging.ImageFormat.Png);
        }

        /// <summary>
        /// Сделать снимок определённой области изображения
        /// </summary>
        /// <param name="rect">Прямоугольник в котором будет сделан снимок</param>
        /// <param name="format">Формат изображения</param>
        /// <returns></returns>
        public static BitmapImage CaptureRect(System.Drawing.Rectangle rect, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(rect.Width, rect.Height,
                    System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(rect.X, rect.Y, 0, 0, rect.Size, System.Drawing.CopyPixelOperation.SourceCopy);
                bitmap.Save(ms, format);
                BitmapImage img = new BitmapImage();
                img.BeginInit();
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.StreamSource = ms;
                img.EndInit();
                return img;
            }
        }

        #endregion

        private static void InitializeComponents()// Проинициализировать поля
        {
            windowBackground = new Window();
            windowBackground.WindowStyle = WindowStyle.None;
            windowBackground.WindowState = WindowState.Maximized;
            windowBackground.ResizeMode = System.Windows.ResizeMode.NoResize; //обязательно должно быть, решает одну проблему

            rectForDraw = new Int32Rect();
            drawingVisual = new DrawingVisual();
            imgSourceShaded = new BitmapImage();
            rect = new Rectangle();
        }

        private static void DisposeComponents()// Освободить поля
        {
            windowBackground = null;
            drawingVisual = null;
            drawingContext = null;
            renderTargetBitmap = null;
            imgSourceShaded = null;
            bmpImageOriginal = null;
            rect = null;
            image = null;
            canvas = null;
            solidColorBrush = null;
        }
        /// <summary>
        /// Запустить метод ручного выделения прямоугольной области пользователем, 
        /// для снятия скриншот с выбранного участка экрана
        /// </summary>
        /// <param name="br">Кисть определяющая цвет прямоугольника</param>
        /// <param name="rectThickness">Толщина линий прямоугольника</param>
        /// <param name="backBrush">Кисть определяющая цвет заливки фона скриншота</param>
        /// <returns></returns>
        public static BitmapSource BeginSelectionImageFromScreen(Brush br, Double RectThickness, Color backColor)
        {
            InitializeComponents();
            solidColorBrush = new SolidColorBrush(Color.FromArgb(120, backColor.R, backColor.G, backColor.B));

            rectBrush = br;
            rectThickness = RectThickness;

            bmpImageOriginal = CaptureScreen(ImageFormat.Png);

            imgSourceShaded = bmpImageOriginal;
            Rect imgRect = new Rect(new Point(0, 0), new Point(bmpImageOriginal.Width, bmpImageOriginal.Height));
            drawingContext = drawingVisual.RenderOpen();
            drawingContext.DrawImage(imgSourceShaded, imgRect);
            drawingContext.DrawRectangle(solidColorBrush, null, imgRect);
            drawingContext.Close();


            renderTargetBitmap = new RenderTargetBitmap((int)bmpImageOriginal.Width, (int)bmpImageOriginal.Height, 96, 96,
                System.Windows.Media.PixelFormats.Pbgra32);
            renderTargetBitmap.Render(drawingVisual);

            imgSourceShaded = renderTargetBitmap;

            image = new System.Windows.Controls.Image();
            image.Source = bmpImageOriginal;

            ImageBrush imgBrush = new ImageBrush();
            imgBrush.AlignmentX = AlignmentX.Left;
            imgBrush.AlignmentY = AlignmentY.Top;
            imgBrush.Stretch = Stretch.None;
            imgBrush.TileMode = TileMode.None;
            imgBrush.ImageSource = renderTargetBitmap;
            windowBackground.Background = imgBrush;

            canvas = new Canvas();
            canvas.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            canvas.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            canvas.Margin = new Thickness(0, 0, 0, 0);
            windowBackground.Content = canvas;
            windowBackground.Cursor = System.Windows.Input.Cursors.Cross;

            windowBackground.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(windowBackground_MouseLeftButtonDown);
            windowBackground.MouseMove += new System.Windows.Input.MouseEventHandler(windowBackground_MouseMove);
            windowBackground.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(windowBackground_MouseLeftButtonUp);

            rect.Stroke = br;
            rect.StrokeThickness = RectThickness;
            rect.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            rect.VerticalAlignment = System.Windows.VerticalAlignment.Top;

            Canvas.SetTop(rect, firstPoint.Y);
            Canvas.SetLeft(rect, firstPoint.X);
            canvas.Children.Add(rect);

            windowBackground.ShowDialog();
            DisposeComponents();
            return bitmapSource;
        }

        /// <summary>
        /// Нажатие левой кнопки мыши на окне содержащем скриншот всего экрана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void windowBackground_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            firstPoint = e.GetPosition(windowBackground);
            MoveDrawRectangle(firstPoint, firstPoint);
        }

        /// <summary>
        /// Отпускание левой кнопки мыши на окне содержащем скриншот всего экрана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void windowBackground_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Int32Rect rectangle = new Int32Rect();

            if (firstPoint.X > secondPoint.X)
            {
                rectangle.X = (int)(secondPoint.X + rect.StrokeThickness);
                rectangle.Width = (int)(firstPoint.X - secondPoint.X - rect.StrokeThickness * 2);
                if (rectangle.Width < 1)
                {
                    rectangle.Width = 1;
                }
            }
            else
            {
                rectangle.X = (int)(firstPoint.X + rect.StrokeThickness);
                rectangle.Width = (int)(secondPoint.X - firstPoint.X - rect.StrokeThickness * 2);
                if (rectangle.Width < 1)
                {
                    rectangle.Width = 1;
                }
            }

            if (firstPoint.Y > secondPoint.Y)
            {
                rectangle.Y = (int)(secondPoint.Y + rect.StrokeThickness);
                rectangle.Height = (int)(firstPoint.Y - secondPoint.Y - rect.StrokeThickness * 2);
                if (rectangle.Height < 1)
                {
                    rectangle.Height = 1;
                }
            }
            else
            {
                rectangle.Y = (int)(firstPoint.Y + rect.StrokeThickness);
                rectangle.Height = (int)(secondPoint.Y - firstPoint.Y - rect.StrokeThickness * 2);
                if (rectangle.Height < 1)
                {
                    rectangle.Height = 1;
                }
            }

            CroppedBitmap cb = new CroppedBitmap((BitmapSource)image.Source, rectangle);
            bitmapSource = cb;

            windowBackground.Close();
        }

        /// <summary>
        /// Движение курсора мыши по окну содержащему скриншот всего экрана
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void windowBackground_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {
                secondPoint = e.GetPosition(windowBackground);
                if (secondPoint.X > SystemParameters.PrimaryScreenWidth)
                {
                    secondPoint.X = SystemParameters.PrimaryScreenWidth;
                }
                MoveDrawRectangle(firstPoint, secondPoint);
            }
        }

        /// <summary>
        /// Рисует полностью всю картинку, осветвлённую область внутри прямоугольника и затенённую снаружи
        /// </summary>
        /// <param name="rectForDraw">Прямоугольная область для осветлённой картинки</param>
        private static void DrawLightRegtangle(Int32Rect rectForDraw)
        {
            if (rectForDraw.Width > 0 && rectForDraw.Height > 0)
            {
                Rect imgRect = new Rect(new Point(0, 0), new Point(bmpImageOriginal.Width, bmpImageOriginal.Height));
                drawingContext = drawingVisual.RenderOpen();
                drawingContext.DrawImage(imgSourceShaded, imgRect);

                CroppedBitmap cb = new CroppedBitmap((BitmapSource)image.Source, rectForDraw);
                Rect rectForLosso = new Rect((double)rectForDraw.X, (double)rectForDraw.Y,
                    (double)rectForDraw.Width, (double)rectForDraw.Height);
                drawingContext.DrawRectangle(solidColorBrush, null, rectForLosso);
                drawingContext.DrawImage(cb, rectForLosso);
                drawingContext.Close();

                renderTargetBitmap = new RenderTargetBitmap((int)bmpImageOriginal.Width, (int)bmpImageOriginal.Height, 96, 96,
                    System.Windows.Media.PixelFormats.Pbgra32);
                renderTargetBitmap.Render(drawingVisual);
                ImageBrush imgBrush = new ImageBrush();
                imgBrush.AlignmentX = AlignmentX.Left;
                imgBrush.AlignmentY = AlignmentY.Top;
                imgBrush.Stretch = Stretch.None;
                imgBrush.TileMode = TileMode.None;
                imgBrush.ImageSource = renderTargetBitmap;
                windowBackground.Background = imgBrush;
            }
        }

        /// <summary>
        /// Растянуть/Переместить прямоугольник на указанные координаты
        /// </summary>
        /// <param name="pointLeftTop">Левый верхний угол</param>
        /// <param name="pointRightBottom">Правый нижний угол</param>
        private static void MoveDrawRectangle(Point pointLeftTop, Point pointRightBottom)
        {
            if (pointLeftTop.X > pointRightBottom.X)
            {
                Canvas.SetLeft(rect, pointRightBottom.X);
                rect.Width = pointLeftTop.X - pointRightBottom.X;
                rectForDraw.X = (int)pointRightBottom.X;
            }
            else
            {
                Canvas.SetLeft(rect, pointLeftTop.X);
                rect.Width = pointRightBottom.X - pointLeftTop.X;
                rectForDraw.X = (int)pointLeftTop.X;
            }

            if (pointLeftTop.Y > pointRightBottom.Y)
            {
                Canvas.SetTop(rect, pointRightBottom.Y);
                rect.Height = pointLeftTop.Y - pointRightBottom.Y;
                rectForDraw.Y = (int)pointRightBottom.Y;
            }
            else
            {
                Canvas.SetTop(rect, pointLeftTop.Y);
                rect.Height = pointRightBottom.Y - pointLeftTop.Y;
                rectForDraw.Y = (int)pointLeftTop.Y;
            }
            rectForDraw.Width = (int)rect.Width;
            rectForDraw.Height = (int)rect.Height;
            DrawLightRegtangle(rectForDraw);
        }
    }
}
