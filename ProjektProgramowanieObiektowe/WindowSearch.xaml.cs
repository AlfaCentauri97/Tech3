using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjektProgramowanieObiektowe
{
    /// <summary>
    /// Interaction logic for WindowSearch.xaml
    /// </summary>
    public partial class WindowSearch : Window
    {
        public WindowSearch()
        {
            InitializeComponent();
        }
        //Metoda wylaczenia aplikacji
        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_Menu_Search(object sender, RoutedEventArgs e)
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
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT * FROM PCGames WHERE Name='" + this.txtName.Text + "'";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("PCGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 1:
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT * FROM ConsolGames WHERE Name='" + this.txtName.Text + "'";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("ConsolGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT * FROM ArcadeGames WHERE Name='" + this.txtName.Text + "'";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("ArcadeGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT * FROM MobileGames WHERE Name='" + this.txtName.Text + "'";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("MobileGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT * FROM GBAGames WHERE Name='" + this.txtName.Text + "'";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("GBAGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        sqlCon.Open();
                        String query = "SELECT * FROM MyGames WHERE Name='" + this.txtName.Text + "'";
                        SqlCommand createCommand = new SqlCommand(query, sqlCon);
                        createCommand.ExecuteNonQuery();
                        SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("MyGames");
                        dataAdp.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
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
