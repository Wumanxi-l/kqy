using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class book_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = BLL.User_Bll.Get_Per();
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
            DropDownList1.DataSource = BLL.Admin_Bll.Get_booktype();
            DropDownList1.DataTextField = "CateName";
            DropDownList1.DataValueField = "CategoryID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("---请选择---", "0"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        DataTable dt1 = BLL.User_Bll.Search_Goods(TextBox1.Text, TextBox2.Text, int.Parse(DropDownList1.SelectedValue));
        if (dt1.Rows.Count == 0)   //查询结果为空，则放上所有搜索项
        {
            dt1 = BLL.User_Bll.Get_Per();
            txbnotice.Text = "未查询到符合条件的结果，下列结果为所有档案";
        }
        else                           //查询到结果
        {
            txbnotice.Text = "搜索结果如下：";
        }
        Repeater1.DataSource = dt1;
        Repeater1.DataBind();
    }
}