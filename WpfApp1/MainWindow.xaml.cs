using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Drawing.Imaging;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string NewPath = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                    Rotate rotate = new Rotate(NewPath, OutPath, RotateFlipType.Rotate90FlipNone);
                    rotate.RotateImage(NewPath, OutPath, RotateFlipType.Rotate90FlipNone);

                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string NewPath = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;
                    ColorMatrix colorMatrix = new ColorMatrix();

                    BlackAndWhiteFilter bw = new BlackAndWhiteFilter(NewPath, OutPath, colorMatrix);
                    bw.Create(NewPath, OutPath, colorMatrix);

                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                string NewPath = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;
                    

                    ColorMatrix colorMatrix = new ColorMatrix();
                    LightFilter light = new LightFilter(NewPath, OutPath, colorMatrix);
                    light.Create(NewPath, OutPath, colorMatrix);

                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                string NewPath = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                    ColorMatrix colorMatrix = new ColorMatrix();
                    DarkFilter Dark = new DarkFilter(NewPath, OutPath, colorMatrix);
                    Dark.Create(NewPath, OutPath, colorMatrix);

                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
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
                string NewPath = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                    
                    ColorMatrix colorMatrix= new ColorMatrix();
                    BlueFilter bluefilter = new BlueFilter(NewPath, OutPath, colorMatrix);
                    bluefilter.Create(NewPath, OutPath, colorMatrix);


                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
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
                string NewPath = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                    ColorMatrix colorMatrix= new ColorMatrix();
                    GreenFilter Green = new GreenFilter(NewPath, OutPath, colorMatrix);
                    Green.Create(NewPath, OutPath, colorMatrix);


                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
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
                string NewPath = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                    ColorMatrix colorMatrix= new ColorMatrix();
                    PinkFilter Pink = new PinkFilter(NewPath, OutPath, colorMatrix);
                    Pink.Create(NewPath, OutPath, colorMatrix);

                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
            
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            FON.Visibility= Visibility.Visible;
            LABEL.Visibility= Visibility.Visible;
            SHIRINA.Visibility= Visibility.Visible;
            VISOTA.Visibility= Visibility.Visible;
            KNOPKA.Visibility= Visibility.Visible;
        }

        private void KNOPKA_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string NewPath = "";
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                    int x = Convert.ToInt32(SHIRINA.Text.ToString());
                    int y = Convert.ToInt32(VISOTA.Text.ToString());

                    Crop crop = new Crop(NewPath, OutPath, x, y);
                    crop.CropImage(NewPath, OutPath, x, y);

                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                    FON.Visibility= Visibility.Hidden;
                    LABEL.Visibility= Visibility.Hidden;
                    SHIRINA.Visibility= Visibility.Hidden;
                    VISOTA.Visibility= Visibility.Hidden;
                    KNOPKA.Visibility= Visibility.Hidden;
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
                string Input1 = "";
                string link = IMAGE.Source.ToString();
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        Input1 += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите второе изображение для коллажа") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();

                    string Input2 = "";
                    if (openFileDialog1.ShowDialog() == true) Input2 = openFileDialog1.FileName;
                    if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();

                        string OutPath = "";
                        if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                        Collages collage = new Collages(Input1, Input2, OutPath);
                        collage.Collage(Input1, Input2, OutPath);

                        IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                        if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                        {
                            MainWindow mainw = new MainWindow();
                            mainw.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка!");
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
                string NewPath = "";
                for (int i = 0; i < IMAGE.Source.ToString().Length; i++)
                {
                    if (i >= 8)
                    {
                        NewPath += IMAGE.Source.ToString()[i];
                    }
                }

                if (MessageBox.Show("Выберите файл для сохранения") == MessageBoxResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    string OutPath = "";
                    if (openFileDialog.ShowDialog() == true) OutPath = openFileDialog.FileName;

                    Inscription inscription = new Inscription(NewPath, OutPath, TEXT.Text.ToString(), POSITION.Text.ToString());
                    inscription.Add(NewPath, OutPath, TEXT.Text.ToString(), POSITION.Text.ToString());

                    IMAGE.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    FON.Visibility = Visibility.Hidden;
                    LABEL2.Visibility = Visibility.Hidden;
                    LABEL3.Visibility = Visibility.Hidden;
                    BUTTON.Visibility = Visibility.Hidden;
                    POSITION.Visibility = Visibility.Hidden;
                    TEXT.Visibility = Visibility.Hidden;
                    if (MessageBox.Show("Сохранено!") == MessageBoxResult.OK)
                    {
                        MainWindow mainw = new MainWindow();
                        mainw.Show();
                        this.Close();
                    }
                }
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
    }
}
