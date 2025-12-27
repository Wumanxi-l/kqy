using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            int userid = int.Parse(Session["UserId"].ToString());
            DataTable dt;
            dt = BLL.User_Bll.Get_perbyid(userid);
            if (int.Parse(dt.Rows[0]["member"].ToString()) == 0)
            {
                Label1.Text = "您还不是会员，需成为会员后才能查看档案。";
            }
            else
            {
                Label1.Text = "您已成为会员";
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int userid = int.Parse(Session["UserId"].ToString());
        if (BLL.User_Bll.Update_member(userid))
        { Response.Write("<script>alert('提交成功！');location.href = 'member.aspx'</script>"); }
        else
        {
            Response.Write("<script>alert('失败！');location.href = 'member.aspx'</script>");
        }

    }
}