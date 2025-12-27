using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_edit2 : System.Web.UI.Page
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
            if (int.Parse(txb_PerSex.Text) == 1)
            {
                txb_PerSex.Text = "女";
            }
            else
            {
                txb_PerSex.Text = "男";
            }

            txb_IDcard.Text = dt.Rows[0]["IDcard"].ToString();
            txb_date.Text = DateTime.Parse(dt.Rows[0]["birth"].ToString()).ToShortDateString();
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

        if (BLL.Admin_Bll.Update_lizhi(perid))
        {
            Response.Write("<script>alert('离职成功！');location.href = 'admin_book_info2.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('失败！');</script>");
        }
    }
}