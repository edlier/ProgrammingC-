using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text.RegularExpressions;
namespace misSystem
{
    public class validateSession
    {
        public void validateMIS_AU(Page pg, string NoneMIS_AU, string NoneLogin)
        {
            if (Convert.ToInt32(pg.Session[SessionString.auDep11]) == 1)
            {
            }
            else
            {
                if (pg.Session[SessionString.userID] != null)
                {
                    pg.Response.Redirect(pg.ResolveClientUrl(NoneMIS_AU));

                }
                else
                {
                    pg.Response.Redirect(pg.ResolveClientUrl(NoneLogin));
                }
            }
        }
        public int checkPassword(string password)
        {
            int strong = 0;
            Regex teShu = new Regex("[~!@#$%_^&*()=+[\\]{}''\";:/?.,><`|！·￥…—（）\\-、；：。，》《]");
            Regex daXie = new Regex("[A-Z]");
            Regex xiaoXie = new Regex("[a-z]");
            Regex shuZi = new Regex("[0-9]");
            if (teShu.IsMatch(password) == true)
                strong++;
            if (daXie.IsMatch(password) == true)
                strong++;
            if (xiaoXie.IsMatch(password) == true)
                strong++;
            if (shuZi.IsMatch(password) == true)
                strong++;
            return strong;
        }
    }
}