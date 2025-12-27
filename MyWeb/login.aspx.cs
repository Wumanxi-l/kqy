using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked == true)  //判断是否勾选协议
        {

            DataTable dt = BLL.RegisterLogin_Bll.Login(TextBox1.Text, TextBox2.Text);
            if (dt.Rows.Count > 0)  //判断用户名密码是否正确
            {
                if (dt.Rows[0]["UserType"].ToString() == "用户")
                {
                    Session["UserId"] = dt.Rows[0]["UserId"].ToString();
                    DataTable dt3 = BLL.RegisterLogin_Bll.GetPersonId(int.Parse(Session["UserId"].ToString()));
                    Session["Person"] = int.Parse(dt3.Rows[0]["Person"].ToString());
                    Response.Write("<script>alert('登录成功');location.href='Default.aspx'</script>");


                }
                else if (dt.Rows[0]["UserType"].ToString() == "管理员")
                {
                    Session["UserId"] = dt.Rows[0]["UserId"].ToString();
                    Session["CategoryID"] = "1012";
                    Response.Write("<script>alert('管理员登录成功');location.href='admin_index.aspx'</script>");
                }
                else if (dt.Rows[0]["UserType"].ToString() == "公司管理员")
                {
                    if (int.Parse(dt.Rows[0]["State"].ToString()) == 1)
                    {
                        Session["UserId"] = dt.Rows[0]["UserId"].ToString();
                        Session["CategoryID"] = dt.Rows[0]["CategoryID"].ToString();
                        Response.Write("<script>alert('公司管理员登录成功');location.href='admin_index2.aspx'</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('公司管理员账号未通过审核');location.href='login.aspx'</script>");
                    }

                }
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！请重新输入');location.href='Login.aspx';</script>");
            }


        }
        else
        {
            Response.Write("<script>alert('请勾选同意协议和隐私政策！');</script>");
        }
    }
}