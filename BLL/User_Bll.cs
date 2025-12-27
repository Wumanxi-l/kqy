using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User_Bll
    {
        public static DataTable Get_topbook()
        {
            return DAL.User_Dal.Get_topbook();
        }
        public static DataTable Get_perbyid(int userid)
        {
            return DAL.User_Dal.Get_perbyid(userid);
        }
        public static DataTable Get_p(int userid)
        {
            return DAL.User_Dal.Get_p(userid);
        }
        public static bool Update_stu(string name, int sex, string phone, string email, string pic, int userid)
        {
            return DAL.User_Dal.Update_stu(name, sex, phone, email, pic, userid);
        }
        public static DataTable Get_Per()
        {
            return DAL.User_Dal.Get_Per();
        }
        public static DataTable Search_Goods(string name, string IDcard, int type)
        {
            return DAL.User_Dal.Search_Goods(name, IDcard, type);
        }
        public static DataTable Get_Perbyid(int bookid)
        {
            return DAL.User_Dal.Get_Perbyid(bookid);
        }
        public static bool Add_borrow(int bookid, int userid, DateTime borrowdate, DateTime obdate)
        {

            return DAL.User_Dal.Add_borrow(bookid, userid, borrowdate, obdate);
        }
        public static bool Update_Per(int num, int bookid)
        {
            return DAL.User_Dal.Update_Per(num, bookid);
        }
        public static bool Add_comment(int userid, int bookid, string content, DateTime comdate)
        {
            return DAL.User_Dal.Add_comment(userid, bookid, content, comdate);
        }
        public static DataTable Get_combyid(int bookid)
        {
            return DAL.User_Dal.Get_combyid(bookid);
        }
        public static DataTable Get_borrowbyid(int userid)
        {
            return DAL.User_Dal.Get_borrowbyid(userid);
        }
        public static DataTable Get_borrowbyrid(int rid)
        {
            return DAL.User_Dal.Get_borrowbyrid(rid);
        }
        public static bool Update_returndate(int rid, DateTime redate)
        {
            return DAL.User_Dal.Update_returndate(rid, redate);
        }
        public static bool Update_longerdate(int rid, DateTime redate)
        {
            return DAL.User_Dal.Update_longerdate(rid, redate);
        }
        public static DataTable Get_borrowbyrid_count(int rid)
        {
            return DAL.User_Dal.Get_borrowbyrid_count(rid);
        }
        public static DataTable Get_booktypebyid(int bookid)
        {
            return DAL.User_Dal.Get_booktypebyid(bookid);
        }
        public static bool Update_member(int userid)
        {
            return DAL.User_Dal.Update_member(userid);
        }
    }
}
