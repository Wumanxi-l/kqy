using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Edit_Account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int userid = int.Parse(Request["UserId"]);
            DataTable dt = BLL.Admin_Bll.Get_AccountInfoById(userid);
            Label1.Text = dt.Rows[0]["UserId"].ToString();
            TextBox1.Text = dt.Rows[0]["UserName"].ToString();
            TextBox2.Text = dt.Rows[0]["UserPwd"].ToString();
            Label2.Text = dt.Rows[0]["UserType"].ToString();
        }
    }

    protected void SaveBtn_Click(object sender, EventArgs e)
    {
        int userid = int.Parse(Request["UserId"]);   //选择修改项的userid
        DataTable dt1 = BLL.Admin_Bll.Get_AccountInfoById(userid);
        string username = dt1.Rows[0]["UserName"].ToString();

        if (userid == 2 && username == "admin")   //检查要修改的是否为超级管理员用户 不能修改超级管理员账号
        {
            Response.Write("<script>alert('此用户为超级管理员，账号信息不能被修改！');location.href = 'admin_account_view3.aspx'</script>");
        }
        else
        {
            string usertype = BLL.Admin_Bll.Get_AccountInfoById(userid).Rows[0]["UserType"].ToString();
            if (TextBox1.Text == username)  //检查用户名是否变动  若当前没有修改用户名
            {

                if (usertype == "用户")
                {
                    if (BLL.Admin_Bll.Update_Account(TextBox1.Text, TextBox2.Text, userid))
                    {
                        Response.Write("<script>alert('修改成功！');location.href = 'admin_account_view1.aspx'</script>");
                    }
                }
                else if (usertype == "管理员")
                {
                    int userid1 = int.Parse(Session["UserId"].ToString());   //当前操作账号的id
                    if (userid1 == 2)   //当前操作的账号为超级管理员（可删除，修改其他管理员信息）
                    {
                        if (BLL.Admin_Bll.Update_Account(TextBox1.Text, TextBox2.Text, userid))
                        {
                            Response.Write("<script>alert('修改成功！');location.href = 'admin_account_view3.aspx'</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('此账号不是超级管理员，不能修改其他管理员账号信息！');location.href = 'admin_account_view3.aspx'</script>");
                    }
                }
            }
            else if (BLL.RegisterLogin_Bll.Check_Username(TextBox1.Text).Rows.Count > 0)   //当前已修改用户名时，检查修改的用户名是否重复  
            {
                Response.Write("<script>alert('账号不能重复,请重新修改账号信息');</script>");
            }
            else
            {
                if (usertype == "用户")
                {
                    if (BLL.Admin_Bll.Update_Account(TextBox1.Text, TextBox2.Text, userid))
                    {
                        Response.Write("<script>alert('修改成功！');location.href = 'admin_account_view1.aspx'</script>");
                    }
                }
                else if (usertype == "管理员")
                {
                    int userid1 = int.Parse(Session["UserId"].ToString());   //当前操作账号的id
                    if (userid1 == 2)   //当前操作的账号为超级管理员（可删除，修改其他管理员信息）
                    {
                        if (BLL.Admin_Bll.Update_Account(TextBox1.Text, TextBox2.Text, userid))
                        {
                            Response.Write("<script>alert('修改成功！');location.href = 'admin_account_view3.aspx'</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('此账号不是超级管理员，不能修改其他管理员账号信息！');location.href = 'admin_account_view3.aspx'</script>");
                    }
                }


            }
        }
    }
}