using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektProgramowanieObiektowe
{
    /// <summary>
    /// Klasa WindowTop do sterowania metodami laczenia z baza danych oraz ich wyswietlaniem.
    /// </summary>
    public partial class WindowTop : Window
    {
        public WindowTop()
        {
            InitializeComponent();
        }
        //Metoda wylaczenia aplikacji
        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_Menu_Top(object sender, RoutedEventArgs e)
        {
            //Zmienna index przypisuje wartości Uid od 0 do 5 
            int index = int.Parse(((Button)e.Source).Uid);
            //Przemieszcza margines (czesc estetyczna) dodaje 260 do parametru umozliwiajac przesuwanie poziome 
            GridCursor.Margin = new Thickness(0 + (100 * index), 72, 0, 26);
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V5K2UVL\ADMIN; Initial Catalog=ProjektObiektowe; Integrated Security=True;");
            switch (index)
            {
                case 0:
                    //Wyswietlenie najwyzszych rekordow z tablicy "PCGames"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM PCGames ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("PCGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    try
                    {
                        //Wyswietlenie najwyzszych rekordow z tablicy "ConsolGames"
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM ConsolGames ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("ConsolGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        //Wyswietlenie najwyzszych rekordow z tablicy "ArcadeGames"
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM ArcadeGames ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("ArcadeGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        //Wyswietlenie najwyzszych rekordow z tablicy "MobileGames"
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM MobileGames ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("MobileGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        //Wyswietlenie najwyzszych rekordow z tablicy "GBAGames"
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM GBAGames ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("GBAGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        //Wyswietlenie najwyzszych rekordow z tablicy "MyGa,es"
                        sqlCon.Open();
                        String query = "SELECT TOP 10 * FROM MyGames ORDER BY Score DESC";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("MyGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                        dataAdp.Update(dt);
                        sqlCon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
        }
}
