using System;


namespace Bonus_Score
{
    class Bonus
    {
        static void Main()
        {
            int Score;
            int BonusScore;

           Score=int.Parse( Console.ReadLine());
            if (Score >= 1 && Score <= 3) {
                BonusScore = Score * 10;
                Console.WriteLine(BonusScore);
            }
            if (Score >= 4 && Score <= 6)
            {
                BonusScore = Score * 100;
                Console.WriteLine(BonusScore);
            }
            if (Score >= 7 && Score <= 9)
            {
                BonusScore = Score * 1000;
                Console.WriteLine(BonusScore);
            }
            if (Score <=0 || Score >= 10)
            {
                Console.WriteLine("invalid score");
            }
            
        }
    }
}
