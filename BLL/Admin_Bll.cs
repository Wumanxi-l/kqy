using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Admin_Bll
    {
        public static DataTable Get_PersonAccount()
        {
            return DAL.Admin_Dal.Get_PersonAccount();
        }
        public static DataTable Get_ComAccount()
        {
            return DAL.Admin_Dal.Get_ComAccount();
        }
        public static DataTable Get_AdminAccount()
        {
            return DAL.Admin_Dal.Get_AdminAccount();
        }
        public static DataTable Get_booktype()
        {
            return DAL.Admin_Dal.Get_booktype();
        }
        public static bool Add_type(string name, string pic)
        {
            return DAL.Admin_Dal.Add_type(name, pic);
        }
        public static DataTable Get_TypeInfoById(int typeid)
        {
            return DAL.Admin_Dal.Get_TypeInfoById(typeid);
        }
        public static bool Update_Type(string typename, string name, int typeid)
        {
            return DAL.Admin_Dal.Update_Type(typename, name, typeid);
        }
        public static DataTable Get_Per()
        {
            return DAL.Admin_Dal.Get_Per();
        }
        public static bool Add_Per(string name, int sex, string idcard, DateTime birth, string edu, string address, int cateid, string img, string jiangcheng, string jingyan, string train, int number)
        {
            return DAL.Admin_Dal.Add_Per(name, sex, idcard, birth, edu, address, cateid, img, jiangcheng, jingyan, train, number);
        }
        public static DataTable Get_AccountInfoById(int userid)
        {
            return DAL.Admin_Dal.Get_AccountInfoById(userid);
        }
        public static DataTable Get_AccountInfoById1(int userid)
        {
            return DAL.Admin_Dal.Get_AccountInfoById1((int)userid);
        }
        public static bool Update_Account(string username, string password, int userid)
        {
            return DAL.Admin_Dal.Update_Account(username, password, userid);
        }
        public static DataTable Search_Goods(string name, string IDcard, int type)
        {
            return DAL.Admin_Dal.Search_Goods(name, IDcard, type);
        }
        public static bool Update_Per(string PerName, int PerSex, string IDcard, string education,
            string Address, int CategoryID, string PerImg, string JiangCheng, string GZjingyan, string Train, int Numbers, int PerID, string birth)
        {
            return DAL.Admin_Dal.Update_Per(PerName, PerSex, IDcard, education, Address, CategoryID, PerImg, JiangCheng, GZjingyan, Train, Numbers, PerID, birth);
        }
        public static DataTable Get_perbyid(int bookid)
        {
            return DAL.Admin_Dal.Get_perbyid(bookid);
        }
        public static DataTable Get_com()
        {
            return DAL.Admin_Dal.Get_com();
        }
        public static DataTable Search_com(string userid, string pername, string content)
        {
            return DAL.Admin_Dal.Search_com(userid, pername, content);
        }
        public static DataTable Get_borrow()
        {
            return DAL.Admin_Dal.Get_borrow();
        }
        public static DataTable Get_borrow_apply()
        {
            return DAL.Admin_Dal.Get_borrow_apply();
        }
        public static DataTable Get_borrow_applybyid(int rid)
        {
            return DAL.Admin_Dal.Get_borrow_applybyid(rid);
        }
        public static bool Update_borrow(DateTime applydate, int rid)
        {
            return DAL.Admin_Dal.Update_borrow(applydate, rid);
        }
        public static DataTable Search_borrow(string name, string book)
        {
            return DAL.Admin_Dal.Search_borrow(name, book);
        }
        public static DataTable Search_appborrow(string name, string book)
        {
            return DAL.Admin_Dal.Search_appborrow(name, book);
        }
        public static bool Delete_applyborrow(int recordid)
        {
            return DAL.Admin_Dal.Delete_applyborrow(recordid);
        }
        public static bool Delete_commnet(int reviewid)
        {
            return DAL.Admin_Dal.Delete_commnet(reviewid);
        }
        public static bool Delete_Per(int bookid)
        {
            return DAL.Admin_Dal.Delete_Per(bookid);
        }
        public static bool Delete_commnetfrombook(int bookid)
        {
            return DAL.Admin_Dal.Delete_commnetfrombook(bookid);
        }
        public static bool Delete_applyborrowfrombook(int bookid)
        {
            return DAL.Admin_Dal.Delete_applyborrowfrombook(bookid);
        }
        public static bool Delete_cate(int cateid)
        {
            return DAL.Admin_Dal.Delete_cate(cateid);
        }
        public static DataTable Get_ifhavebook(int cateid)
        {
            return DAL.Admin_Dal.Get_ifhavebook(cateid);
        }
        public static bool Update_Com(int state, int comid)
        {
            return DAL.Admin_Dal.Update_Com(state, comid);
        }
        public static DataTable Get_Pernocom()
        {
            return DAL.Admin_Dal.Get_Pernocom();
        }
        public static bool Update_ruzhi(int cateid, int perid)
        {
            return DAL.Admin_Dal.Update_ruzhi(cateid, perid);
        }
        public static DataTable Get_Perincom(int cateid)
        {
            return DAL.Admin_Dal.Get_Perincom(cateid);
        }
        public static bool Update_lizhi(int perid)
        {
            return DAL.Admin_Dal.Update_lizhi(perid);
        }
        public static DataTable Search_per1(string name, string IDcard)
        {
            return DAL.Admin_Dal.Search_per1(name, IDcard);
        }
        public static DataTable Search_per2(string name, string IDcard, int cateid)
        {
            return DAL.Admin_Dal.Search_per2(name, IDcard, cateid);
        }
    }
}
