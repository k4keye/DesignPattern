using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Api
    {
        static private Api instance;

        private Api() //생성자를 사용하지못하게 Private로 막아둔다.
        {

        }
        public static Api GetInstance()
        {
            if(instance ==null)
            {
                instance = new Api();
            }
            return instance;
        }
        void Get()
        {

        }
        void Post()
        {

        }
    }
}
