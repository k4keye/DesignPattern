using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //새로운 인스턴스를 생성하지않고
            //인스턴스를 반환받는다.
            Api api = Api.GetInstance();
        }
    }
}
