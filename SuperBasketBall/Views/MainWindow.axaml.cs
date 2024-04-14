using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MySqlConnector;
using SuperBasketBall.Models;

namespace SuperBasketBall.Views;

public partial class MainWindow : Window
{
    private MySqlConnectionStringBuilder _ConnectionSB = new MySqlConnectionStringBuilder();
    private List<Player> _players;
    private List<Position> _positions;
    public MainWindow()
    {
        InitializeComponent();
        if (EnterWin.role == 1)
        {
            RedButton.IsEnabled = false;
        }
       /* _ConnectionSB = new MySqlConnectionStringBuilder
        {
            Server = "10.0.1.24", 
            Database = "pro1_16",
            UserID = "User_01", 
            Password = "user01ro",
        };*/
        FillTable();
        FillimgComboBox();
        if (RedWin.sus == 1)
        {
            Sucsess();
        }
    }

    private void FillimgComboBox()
    {
    /*
            _positions = new List<Position>();
             string sql;
             sql = """
                     select * from positions
                   """;
             using (var con = new MySqlConnection(_ConnectionSB.ConnectionString))
             {
                 con.Open();
                 using (var command = con.CreateCommand())
                 {
                     command.CommandText = sql;
                     using (var reader = command.ExecuteReader())
                     {
                         while (reader.Read())
                         {
                             _positions.Add(new Position()
                                 {
                                     PositionID = reader.GetInt32("PositionID"),
                                     PositionName = reader.GetString("PositionName"),
                                 }
                             );
                         }
                         con.Close();
                     }
                 }
                 FillComboBox.ItemsSource = _positions;
             }
             */
    }
    private void FillTable()
    {
     /*   _players = new List<Player>();
        string sql;
        sql = """
              select  PositionID, PositionName, PlayerName, Weight, Height, BirthDate, BeginDate, TeamID, TeamName from player
              join pro1_16.position p on p.PositionID = player.Position
              join pro1_16.team t on t.TeamID = player.Team 
              """;
        using (var con = new MySqlConnection(_ConnectionSB.ConnectionString))
        {
            con.Open();
            using (var command = con.CreateCommand())
            {
                command.CommandText = sql;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        _players.Add(new Player()
                            {
                                PlayernName = reader.GetString("PlayerName"),
                                Weight = reader.GetDecimal("Weight"),
                                Height = reader.GetDecimal("Height"),
                                BirthDate = reader.GetDateOnly("BirthDate"),
                                BeginDate = reader.GetDateOnly("BeginDate"),
                                Position = reader.GetInt32("PositionID"),
                                PositionName  = reader.GetString("PlayerName"),
                                Team = reader.GetInt32("TeamID"),
                                TeamName  = reader.GetString("TeamName")
                            }
                        );
                    }
                    con.Close();
                }
            }
            DataGrid.ItemsSource = _players;
        }
        */
    }
    public async void Sucsess()
    {
        Label.IsVisible = true;
        await Task.Delay(TimeSpan.FromSeconds(1));
        Label.IsVisible = false;
    }

    private void DelButton_OnClick(object? sender, RoutedEventArgs e)
    {
        /*
          string sql;
                  sql = """ delete from players where PlayerID = @player """;
                  var player = DataGrid.SelectedItem as Player;
                  using (var con = new MySqlConnection(_ConnectionSB.ConnectionString))
                  {
                      con.Open();
                      using (var command = con.CreateCommand())
                      {
                          command.CommandText = sql;
                          command.Parameters.AddWithValue("player", player.PlayerID);
                          command.ExecuteNonQuery();
                      }
                      con.Close();
                  }
                  _players.Remove(player);
                  DataGrid.ItemsSource = _players;
         */
        
        Sucsess();
    }

    private void RedButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var red = new RedWin();
        red.Show();
    }

    private void SerTextBox_OnTextChanging(object? sender, TextChangingEventArgs e)
    {
        var searchTextInfo = _players.Where(x =>
            x.PlayernName.Contains(SerTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList();
        DataGrid.ItemsSource = searchTextInfo;
    }
}