using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BLL
{
    public class RegisterLogin_Bll
    {
        public static DataTable Check_Username(string username)
        {
            return DAL.RegisterLogin_Dal.Check_Username(username);
        }
        public static bool Register_Person(string username, string password)
        {
            return DAL.RegisterLogin_Dal.Register_Person(username, password);
        }

        public static DataTable Login(string username, string password)  //用户登录
        {
            return DAL.RegisterLogin_Dal.Login(username, password);
        }

        public static bool Create_Person(string username)
        {
            return DAL.RegisterLogin_Dal.Create_Person(username);
        }
        public static DataTable GetPersonId(int id)
        {
            return DAL.RegisterLogin_Dal.GetPersonId(id);
        }
        public static bool Register_Com(string username, string password, int cate)
        {
            return DAL.RegisterLogin_Dal.Register_Com(username, password, cate);
        }
    }
}
