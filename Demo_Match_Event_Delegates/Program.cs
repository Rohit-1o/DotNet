namespace Demo_Match_Event_Delegates
{

    public delegate void MatchHandler(int score);
    internal class Program
    {
        static void Main(string[] args)
        {
            Match matchobj = new Match();

            Match._win += new MatchHandler (Match.win_match);
            Match._lose += new MatchHandler(Match.lose_match);
            Match._draw += new MatchHandler(Match.draw_match);

            Console.Write("Enter Team 1 Score : ");
            int team1Score = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Team 2 Score : ");
            int team2Score = Convert.ToInt32(Console.ReadLine());

            matchobj.CheckResult(team1Score, team2Score);

        }
    }

    public class Match
    {

        public event MatchHandler win_match;
        public event MatchHandler lose_match;
        public event MatchHandler draw_match;

        public void CheckResult(int team1Score, int team2Score)
        {
            if (team1Score > team2Score)
            {
                win_match.Invoke();
            }
            else if (team2Score > team1Score)
            {
                lose_match.Invoke();
            }
            else
            {
                draw_match.Invoke();
            }
        }

        public void win_match(int score)
        {
            Console.WriteLine($"Congratulations..! You won the Match {score} ");
        }

        public void lose_match(int score)
        {
            Console.WriteLine($"Sorry..!! You lose {score} ");
        }

        public void draw_match(int score)
        {
            Console.WriteLine($"Sorry..!! You lose {score} ");
        }
    }
}
