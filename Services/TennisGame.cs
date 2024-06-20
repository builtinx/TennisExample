namespace TennisWebApp.Services;

 public class TennisGame : ITennisGame
 {
    private int p1Point;
    private int p2Point;

    public string GetScore()
    {
        string[] scores = ["Love", "Fifteen", "Thirty", "Forty"];
        string score;
        if (this.p1Point == this.p2Point)
        {
            score = (this.p1Point < 3) ? scores[this.p1Point] + "-All" : "Deuce";
        }
        else if (this.p1Point >= 4 || this.p2Point >= 4)
        {
            int diffPoint = this.p1Point - this.p2Point;
            score = diffPoint switch
            {
                1 => "Advantage player1",
                -1 => "Advantage player2",
                >= 2 => "Win for player1",
                _ => "Win for player2"
            };
        }
        else
        {
            score = scores[this.p1Point] + "-" + scores[this.p2Point];
        }
        return score;
    }

    private void P1Score()
    {
        this.p1Point++;
    }

    private void P2Score()
    {
        this.p2Point++;
    }

    public void WonPoint(string player)
    {
        if (player == "player1")
            P1Score();
        else
            P2Score();
    }
}