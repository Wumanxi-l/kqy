using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Edit_Account1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int userid = int.Parse(Request["UserId"]);
            DataTable dt = BLL.Admin_Bll.Get_AccountInfoById1(userid);
  
            TextBox1.Text = dt.Rows[0]["UserName"].ToString();
            TextBox2.Text = dt.Rows[0]["UserPwd"].ToString();
            Label2.Text = dt.Rows[0]["CateName"].ToString();
            DropDownList1.Items.Add(new ListItem("不通过", "0"));
            DropDownList1.Items.Add(new ListItem("审核通过", "1"));
            DropDownList1.SelectedIndex = int.Parse(dt.Rows[0]["State"].ToString());
        }
    }

 

    protected void Button1_Click(object sender, EventArgs e)
    {
        int userid = int.Parse(Request["UserId"]);
        if (BLL.Admin_Bll.Update_Com(DropDownList1.SelectedIndex, userid))
        {
            Response.Write("<script>alert('审核完毕');location.href='admin_account_view2.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('更改失败');location.href='admin_account_view2.aspx'</script>");
        }
    }
}