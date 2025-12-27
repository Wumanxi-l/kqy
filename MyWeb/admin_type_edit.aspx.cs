using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_type_edit : System.Web.UI.Page
{

    public static string imgname;
    public static string fileExtension;
    public static string name;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int cateid = int.Parse(Request["CategoryID"]);
            DataTable dt = BLL.Admin_Bll.Get_TypeInfoById(cateid);

            txb_name.Text = dt.Rows[0]["CateName"].ToString();


            name = dt.Rows[0]["CateImg"].ToString();
            Image1.ImageUrl = "/UploadImg/" + dt.Rows[0]["CateImg"].ToString();
        }
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
        int cateid = int.Parse(Request["CategoryID"]);
        if (BLL.Admin_Bll.Update_Type(txb_name.Text, name, cateid))
        {
            Response.Write("<script>alert('修改成功！');location.href = 'admin_book_type.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败！');</script>");
        }
    }
}