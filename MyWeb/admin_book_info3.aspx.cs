using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_info3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int cateid = int.Parse(Session["CategoryID"].ToString());
            DataTable dt = new DataTable();
            dt = BLL.Admin_Bll.Get_Perincom(cateid);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int cateid = int.Parse(Session["CategoryID"].ToString());
        DataTable dt_ComInfo;
        dt_ComInfo = BLL.Admin_Bll.Search_per2(search_name.Text, search_teacher.Text, cateid);
        if (dt_ComInfo.Rows.Count == 0)   //查询结果为空，则放上所有搜索项
        {
            dt_ComInfo = BLL.Admin_Bll.Get_Perincom(cateid);
            txbnotice.Text = "未查询到符合条件的结果，下列结果为所有本公司人员";
        }
        else                           //查询到结果
        {
            txbnotice.Text = "搜索结果如下：";
        }
        Repeater1.DataSource = dt_ComInfo;
        Repeater1.DataBind();
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
                int bookid = int.Parse(id.Value.ToString());  //赋值
                if (BLL.Admin_Bll.Delete_Per(bookid))
                {
                    Response.Write("<script>alert('删除成功');location.href='admin_book_info3.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败');location.href='admin_book_info3.aspx'</script>");
                }
            }

        }
    }
}