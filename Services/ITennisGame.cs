namespace TennisWebApp.Services;

public interface ITennisGame
{
  void WonPoint(string playerName);
  string GetScore();
}