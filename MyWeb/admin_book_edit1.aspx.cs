using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_edit1 : System.Web.UI.Page
{
    public static string imgname;
    public static string fileExtension;
    public static string name;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            int perid = int.Parse(Request["PerID"]);
            DataTable dt = BLL.Admin_Bll.Get_perbyid(perid);

            txb_PerName.Text = dt.Rows[0]["PerName"].ToString();


            txb_PerSex.Text = dt.Rows[0]["PerSex"].ToString();
            txb_IDcard.Text = dt.Rows[0]["IDcard"].ToString();

            txb_education.Text = dt.Rows[0]["education"].ToString();
            txb_address.Text = dt.Rows[0]["Address"].ToString();
            txb_JiangCheng.Text = dt.Rows[0]["JiangCheng"].ToString();
            txb_GZjingyan.Text = dt.Rows[0]["GZjingyan"].ToString();
            txb_Train.Text = dt.Rows[0]["Train"].ToString();
            txb_num.Text = dt.Rows[0]["Numbers"].ToString();
            name = dt.Rows[0]["PerImg"].ToString();
            Image1.ImageUrl = "/UploadImg/" + dt.Rows[0]["PerImg"].ToString();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int perid = int.Parse(Request["PerID"]);
        int cateid = int.Parse(Session["CategoryID"].ToString());
        if (BLL.Admin_Bll.Update_ruzhi(cateid, perid))
        {
            Response.Write("<script>alert('入职成功！');location.href = 'admin_book_info1.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('失败！');</script>");
        }
    }
}