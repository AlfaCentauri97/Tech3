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
    /// Interaction logic for WindowRandom.xaml
    /// </summary>
    public partial class WindowRandom : Window
    {
        public WindowRandom()
        {
            InitializeComponent();
        }
        //Metoda wylaczenia aplikacji
        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_Random_Menu(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);
            //Przemieszcza margines (czesc estetyczna) dodaje 260 do parametru umozliwiajac przesuwanie poziome 
            GridCursor.Margin = new Thickness(0 + (100 * index), 72, 0, 26);
            //Polaczenie z baza danych
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V5K2UVL\ADMIN; Initial Catalog=ProjektObiektowe; Integrated Security=True;");
            switch (index)
            {

                case 0:
                    //Wyswietlenie losowego wiersza z tablicy "PCGames"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM PCGames ORDER BY NEWID()";
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
                    //Wyswietlenie losowego wiersza z tablicy "ConsolGames"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM ConsolGames ORDER BY NEWID()";
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
                    //Wyswietlenie losowego wiersza z tablicy "ArcadeGames"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM ArcadeGames ORDER BY NEWID()";
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
                    //Wyswietlenie losowego wiersza z tablicy "MobileGames"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM MobileGames ORDER BY NEWID()";
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
                    //Wyswietlenie losowego wiersza z tablicy "GBAGames"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM GBAGames ORDER BY NEWID()";
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
                    //Wyswietlenie losowego wiersza z tablicy "MyGames"
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT TOP 1 * FROM MyGames ORDER BY NEWID()";
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
