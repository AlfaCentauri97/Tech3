using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektProgramowanieObiektowe
{
    /// <summary>
    /// Klasa WindowHome do wyswietlania tablicy
    /// </summary>
    public partial class WindowHome : Window
    {
        public WindowHome()
        {
            InitializeComponent();
        }
        //Metoda wylaczenia aplikacji
        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_Home_Menu(object sender, RoutedEventArgs e)
        {
            //Zmienna index przypisuje wartości Uid od 0 do 4 
            int index = int.Parse(((Button)e.Source).Uid);
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V5K2UVL\ADMIN; Initial Catalog=ProjektObiektowe; Integrated Security=True;");
            switch (index)
            {
                case 0:
                    try
                    {
                        //Wyswietlenie tablicy "PCGames"
                        sqlCon.Open();
                        String query = "SELECT * FROM PCGames";
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
                        //Wyswietlenie tablicy "ConsolGames"
                        sqlCon.Open();
                        String query = "SELECT * FROM ConsolGames";
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
                        //Wyswietlenie tablicy "ArcadeGames"
                        sqlCon.Open();
                        String query = "SELECT * FROM ArcadeGames";
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
                        //Wyswietlenie tablicy "GBAGames"
                        sqlCon.Open();
                        String query = "SELECT * FROM GBAGames";
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
                case 4:
                    try
                    {
                        //Wyswietlenie tablicy "MobileGames"
                        sqlCon.Open();
                        String query = "SELECT * FROM MobileGames";
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
            }
        }
    }
}
