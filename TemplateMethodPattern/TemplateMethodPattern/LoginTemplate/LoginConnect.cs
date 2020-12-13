using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.LoginTemplate
{
    public abstract class LoginConnect
    {
        protected abstract string PwdSecurity(string pwd); //패스워드 암호화
        protected abstract string Connect(string id ,string pwd); //로그인 시도
        protected abstract string Auth(string userInfo); //권한 확인

        public string rquestConnection(string id , string pwd)
        {
            string SecurityPwd = PwdSecurity(pwd);
            string userInfo = Connect(id, SecurityPwd);
            string userAuth = Auth(userInfo);
            string result = "";
            switch (userAuth)
            {
                case "일반":
                    result = "일반회원";
                    break;
                case "관리자":
                    result = "관리자";
                    break;
            }
            return result;
        }

    }
}
