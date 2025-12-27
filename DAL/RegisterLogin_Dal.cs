using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DAL
{
    public class RegisterLogin_Dal
    {
        public static DataTable Check_Username(string username)  //检查用户名是否相同
        {
            string sql = String.Format("select * from UserInfo where UserName='{0}'", username);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Register_Person(string username, string password)  //读者注册
        {
            string sql = String.Format("insert into UserInfo values('{0}','{1}','用户',1,0,0)", username, password);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable Login(string username, string password)  //用户登录
        {
            string sql = String.Format("select * from UserInfo where UserName='{0}' and UserPwd='{1}'", username, password);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }
        public static bool Create_Person(string username)     //求职者注册时为其默认创建空的个人简历表
        {
            string sql = string.Format("insert into PersonInfo(UserId,PersonSex) values((select UserId from UserInfo where UserName = '{0}'),0)", username);
            return MyUtility.SqlHelper.Getresult(sql);
        }
        public static DataTable GetPersonId(int id)  //登陆时根据userid查询读者id
        {
            string sql = String.Format("select * from PersonInfo where UserId={0}", id);
            return MyUtility.SqlHelper.GetDataTable(sql);
        }

        public static bool Register_Com(string username, string password, int cate)  //公司管理员注册
        {
            string sql = String.Format("insert into UserInfo values('{0}','{1}','公司管理员',0,'{2}',0)", username, password, cate);
            return MyUtility.SqlHelper.Getresult(sql);
        }
    }
}
