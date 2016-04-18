using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class validation
    {
        //判斷TextBox輸入值是否為數字
        public bool IsNumeric(string TextBoxValue)
        {
            try
            {
                int i = Convert.ToInt32(TextBoxValue);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
