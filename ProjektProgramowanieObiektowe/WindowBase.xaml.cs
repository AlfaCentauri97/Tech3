using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
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
    /// Klasa WindowBase do sterowania metodami laczenia z baza danych oraz jej zarzadzaniem
    /// </summary>
    public partial class WindowBase : Window
    {
        public WindowBase()
        {
            InitializeComponent();
        }
        //Metoda wylaczenia aplikacji
        private void ButtonBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Metoda polaczenia z baza danych oraz wyswietleniem
        private void Button_Click_Open_Base(object sender, RoutedEventArgs e)
        {
            //Szukanie danych
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V5K2UVL\ADMIN; Initial Catalog=ProjektObiektowe; Integrated Security=True;");
            try
            {
                //Wpisanie polecenia w SQL do zarzadzania danymi (Wyswietlenie wszystkich danych "MyGames")
                sqlCon.Open();
                String query = "SELECT * FROM MyGames";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
                DataTable dt = new DataTable("MyGames");
                dataAdp.Fill(dt);
                //Wyswietlenie tablicy
                DataGrid1.ItemsSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Metoda aktualizacji tablicy
        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V5K2UVL\ADMIN; Initial Catalog=ProjektObiektowe; Integrated Security=True;");
            try
            {
                //Wpisanie polecenia w SQL do zarzadzania danymi (Zmiana danych nazwa,czas,ocena dla id w tablicy "MyGames")
                sqlCon.Open();
                String query = "UPDATE  MyGames set Name='" + this.txtName.Text + "',Score='" + this.txtScore.Text + "' WHERE ID='" + this.txtID.Text + "' ";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                //Powiadomienie o udanej aktualizacji
                MessageBox.Show("Updated.");
                sqlCon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //Wyświetlenie ponownie bazy w celu zaaktualizowania widoku tablicy
                sqlCon.Open();
                String query = "SELECT * FROM MyGames";
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
        }


        //Metoda dodawanie elementow do tablicy
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            //Wpisanie polecenia w SQL do zarzadzania danymi (Dodanie danych nazwa,czas,ocena,id w tablicy "MyGames")
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V5K2UVL\ADMIN; Initial Catalog=ProjektObiektowe; Integrated Security=True;");
            try
            {
                sqlCon.Open();
                String query = "INSERT INTO MyGames (ID,Name,Score) values('" + this.txtID.Text + "','" + this.txtName.Text + "','" + this.txtScore.Text +  "')";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                MessageBox.Show("Saved.");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //Wyświetlenie ponownie bazy w celu zaaktualizowania widoku tablicy
                sqlCon.Open();
                String query = "SELECT * FROM MyGames";
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
        }
        //Metoda usuwanie elementow z tablicy
        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-V5K2UVL\ADMIN; Initial Catalog=ProjektObiektowe; Integrated Security=True;");
            try
            {
                //Wpisanie polecenia w SQL do zarzadzania danymi (Usuniecie danych dla ID w tablicy "MyGames")
                sqlCon.Open();
                String query = "DELETE FROM MyGames WHERE ID='" + this.txtID.Text + "'";
                SqlCommand createCommand = new SqlCommand(query, sqlCon);
                createCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted.");
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //Wyświetlenie ponownie bazy w celu zaaktualizowania widoku tablicy
                sqlCon.Open();
                String query = "SELECT * FROM MyGames";
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
        }
    }
}
