using Avalonia.Controls;
using Avalonia.Interactivity;
using MySqlConnector;
using SuperBasketBall.Models;

namespace SuperBasketBall.Views;

public partial class RedWin : Window
{
    public static int sus;

    private MySqlConnectionStringBuilder _ConnectionSB = new MySqlConnectionStringBuilder();
    public RedWin()
    {
        InitializeComponent();
        /* _ConnectionSB = new MySqlConnectionStringBuilder
        {
            Server = "10.0.1.24",
            Database = "pro1_16",
            UserID = "User_01",
            Password = "user01ro",
        };*/
    }


    private void Save_OnClick(object? sender, RoutedEventArgs e)
    {
        /*
        string sql;
        sql = """
              update players where PlayerID = @player
              ( position, playername, weight, height, birthdate, begindate, team)
              VALUES
                  (@pos, @planam, @we, @he, @bida, @beda, @t)
              """;
        var posItem = Pos.SelectedItem as Position;
        var tItem = Team.SelectedItem as Team;
        using (var con = new MySqlConnection(_ConnectionSB.ConnectionString))
        {
            con.Open();
            using (var command = con.CreateCommand())
            {
                command.CommandText = sql;
                command.Parameters.AddWithValue("@pos", posItem.PositionID);
                command.Parameters.AddWithValue("@t", tItem.TeamID);
                command.Parameters.AddWithValue("@planam", newPlayerName.Text);
                command.Parameters.AddWithValue("@we", newWeight.Text);
                command.Parameters.AddWithValue("@he", newWeight.Text);
                command.Parameters.AddWithValue("@bida", BirthPicker.SelectedDate);
                command.Parameters.AddWithValue("@beda", BeginPicker.SelectedDate);
                command.Parameters.AddWithValue("@player", _player.PlayerID);
                command.ExecuteNonQuery();
            }
            con.Close();
        }
        */
        sus = 1;
        this.Close();
        var m = new MainWindow();
        m.Show();

    }

    private void Canc_OnClick(object? sender, RoutedEventArgs e)
    {
        sus = 0;
        this.Close();
        var m = new MainWindow();
        m.Show();
    }
}