using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User_Dal
    {
        public static DataTable Get_topbook()  //得到top8所有图书信息
        {
            string sql = String.Format("select top 8 * from Per bs,Categories ct where bs.CategoryID = ct.CategoryID ");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_perbyid(int userid)  //得到个人信息
        {
            string sql = String.Format("select * from UserInfo ui,PersonInfo si where ui.UserId=si.UserId and ui.UserId={0}", userid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_p(int userid)  
        {
            string sql = String.Format("select * from UserInfo where UserId={0}", userid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_stu(string name, int sex, string phone, string email, string pic, int userid)  //更新个人信息
        {
            string sql = String.Format("update PersonInfo set PersonName='{0}',PersonSex ={1},PersonPhone='{2}',PersonEmail='{3}',PersonImg='{4}'  where  UserId={5}", name, sex, phone, email, pic, userid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_Per()  //得到所有图书信息
        {
            string sql = String.Format("select * from Per bs, Categories ct where bs.CategoryID =ct.CategoryID ");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Search_Goods(string name, string idcard, int type) //搜索书籍
        {
            string sql = "select * from Per bs,Categories ct where bs.CategoryID = ct.CategoryID  and 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and bs.PerName" + " like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(idcard))
            {
                sql += " and bs.IDcard " + " like '%" + idcard + "%'";
            }
            if (type != 0)
            {
                sql += " and ct.CategoryID =" + type;
            }

            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_Per(int num, int bookid)  //更新库存
        {
            string sql = String.Format("update Per set Numbers={0} where PerID ={1}", num, bookid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_Perbyid(int bookid)  //得到指定图书信息
        {
            string sql = String.Format("select * from Per bs,Categories ct where bs.CategoryID =ct.CategoryID and bs.PerID={0}", bookid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Add_borrow(int bookid, int userid, DateTime borrowdate, DateTime obdate)  //借阅图书
        {
            string sql = String.Format("insert into BorrowRecords(BookID ,UserID,BorrowDate,ObDate) values({0},{1},'{2}','{3}')", bookid, userid, borrowdate, obdate);
            return MyUtility.SqlHelper.Getresult(sql);
        }


        public static bool Add_comment(int userid, int bookid, string content, DateTime comdate)  //评论
        {
            string sql = String.Format("insert into BookReviews(UserID,BookID,ReviewText,ReviewDate) values({0},{1},'{2}','{3}')", userid, bookid, content, comdate);
            return MyUtility.SqlHelper.Getresult(sql);
        }

        public static DataTable Get_combyid(int bookid)  //得到指定图书评论
        {
            string sql = String.Format("select * from BookReviews bs,PersonInfo pi where bs.UserID =pi.UserId and  bs.BookID ={0}", bookid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_borrowbyid(int userid)  //得到指定人的借阅记录
        {
            string sql = String.Format("select * from Per bs,BorrowRecords br,PersonInfo pi where bs.PerID=br.BookID and br.UserID =pi.UserId  and br.UserID={0}", userid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_borrowbyrid(int rid)  //得到指定借阅记录
        {
            string sql = String.Format("select * from Per bs,BorrowRecords br where bs.PerID=br.BookID and br.RecordID={0}", rid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_borrowbyrid_count(int rid)
        {
            string sql = String.Format("select State from BorrowRecords  where RecordID={0}", rid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_returndate(int rid, DateTime redate)  //还书
        {
            string sql = String.Format("update BorrowRecords set ReturnDate ='{0}' where RecordID  ={1}", redate, rid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static bool Update_longerdate(int rid, DateTime redate)  //续借
        {
            string sql = String.Format("update BorrowRecords set ApplyDate ='{0}',State=0 where RecordID  ={1}", redate, rid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_booktypebyid(int bookid)  //得到图书分类下的图书
        {
            string sql = String.Format("select * from Categories cs,Per bs where cs.CategoryID =bs.CategoryID  and bs.CategoryID ={0}", bookid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }

        public static bool Update_member(int userid)
        {
            string sql = String.Format("update UserInfo set member =1 where UserId={0}",userid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
    }
}
