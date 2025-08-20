using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class rngNumbers
    {
        private readonly Random _random = new Random();
        

        public int GetRngNum(int min = 1, int maxExclusive = 4)
        {           
            return _random.Next(min, maxExclusive);   
        }
       public string getRngChoice()
        {
            int roll = GetRngNum(1, 4);
            string result = "";

            if (roll == 1)
            {
                result = "rock";
 
            }
            else if (roll == 2)
            {
                result = "paper";
                
            }
            else if (roll == 3)
            {
                result = "scissors";
                
            }
            return result;
        }
    }
    
    
}
