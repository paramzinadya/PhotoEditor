using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing.Imaging;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Interop;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;
using Point = System.Windows.Point;
using Size = System.Windows.Size;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        Bitmap newBitMap;

        public MainWindow()
        {
            InitializeComponent();
            this.newBitMap = null;
        }


        public static BitmapImage ToBitmapImage(Bitmap bitmap)
        {
            using (var memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                return bitmapImage;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                newBitMap = new Bitmap(openFileDialog.FileName);

                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);

                IMAGE.Source = newBitmapImage;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Rotate rotate = new Rotate(newBitMap, RotateFlipType.Rotate90FlipNone);
                rotate.RotateImage(newBitMap, RotateFlipType.Rotate90FlipNone);
                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                BlackAndWhiteFilter bw = new BlackAndWhiteFilter(newBitMap, colorMatrix);
                bw.Create(newBitMap, colorMatrix);
                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                LightFilter light = new LightFilter(newBitMap, colorMatrix);
                light.Create(newBitMap, colorMatrix);
                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                DarkFilter Dark = new DarkFilter(newBitMap, colorMatrix);
                Dark.Create(newBitMap, colorMatrix);
                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                BlueFilter bluefilter = new BlueFilter(newBitMap, colorMatrix);
                bluefilter.Create(newBitMap, colorMatrix);
                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                GreenFilter Green = new GreenFilter(newBitMap, colorMatrix);
                Green.Create(newBitMap, colorMatrix);
                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
                ColorMatrix colorMatrix = new ColorMatrix();
                PinkFilter Pink = new PinkFilter(newBitMap, colorMatrix);
                Pink.Create(newBitMap, colorMatrix);
                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FON.Visibility = Visibility.Visible;
            LABEL.Visibility = Visibility.Visible;
            SHIRINA.Visibility = Visibility.Visible;
            VISOTA.Visibility = Visibility.Visible;
            KNOPKA.Visibility = Visibility.Visible;
        }

        private void KNOPKA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (newBitMap == null) throw new ArgumentException("Изображение не загружено");
                else
                {
                    int x = Convert.ToInt32(SHIRINA.Text.ToString());
                    int y = Convert.ToInt32(VISOTA.Text.ToString());
                    Crop crop = new Crop(newBitMap, x, y);

                    if (x > newBitMap.Width || y > newBitMap.Height || x < 100 || y < 100)
                    {
                        throw new ArgumentException("Неверный формат ввода");
                    }
                    else
                    {
                        Rectangle cropArea = new Rectangle(0, 0, x, y);
                        Bitmap croppedImage = new Bitmap(newBitMap);
                        newBitMap = new Bitmap(cropArea.Width, cropArea.Height);
                        using (Graphics graphics = Graphics.FromImage(newBitMap))
                        {
                            graphics.DrawImage(croppedImage, new Rectangle(0, 0, cropArea.Width, cropArea.Height), cropArea, GraphicsUnit.Pixel);
                        }
                    }


                    BitmapImage newBitmapImage = ToBitmapImage(newBitMap);

                    IMAGE.Source = newBitmapImage;

                    FON.Visibility = Visibility.Hidden;
                    LABEL.Visibility = Visibility.Hidden;
                    SHIRINA.Visibility = Visibility.Hidden;
                    VISOTA.Visibility = Visibility.Hidden;
                    KNOPKA.Visibility = Visibility.Hidden;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Выберите второе изображение для коллажа") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();

                    string Input2 = "";
                    if (openFileDialog1.ShowDialog() == true) Input2 = openFileDialog1.FileName;
                    Bitmap bitmap2 = new Bitmap(Input2);

                    Collages collage = new Collages(newBitMap, Input2);
                    collage.Collage(newBitMap, Input2);

                    using (Bitmap image2 = new Bitmap(Input2))
                    {
                        Bitmap cImage = new Bitmap(newBitMap);
                        int NewWidth = Math.Max(newBitMap.Width, image2.Width);
                        int NewHeight = Math.Max(newBitMap.Height, image2.Height);
                        newBitMap = new Bitmap(NewWidth * 2, NewHeight);
                        using (Graphics g = Graphics.FromImage(newBitMap))
                        {
                            g.DrawImage(cImage, new Rectangle(0, 0, cImage.Width, cImage.Height));
                            g.DrawImage(image2, new Rectangle(cImage.Width, 0, NewWidth, NewHeight));
                        }
                    }

                    BitmapImage newBitmapImage = ToBitmapImage(newBitMap);

                    IMAGE.Source = newBitmapImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            FON.Visibility = Visibility.Visible;
            LABEL2.Visibility = Visibility.Visible;
            LABEL3.Visibility = Visibility.Visible;
            BUTTON.Visibility = Visibility.Visible;
            POSITION.Visibility = Visibility.Visible;
            TEXT.Visibility = Visibility.Visible;
        }

        private void BUTTON_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                Inscription inscription = new Inscription(newBitMap, TEXT.Text.ToString(), POSITION.Text.ToString());
                inscription.Add(newBitMap, TEXT.Text.ToString(), POSITION.Text.ToString());

                BitmapImage newBitmapImage = ToBitmapImage(newBitMap);
                IMAGE.Source = newBitmapImage;

                FON.Visibility = Visibility.Hidden;
                LABEL2.Visibility = Visibility.Hidden;
                LABEL3.Visibility = Visibility.Hidden;
                BUTTON.Visibility = Visibility.Hidden;
                POSITION.Visibility = Visibility.Hidden;
                TEXT.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "JPG Files (*.jpg)|*.jpg"
            };
            if (save.ShowDialog() == true)
            {
                JpegBitmapEncoder jpegBitmapEncoder = new JpegBitmapEncoder();
                jpegBitmapEncoder.Frames.Add(BitmapFrame.Create(IMAGE.Source as BitmapSource));
                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                    jpegBitmapEncoder.Save(fileStream);
                MessageBox.Show("Изображение успешно сохранено.");
            }
          
           
            }
        }
    }

