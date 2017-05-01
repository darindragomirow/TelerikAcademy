using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Bonus_Score
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if(score>=1&&score<=3)
            {
                score *= 10;
                Console.WriteLine(score);
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                Console.WriteLine(score);
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                Console.WriteLine(score);
            }
            else  if (score > 9 || score < 0)
            {
                Console.WriteLine("invalid score");
            }
            else if(score==0)
            {
                Console.WriteLine(score);
            }
        }
    }
}
