
using _StrategyPattern.API_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _﻿StrategyPattern
{
    class Program
    {
        //Strategy Pattern 이란 전체적으로 같은 알고리즘을 가진 여러 객체를 전략적으로 바꾸어서 사용할수있게하는 패턴이다.
        static void Main(string[] args)
        {
            API api = new API();

            api.setAPI(new SyncAPI());
            api.Get();
            api.setAPI(new UserAPI());
            api.Post();
            api.setAPI(new SyncAPI());
            api.Get();
        }
    }
}
