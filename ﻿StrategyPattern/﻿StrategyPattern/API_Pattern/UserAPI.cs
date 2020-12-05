using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _StrategyPattern.API_Pattern
{
    class UserAPI : IAPI
    {
        public void Get()
        {
            Console.WriteLine("User API GET 호출");
        }

        public void Post()
        {
            Console.WriteLine("User API POST 호출");
        }
    }
}
