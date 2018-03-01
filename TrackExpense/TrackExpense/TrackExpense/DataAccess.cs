using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
namespace TrackExpense
{
    public class DataAccess
    {
        private db dbConnect = new db();

        public DataTable Get_ExpenseListByDate(string startDate, string endDate)
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "CALL searchExpenseList("
                + dbConnect.qo(startDate) + ","
                + dbConnect.qo(endDate)
                + ")";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_PaymentKind()
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT * FROM paycreditcard";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_Currency()
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT * FROM currency";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_CatogoryTypeB()
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT * FROM expense_CatB";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_CatogoryTypeS_FromBType(string BType)
        {
            DataTable dt = new DataTable();
            if (BType != "")
            {
                string sqlstr = "";
                sqlstr = "SELECT * FROM expense_CatS WHERE LinkBID=" + BType;
                dt = dbConnect.GetDataTable(sqlstr);
            }
            return dt;
        }

        public DataTable Get_PlaceCatB()
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT * FROM place_catb";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_PlaceCatB_CheckDul(string Type)
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT * FROM place_catb WHERE Type=" + dbConnect.qo(Type);
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }

        public DataTable Get_PlaceCatS()
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT place_cats.ID, LinkBID, place_catb.Type AS 'PlaceBType',place_cats.Des "
                +" FROM place_cats "
                +" LEFT JOIN place_catb ON(place_catb.ID=place_cats.LinkBID) ";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_PlaceCatS_FullList_ByBPlace(string BPlace)
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT place_cats.ID, LinkBID, place_catb.Type AS 'PlaceBType',place_cats.Des "
                + " FROM place_cats "
                + " LEFT JOIN place_catb ON(place_catb.ID=place_cats.LinkBID) WHERE LinkBID=" + BPlace;
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_PlaceCatS_FullList_ByBPlaceAndDes(string BPlace,string Des)
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT place_cats.ID, LinkBID, place_catb.Type AS 'PlaceBType',place_cats.Des "
                + " FROM place_cats "
                + " LEFT JOIN place_catb ON(place_catb.ID=place_cats.LinkBID) "
                +  " WHERE LinkBID=" + BPlace+ " AND "
                +" (place_cats.Des Like '%"+Des+ "%'  OR  place_cats.Des Like '%" + Des+ "' OR  place_cats.Des Like '"+ Des+"%'           )";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Get_PlaceCatS_FullList_ByDes(string Des)
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT place_cats.ID, LinkBID, place_catb.Type AS 'PlaceBType',place_cats.Des "
                + " FROM place_cats "
                + " LEFT JOIN place_catb ON(place_catb.ID=place_cats.LinkBID) "
                + " WHERE " 
                +" (place_cats.Des Like '%"+Des+ "%'  OR  place_cats.Des Like '%" + Des+ "' OR  place_cats.Des Like '"+ Des+"%'           )";
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }

        public DataTable Get_PlaeceCatS_FromBPlace(string BPlace)
        {
            DataTable dt;
            string sqlstr = "";
            sqlstr = "SELECT * FROM place_cats WHERE LinkBID=" + BPlace;
            dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }

        public DataTable Insert_ExpenseRecord(string spentDate,string content,string price,string currency,string payByCard,
            string PayCreditCardID,string expense_CatB, string expense_CatS,string receiptNum,string type,
            string Place_CatB,string Place_CatS,string Note)
        {
            string sqlstr = "";
            sqlstr = "INSERT INTO expenserecord " +
                " ( SpentDate, Content, Price, Currency, PayByCard, " +
                "PayCreditCardID, Expense_CatB, Expense_CatS, receiptNum, Type, " +
                "Place_CatB, Place_CatS, Note)" 
                + "VALUES (" +dbConnect.qo(spentDate)  +","
                +dbConnect.qo(content) + "," 
                + price + "," 
                +dbConnect.qo(currency) + "," 
                + payByCard + ","

                + PayCreditCardID + ","
                + expense_CatB + ","
                + expense_CatS + ","
                + receiptNum + ","
                + type + ","

                + Place_CatB + ","
                + Place_CatS + ","
                + dbConnect.qo(Note) 
                + ");";
             DataTable dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }

        public DataTable Insert_PlaceTypeB(string PlaceTypeB)
        {
            string sqlstr = "";
            sqlstr = "INSERT INTO place_catb " +
                " (Type)"
                + "VALUES (" + dbConnect.qo(PlaceTypeB) +");";
            DataTable dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Update_PlaceTypeB(string PlaceTypeB_ID,string PlaceTypeB)
        {
            string sqlstr = "";
            sqlstr = "UPDATE place_catb " +
                "  SET Type="+dbConnect.qo(PlaceTypeB)
                + " WHERE ID="+ PlaceTypeB_ID;
            DataTable dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }
        public DataTable Delete_PlaceTypeB(string PlaceTypeB_ID)
        {
            string sqlstr = "";
            sqlstr = "DELETE FROM place_catb " 
                + " WHERE ID=" + PlaceTypeB_ID;
            DataTable dt = dbConnect.GetDataTable(sqlstr);
            return dt;
        }


    }
}