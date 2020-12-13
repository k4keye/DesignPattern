using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _StrategyPattern.API_Pattern
{
    class CheckAPI : IAPI
    {
        public void Get()
        {
            Console.WriteLine("Check API GET 호출");
        }

        public void Post()
        {
            Console.WriteLine("Check API POST 호출");
        }
    }
}
