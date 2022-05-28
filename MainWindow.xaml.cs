using System;
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
using FilmGise.Class;



namespace FilmGise
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }
        List<Koltuk> Koltuklar = new List<Koltuk>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 21; i++)
            {
                Koltuk Ch = new Koltuk();
                Ch.fiyat = 30;
                Ch.KoltukNum = i;
                Ch.Durum = "Boş";
                Koltuklar.Add(Ch);
            }
            Dg.ItemsSource = Koltuklar;
            Dg.SelectedCells.Clear();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object item = Dg.SelectedItem;
            if (item != null)
            {
                var KoltukData = (Dg.SelectedItem as Koltuk);
                KoltukData.Durum = "Dolu";
                var OgrFiyat = KoltukData.fiyat / 3*2;
                MessageBox.Show($"Öğrenci Bileti Satıldı {OgrFiyat} TL");
                var index = KoltukData.KoltukNum;
                Koltuk yeni = new Koltuk();
                yeni.KoltukNum = KoltukData.KoltukNum;
                yeni.Durum = "Dolu";
                yeni.fiyat = 30;
                
                
                
                Dg.ItemsSource = Koltuklar;





            }
        }



            private void Dg_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            object item = Dg.SelectedItem;
            if (item != null)
            {
                var KoltukData = (Dg.SelectedItem as Koltuk);
                Ogr.Content = $"{KoltukData.KoltukNum.ToString()}  NUMARALI KOLTUĞU ÖĞRENCİ FİYATIYLA AL";
                Nrml.Content = $"{KoltukData.KoltukNum.ToString()}  NUMARALI KOLTUĞU NORMAL FİYATLA AL";
                Iptal.Content = $"{KoltukData.KoltukNum.ToString()}  NUMARALI KOLTUĞU İPTAL ET";




            }
        }

        private void Nrml_Click(object sender, RoutedEventArgs e)
        {
            object item = Dg.SelectedItem;
            if (item != null)
            {
                var KoltukData = (Dg.SelectedItem as Koltuk);
                KoltukData.Durum = "Dolu";
                var OgrFiyat = KoltukData.fiyat;
                MessageBox.Show($"Bilet Başarıyla Satıldı {OgrFiyat} TL");
                var index = KoltukData.KoltukNum;
                Koltuk yeni = new Koltuk();
                yeni.KoltukNum = KoltukData.KoltukNum;
                yeni.Durum = "Dolu";
                yeni.fiyat = 30;



                Dg.ItemsSource = Koltuklar;





            }
        }

        private void Iptal_Click(object sender, RoutedEventArgs e)
        {
            object item = Dg.SelectedItem;
            if (item != null)
            {
                var KoltukData = (Dg.SelectedItem as Koltuk);
                KoltukData.Durum = "Boş";
                var OgrFiyat = KoltukData.fiyat;
                MessageBox.Show($"Bilet Başarıyla İptal Edildi");
                var index = KoltukData.KoltukNum;
                Koltuk yeni = new Koltuk();
                yeni.KoltukNum = KoltukData.KoltukNum;
                yeni.Durum = "Boş";
                



                Dg.ItemsSource = Koltuklar;





            }
        }
    }
}
