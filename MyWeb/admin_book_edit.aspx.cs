using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_edit : System.Web.UI.Page
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

            dp_GongSi.DataSource = BLL.Admin_Bll.Get_booktype();
            dp_GongSi.DataTextField = "CateName";
            dp_GongSi.DataValueField = "CategoryID";
            dp_GongSi.DataBind();
            dp_GongSi.SelectedValue = dt.Rows[0]["CategoryID"].ToString();

            perSex.Items.Add(new ListItem("男", "0"));
            perSex.Items.Add(new ListItem("女", "1"));
            perSex.SelectedIndex = int.Parse(dt.Rows[0]["perSex"].ToString());

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
        int perid = int.Parse(Request["PerID"]);
        if (BLL.Admin_Bll.Update_Per(txb_PerName.Text, int.Parse(perSex.Text), txb_IDcard.Text,
            txb_education.Text, txb_address.Text, int.Parse(dp_GongSi.SelectedValue), name, txb_JiangCheng.Text, txb_GZjingyan.Text,
            txb_Train.Text, int.Parse(txb_num.Text), perid, txb_date.Text))
        {
            Response.Write("<script>alert('修改成功！');location.href = 'admin_book_info3.aspx'</script>");
        }
        else
        {
            Response.Write("<script>alert('修改失败！');</script>");
        }
    }
}