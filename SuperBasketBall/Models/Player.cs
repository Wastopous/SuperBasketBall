using System;
namespace SuperBasketBall.Models;

public class Player
{
    public int PlayerID { get; set; }
    public string PlayernName { get; set; }
    public string PositionName { get; set; }
    public int Position { get; set; }
    public int Team { get; set; }
    public string TeamName { get; set; }
    public decimal Weight { get; set; }
    public decimal Height { get; set; }
    public DateOnly BirthDate  { get; set; }
    public DateOnly BeginDate  { get; set; }
}