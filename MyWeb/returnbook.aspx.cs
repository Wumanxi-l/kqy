using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class returnbook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int recordid = int.Parse(Request["RecordID"]);
            DataTable dt = BLL.User_Bll.Get_borrowbyrid(recordid);
            Label1.Text = DateTime.Parse(dt.Rows[0]["BorrowDate"].ToString()).ToShortDateString();
            Label2.Text = DateTime.Parse(dt.Rows[0]["ObDate"].ToString()).ToShortDateString();
            /*   DataTable dt = BLL.User_Bll.Get_bookbyid(bookid);
               Label1.Text = dt.Rows[0]["Title"].ToString();
               Label3.Text = dt.Rows[0]["ISBN"].ToString();
               Label6.Text = DateTime.Parse(dt.Rows[0]["PublishDate"].ToString()).ToShortDateString();
               Label5.Text = dt.Rows[0]["CateName"].ToString();
               Label7.Text = dt.Rows[0]["Numbers"].ToString();
               Label2.Text = dt.Rows[0]["Authors"].ToString();
               Label4.Text = dt.Rows[0]["Publishers"].ToString();
               Image1.ImageUrl = "/UploadImg/" + dt.Rows[0]["BookImg"].ToString();
               Image2.ImageUrl = "/UploadImg/" + BLL.User_Bll.Get_perbyid(userid).Rows[0]["PersonImg"].ToString();

               DataTable dt1 = BLL.User_Bll.Get_combyid(bookid);
               Repeater2.DataSource = dt1;
               Repeater2.DataBind();*/

        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int recordid = int.Parse(Request["RecordID"]);
        int bookid = int.Parse(Request["BookID"]);
        DataTable dt = BLL.User_Bll.Get_Perbyid(bookid);
        int num = int.Parse(dt.Rows[0]["Numbers"].ToString());


        DataTable dt_ComInfo;
        dt_ComInfo = BLL.User_Bll.Get_borrowbyrid(recordid);
        if (!string.IsNullOrEmpty(dt_ComInfo.Rows[0]["ReturnDate"].ToString()))
        {
            Response.Write("<script>alert('档案已被归还，不能再次归还！');location.href = 'borrowinfo.aspx'</script>");
        }
        else
        {
            if (BLL.User_Bll.Update_returndate(recordid, DateTime.Now.Date))
            {
                num++;
                BLL.User_Bll.Update_Per(num, bookid);
                Response.Write("<script>alert('归还成功！');location.href = 'borrowinfo.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('归还失败！');</script>");
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int recordid = int.Parse(Request["RecordID"]);
        DataTable dt_ComInfo;
        dt_ComInfo = BLL.User_Bll.Get_borrowbyrid(recordid);
 


        if (dt_ComInfo.Rows[0]["State"].ToString() !="1")
        {
            if (BLL.User_Bll.Update_longerdate(recordid, DateTime.Parse(txdate.Text)))
            {
                Response.Write("<script>alert('续用申请已发出，等待后台管理员审核！');location.href = 'borrowinfo.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('续用失败！');</script>");
            }
        }
        else
        {
          
            Response.Write("<script>alert('该档案只能续用一次！');</script>");
        }


    }
}