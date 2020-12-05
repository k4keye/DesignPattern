using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _StrategyPattern.API_Pattern
{
    public class API
    {
        private IAPI iAPI;
        public void setAPI(IAPI iAPI)
        {
            this.iAPI = iAPI;
        }
        public void Get()
        {
            iAPI.Get();
        }
        public void Post()
        {
            iAPI.Post();
        }
    }
}
