using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_type : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt1 = BLL.Admin_Bll.Get_booktype();
            Repeater1.DataSource = dt1;
            Repeater1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        CheckBox checkbox = new CheckBox();                 //创建对象
        HiddenField id;                                     //创建对象
        for (int i = 0; i < Repeater1.Items.Count; i++)
        {
            checkbox = (CheckBox)Repeater1.Items[i].FindControl("CheckBox1");//取对象
            id = (HiddenField)Repeater1.Items[i].FindControl("HiddenField1");//取对象
            if (checkbox.Checked == true)                   //是否被选中
            {
                int cateid = int.Parse(id.Value.ToString());  //赋值
                if (BLL.Admin_Bll.Get_ifhavebook(cateid).Rows.Count > 0)
                {
                    Response.Write("<script>alert('该公司下有员工，不能删除！');</script>");
                }
                else
                {
                    if (BLL.Admin_Bll.Delete_cate(cateid))
                    {
                        Response.Write("<script>alert('删除成功');location.href='admin_book_type.aspx'</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('删除失败');location.href='admin_book_type.aspx'</script>");
                    }
                }


            }

        }
    }
}