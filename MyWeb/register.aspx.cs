using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox2.Checked == true)  //判断是否勾选协议
        {
            if (BLL.RegisterLogin_Bll.Check_Username(this.TextBox1.Text).Rows.Count > 0)
            {
                Response.Write("<script>alert('账号不能重复.请重新注册');location.href='Register.aspx';</script>");
            }
            else
            {
                if (BLL.RegisterLogin_Bll.Register_Person(TextBox1.Text, TextBox2.Text))
                {
                    BLL.RegisterLogin_Bll.Create_Person(TextBox1.Text);
                    Response.Write("<script>alert('注册成功');location.href='login.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('注册失败');location.href='register.aspx';</script>");
                }
            }
        }
        else
        {
            Response.Write("<script>alert('请勾选同意协议和隐私政策！');</script>");
        }
    }
}