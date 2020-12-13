using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _StrategyPattern.API_Pattern
{
    class SyncAPI : IAPI
    {
        public void Get()
        {
            Console.WriteLine("Sync API GET 호출");
        }

        public void Post()
        {
            Console.WriteLine("Sync API POST 호출");
        }
    }
}
