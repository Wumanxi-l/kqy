using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_apply_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int rid = int.Parse(Request["RecordID"]);
            DataTable dt = BLL.Admin_Bll.Get_borrow_applybyid(rid);
            txb_name.Text = dt.Rows[0]["PersonName"].ToString();
            txb_book.Text = dt.Rows[0]["PerName"].ToString();
            txb_num.Text = DateTime.Parse(dt.Rows[0]["ObDate"].ToString()).ToShortDateString();
            TextBox1.Text = DateTime.Parse(dt.Rows[0]["ApplyDate"].ToString()).ToShortDateString(); 

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int rid = int.Parse(Request["RecordID"]);
        DataTable dt = BLL.Admin_Bll.Get_borrow_applybyid(rid);
        if (BLL.Admin_Bll.Update_borrow(DateTime.Parse(dt.Rows[0]["ApplyDate"].ToString()), rid))
        {
            Response.Write("<script>alert('修改成功！');location.href = 'admin_applyborrow.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败！');</script>");
        }
    }
}