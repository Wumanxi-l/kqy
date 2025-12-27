using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_borrow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = BLL.Admin_Bll.Get_borrow();
            Repeater1.DataSource = dt;
            Repeater1.DataBind();

            System.Web.UI.WebControls.Label label = new System.Web.UI.WebControls.Label();                 //创建对象
            HiddenField id;                                     //创建对象
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                label = (System.Web.UI.WebControls.Label)Repeater1.Items[i].FindControl("Label1");//取对象
                id = (HiddenField)Repeater1.Items[i].FindControl("HiddenField1");//取对象
                int recordid = int.Parse(id.Value.ToString());  //赋值
                if (!string.IsNullOrEmpty(dt.Rows[i]["ReturnDate"].ToString()))
                {
                    label.Text = DateTime.Parse(dt.Rows[i]["ReturnDate"].ToString()).ToShortDateString();
                }
                else
                {
                    label.Text = "未归还档案";
                }
            }

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
                int recourid = int.Parse(id.Value.ToString());  //赋值
                if (BLL.Admin_Bll.Delete_applyborrow(recourid))
                {
                    Response.Write("<script>alert('删除成功');location.href='admin_borrow.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败');location.href='admin_borrow.aspx'</script>");
                }
            }

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //BLL.Admin_Bll.Search_borrow();
        DataTable dt1 = BLL.Admin_Bll.Search_borrow(search_name.Text, TextBox1.Text);
        if (dt1.Rows.Count == 0)   //查询结果为空，则放上所有搜索项
        {
            dt1 = BLL.Admin_Bll.Get_borrow();
            txbnotice.Text = "未查询到符合条件的结果，下列结果为所有结果";
        }
        else                           //查询到结果
        {
            txbnotice.Text = "搜索结果如下：";
        }
        Repeater1.DataSource = dt1;
        Repeater1.DataBind();
    }
}