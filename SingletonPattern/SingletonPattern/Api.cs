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

        private Api()
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
