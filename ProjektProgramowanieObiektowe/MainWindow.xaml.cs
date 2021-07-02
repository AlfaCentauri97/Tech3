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

namespace ProjektProgramowanieObiektowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void Button_ClickMenu(object sender, RoutedEventArgs e)
        {
            //Zmienna index przypisuje wartości Uid od 0 do 4 
            int index = int.Parse(((Button)e.Source).Uid);
            //Tworzy nowe okno
            switch (index)
            {
                case 0:
                    WindowHome window0 = new WindowHome();
                    window0.Show();
                    break;
                case 1:
                    WindowBase window1 = new WindowBase();
                    window1.Show();
                    break;
                case 2:
                    WindowTop window2 = new WindowTop();
                    window2.Show();
                    break;
                case 3:
                    WindowRandom window3 = new WindowRandom();
                    window3.Show();
                    break;
                case 4:
                    WindowSearch window4 = new WindowSearch();
                    window4.Show();
                    break;
            }
        }
    }
}
