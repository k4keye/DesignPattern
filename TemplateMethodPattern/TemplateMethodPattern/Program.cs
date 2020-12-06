using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.LoginTemplate;

namespace TemplateMethodPattern
{
    class Program
    {
        /*
         * ﻿
            어떤 작업을 처리하는 일련의 프로세스를 정의해두고
            서브클래스가 프로세스에 필요한 역활을 구현하여
            요청하는 입장에서는 프로세스를 호출만을 하게하여
            프로세스의 변동이 생겨도 요청하는 입장에서는 변동이 없게하는 패턴이다.

            동일한 기능은 상위 클래스에서 정의하며 확장 혹은 변화가발생하는 부분만 서브 클래스에 구현한다.
﻿
         */
        static void Main(string[] args)
        {
            LoginConnect loginConnect = new NormalLogin();
            Console.WriteLine(loginConnect.rquestConnection("id", "pwd"));
        }
    }
}
