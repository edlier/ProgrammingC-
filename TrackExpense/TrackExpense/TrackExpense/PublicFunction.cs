using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TrackExpense
{
    public class PublicFunction
    {
        public DataTable SetFirstChooseItem(string idName,string setDataColumnName, DataTable dt)
        {
            DataRow row = dt.NewRow();
            row[setDataColumnName] = "Choose......";
            row[idName] = 0;
            dt.Rows.InsertAt(row, 0);
            return dt;
        }
    }
}
