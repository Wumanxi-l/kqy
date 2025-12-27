using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_info1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt_ComInfo;
            dt_ComInfo = BLL.Admin_Bll.Get_Pernocom();
            Repeater1.DataSource = dt_ComInfo;
            Repeater1.DataBind();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        DataTable dt_ComInfo;
        dt_ComInfo = BLL.Admin_Bll.Search_per1(search_name.Text, search_teacher.Text);
        if (dt_ComInfo.Rows.Count == 0)   //查询结果为空，则放上所有搜索项
        {
            dt_ComInfo = BLL.Admin_Bll.Get_Pernocom();
            txbnotice.Text = "未查询到符合条件的结果，下列结果为所有无公司人员";
        }
        else                           //查询到结果
        {
            txbnotice.Text = "搜索结果如下：";
        }
        Repeater1.DataSource = dt_ComInfo;
        Repeater1.DataBind();
    

    }
}