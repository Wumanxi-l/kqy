using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myinfo : System.Web.UI.Page
{
    public static string imgname;
    public static string fileExtension;
    public static string name;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int userid = int.Parse(Session["UserId"].ToString());

            DataTable dt = BLL.User_Bll.Get_perbyid(userid);
            TextBox1.Text = dt.Rows[0]["PersonName"].ToString();
            DropDownList2.DataSource = BLL.Admin_Bll.Get_booktype();
            DropDownList2.DataTextField = "CateName";
            DropDownList2.DataValueField = "CategoryID";
            DropDownList2.DataBind();

            TextBox3.Text = dt.Rows[0]["PersonPhone"].ToString();
            TextBox4.Text = dt.Rows[0]["PersonEmail"].ToString();

          

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
        
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int userid = int.Parse(Session["UserId"].ToString());
        if (BLL.User_Bll.Update_stu(TextBox1.Text, DropDownList2.SelectedIndex, TextBox3.Text, TextBox4.Text, name, userid))
        {
            Response.Write("<script>alert('修改成功！');location.href = 'myinfo.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败！');</script>");
        }
    }
}