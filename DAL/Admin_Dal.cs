using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Admin_Dal
    {
        public static DataTable Get_PersonAccount()        //得到读者账号信息
        {
            string sql = String.Format("select * from UserInfo where UserType='用户'");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_ComAccount()        //得到公司管理员信息
        {
            string sql = String.Format("select * from UserInfo ui,Categories ct where ui.CategoryID=ct.CategoryID and ui.UserType='公司管理员'");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_AdminAccount()  //得到管理员账号信息
        {
            string sql = String.Format("select * from UserInfo where UserType='管理员'");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_booktype()  //得到所有图书分类
        {
            string sql = String.Format("select * from Categories");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Add_type(string name, string pic)  //添加分类
        {
            string sql = String.Format("insert into Categories(CateName,CateImg) values('{0}','{1}')", name, pic);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_TypeInfoById(int typeid)  // 根据分类id得到类别信息
        {
            string sql = String.Format("select * from Categories where CategoryID ={0}", typeid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_Type(string typename, string name, int typeid)   //修改类别信息
        {
            string sql = String.Format("update Categories set CateName ='{0}' ,CateImg ='{1}' where CategoryID ={2}", typename, name, typeid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_Per()  //得到所有图书信息
        {
            string sql = String.Format("select * from Per bs,Categories ct where bs.CategoryID =ct.CategoryID ");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_Pernocom()  //得到所有无公司档案信息
        {
            string sql = String.Format("select * from Per bs,Categories ct where bs.CategoryID =ct.CategoryID and ct.CateName='无公司'");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Add_Per(string name, int sex, string idcard, DateTime birth, string edu, string address, int cateid, string img, string jiangcheng, string jingyan, string train, int number)  //添加图书
        {
            string sql = string.Format("insert into Per(PerName,PerSex,IDcard,birth,education,Address,CategoryID, PerImg,JiangCheng,GZjingyan,Train,Numbers) values('{0}',{1},'{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}','{11}')", name, sex, idcard, birth, edu, address, cateid, img, jiangcheng, jingyan, train, number);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_AccountInfoById(int userid)        //根据id得到特定账号信息
        {
            string sql = String.Format("select * from UserInfo where UserId={0}", userid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_AccountInfoById1(int userid)        //根据id得到特定账号信息
        {
            string sql = String.Format("select * from UserInfo ui,Categories ct where ui.CategoryID=ct.CategoryID and ui.UserId={0}", userid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_Account(string username, string password, int userid)   //修改账号信息
        {
            string sql = String.Format("update UserInfo set UserName='{0}',UserPwd='{1}' where UserId={2}", username, password, userid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Search_Goods(string name, string IDcard, int type) //搜索书籍
        {
            string sql = "select * from Per bs,Categories ct where bs.CategoryID =ct.CategoryID  and 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and bs.PerName" + " like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(IDcard))
            {
                sql += " and bs.IDcard " + " like '%" + IDcard + "%'";
            }
            if (type != 0)
            {
                sql += " and ct.CategoryID =" + type;
            }

            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_Per(string PerName, int PerSex, string IDcard, string education,
            string Address, int CategoryID, string PerImg, string JiangCheng, string GZjingyan, string Train, int Numbers, int PerID, string birth)   //修改书籍信息
        {
            string sql = String.Format("update Per set PerName = '{0}',PerSex = {1},IDcard = '{2}',education='{3}',Address='{4}',CategoryID={5},PerImg='{6}',JiangCheng='{7}',GZjingyan='{8}',Train='{9}',Numbers={10},birth='{12}' where PerID ={11}", PerName, PerSex, IDcard, education, Address, CategoryID, PerImg, JiangCheng, GZjingyan, Train, Numbers, PerID, birth);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_perbyid(int bookid)  //得到指定图书信息
        {
            string sql = String.Format("select * from Per bs,Categories ct where bs.CategoryID =ct.CategoryID and bs.PerID ={0}", bookid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_com()  //得到所有评论
        {
            string sql = String.Format("select * from BookReviews br,Per bs,UserInfo ui,PersonInfo pr where br.BookID =bs.PerID and br.UserID =ui.UserId and ui.UserId=pr.UserId");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Search_com(string userid, string pername, string content) //搜索评论
        {
            string sql = "select * from BookReviews br,Per bs,UserInfo ui,PersonInfo pr where br.BookID =bs.PerID and br.UserID =ui.UserId and ui.UserId=pr.UserId and 1=1";
            if (!string.IsNullOrEmpty(userid))
            {
                sql += " and ui.UserId" + " like '%" + userid + "%'";
            }
            if (!string.IsNullOrEmpty(pername))
            {
                sql += " and pr.PersonName" + " like '%" + pername + "%'";
            }
            if (!string.IsNullOrEmpty(content))
            {
                sql += " and br.ReviewText" + " like '%" + content + "%'";
            }


            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_borrow()  //得到所有借阅记录
        {
            string sql = String.Format("select * from BorrowRecords br,Per bs,PersonInfo pr where br.BookID =bs.PerID and br.UserID=pr.UserId");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_borrow_apply()  //得到所有续借申请
        {
            string sql = String.Format("select * from BorrowRecords br,Per bs,PersonInfo pr where br.BookID =bs.PerID and br.UserID=pr.UserId and br.State=0");
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Get_borrow_applybyid(int rid)  //得到指定续借申请
        {
            string sql = String.Format("select * from BorrowRecords br,Per bs,PersonInfo pr where br.BookID =bs.PerID and br.UserID=pr.UserId and br.State=0 and br.RecordID ={0}", rid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_borrow(DateTime applydate, int rid)   //更新续借状态
        {
            string sql = String.Format("update BorrowRecords set ObDate ='{0}',State=1 where RecordID ={1}", applydate, rid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Search_borrow(string name, string book) //搜索借阅记录
        {
            string sql = "select * from BorrowRecords br,Per bs,PersonInfo pi  where br.BookID =bs.PerID and br.UserID =pi.UserId  and 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and pi.PersonName" + " like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(book))
            {
                sql += " and bs.PerName" + " like '%" + book + "%'";
            }
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Search_appborrow(string name, string book) //搜索借阅记录
        {
            string sql = "select * from BorrowRecords br,Per bs,PersonInfo pi  where br.BookID =bs.PerID and br.UserID =pi.UserId and br.State=0 and 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and pi.PersonName" + " like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(book))
            {
                sql += " and bs.PerName" + " like '%" + book + "%'";
            }
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Delete_applyborrow(int recordid)  //删除续借记录
        {
            string sql = String.Format("delete from BorrowRecords where RecordID ={0}", recordid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static bool Delete_commnet(int reviewid)  //删除评论
        {
            string sql = String.Format("delete from BookReviews where ReviewID ={0}", reviewid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static bool Delete_Per(int bookid)  //删除图书
        {
            string sql = String.Format("delete from Per where PerID={0}", bookid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static bool Delete_commnetfrombook(int bookid)  //删除特定评论
        {
            string sql = String.Format("delete from BookReviews where BookID ={0}", bookid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static bool Delete_applyborrowfrombook(int bookid)  //删除特定续借记录
        {
            string sql = String.Format("delete from BorrowRecords where BookID ={0}", bookid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static bool Delete_cate(int cateid)  //删除分类
        {
            string sql = String.Format("delete from Categories where CategoryID ={0}", cateid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_ifhavebook(int cateid)  //查看是否有图书在当前分类下
        {
            string sql = String.Format("select * from Per where CategoryID ={0}", cateid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_Com(int state, int comid)
        {
            string sql = String.Format("update UserInfo set State={0} where UserId={1}", state, comid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static bool Update_ruzhi(int cateid, int perid)   //入职
        {
            string sql = String.Format("update Per set CategoryID={0} where PerID ={1}", cateid, perid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Get_Perincom(int cateid)  //得到本公司人员档案
        {
            string sql = String.Format("select * from Per bs,Categories ct where bs.CategoryID=ct.CategoryID and bs.CategoryID={0}", cateid);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Update_lizhi(int perid)   //离职
        {
            string sql = String.Format("update Per set CategoryID=1012 where PerID ={0}", perid);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Search_per1(string name, string IDcard)
        {
            string sql = "select * from Per bs,Categories ct where bs.CategoryID =ct.CategoryID and ct.CateName='无公司' and 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and bs.PerName" + " like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(IDcard))
            {
                sql += " and bs.IDcard " + " like '%" + IDcard + "%'";
            }


            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static DataTable Search_per2(string name, string IDcard, int cateid)
        {
            string sql = "select * from Per bs,Categories ct where bs.CategoryID =ct.CategoryID and 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += " and bs.PerName" + " like '%" + name + "%'";
            }
            if (!string.IsNullOrEmpty(IDcard))
            {
                sql += " and bs.IDcard " + " like '%" + IDcard + "%'";
            }
            if (cateid != 0)
            {
                sql += " and ct.CategoryID =" + cateid;
            }
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
    }
}
