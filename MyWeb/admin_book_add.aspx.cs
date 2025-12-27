using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_add : System.Web.UI.Page
{
    public static string imgname;
    public static string fileExtension;
    public static string name;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            DropDownList1.Items.Add(new ListItem("男", "0"));
            DropDownList1.Items.Add(new ListItem("女", "1"));
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            imgname = System.Guid.NewGuid().ToString("N");  //32位随机数字作为新文件名
            fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToLower();  //得到图片后缀
            FileUpload1.SaveAs(Server.MapPath("/UploadImg/") + imgname + fileExtension);
            this.uploadimg.Text = "照片上传成功";
            Image1.ImageUrl = "/UploadImg/" + imgname + fileExtension;
            name = imgname + fileExtension;
        }
        else
        {
            //Response.Write("<script>alert('无选择图片！')</script>");
            this.uploadimg.Text = "无选择照片";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int cateid = int.Parse(Session["CategoryID"].ToString());
        int userid = int.Parse(Session["UserId"].ToString());
       ;

        if (BLL.User_Bll.Get_p(userid).Rows[0]["UserType"].ToString()== "管理员")
        {
            if (BLL.Admin_Bll.Add_Per(txb_PerName.Text, int.Parse(DropDownList1.SelectedValue), txb_IDcard.Text, DateTime.Parse(txb_date.Text),
            txb_education.Text, txb_address.Text, cateid, name, txb_JiangCheng.Text, txb_GZjingyan.Text,
            txb_Train.Text, int.Parse(txb_num.Text)))
            {
                Response.Write("<script>alert('添加成功！');location.href = 'admin_book_info.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败！');location.href = 'admin_book_info.aspx'</script>");
            }
        }
        else
        {
            if (BLL.Admin_Bll.Add_Per(txb_PerName.Text, int.Parse(DropDownList1.SelectedValue), txb_IDcard.Text, DateTime.Parse(txb_date.Text),
            txb_education.Text, txb_address.Text, cateid, name, txb_JiangCheng.Text, txb_GZjingyan.Text,
            txb_Train.Text, int.Parse(txb_num.Text)))
            {
                Response.Write("<script>alert('添加成功！');location.href = 'admin_book_info3.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败！');location.href = 'admin_book_info.aspx'</script>");
            }
        }
        
    }
}