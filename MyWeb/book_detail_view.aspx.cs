using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class book_detail_view : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int userid = int.Parse(Session["UserId"].ToString());
            DataTable dt1;
            dt1 = BLL.User_Bll.Get_perbyid(userid);
            if (int.Parse(dt1.Rows[0]["member"].ToString()) == 0)
            {
                Response.Write("<script>alert('您还不是会员，不能查看档案！');location.href = 'member.aspx'</script>");
            }
            else
            {

                int bookid = int.Parse(Request["bookid"]);
                DataTable dt = BLL.User_Bll.Get_Perbyid(bookid);
                Label1.Text = dt.Rows[0]["PerName"].ToString();
                Label3.Text = dt.Rows[0]["PerSex"].ToString();
                Label7.Text = dt.Rows[0]["IDcard"].ToString();
                Label6.Text = DateTime.Parse(dt.Rows[0]["birth"].ToString()).ToShortDateString();
                Label8.Text = dt.Rows[0]["education"].ToString();
                Label9.Text = dt.Rows[0]["Address"].ToString();
                Label10.Text = dt.Rows[0]["CateName"].ToString();
                Label11.Text = dt.Rows[0]["JiangCheng"].ToString();
                Label5.Text = dt.Rows[0]["GZjingyan"].ToString();
                Label4.Text = dt.Rows[0]["Train"].ToString();
                Label12.Text = dt.Rows[0]["Numbers"].ToString();
                Image1.ImageUrl = "/UploadImg/" + dt.Rows[0]["PerImg"].ToString();
                

                DataTable dt2 = BLL.User_Bll.Get_combyid(bookid);
                
            }

        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int bookid = int.Parse(Request["bookid"]);
        int userid = int.Parse(Session["UserId"].ToString());
        DataTable dt = BLL.User_Bll.Get_Perbyid(bookid);
        int num = int.Parse(dt.Rows[0]["Numbers"].ToString());
        if (num == 0)
        {
            Response.Write("<script>alert('库存不足，不能使用');</script>");
        }
        else
        {
            if (BLL.User_Bll.Add_borrow(bookid, userid, DateTime.Now.Date, DateTime.Parse(txdate.Text)))
            {
                num--;
                BLL.User_Bll.Update_Per(num, bookid);

                Response.Write("<script>alert('使用成功！');location.href = 'book_detail_view.aspx?bookid=" + bookid + "' </script>");

            }
            else
            {
                Response.Write("<script>alert('使用失败');</script>");
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }
}