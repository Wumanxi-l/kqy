using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_type_add : System.Web.UI.Page
{
    public static string imgname;
    public static string fileExtension;
    public static string name;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
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
        if (BLL.Admin_Bll.Add_type(txb_title.Text, name))
        {
            Response.Write("<script>alert('添加成功！');location.href = 'admin_book_type.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('添加失败！');location.href = 'admin_book_type.aspx'</script>");
        }
    }
}