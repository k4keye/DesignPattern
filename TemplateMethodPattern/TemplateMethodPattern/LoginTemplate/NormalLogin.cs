using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.LoginTemplate
{
    class NormalLogin : LoginConnect
    {
        protected override string PwdSecurity(string pwd)
        {
            Console.WriteLine("패스워드 암호화 작업");
            return pwd;
        }
        protected override string Connect(string id, string pwd)
        {
            Console.WriteLine("로그인 시도후 로그인 정보 반환");
            return "userinfoAdmin";
        }
        protected override string Auth(string userInfo)
        {
            Console.WriteLine("로그인 정보를 통해 권한 반환");
            return "관리자";
        }

    }
}
