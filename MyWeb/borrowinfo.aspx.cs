using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class borrowinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt_ComInfo;
            int userid = int.Parse(Session["UserId"].ToString());
            dt_ComInfo = BLL.User_Bll.Get_borrowbyid(userid);
            Repeater1.DataSource = dt_ComInfo;
            Repeater1.DataBind();

            System.Web.UI.WebControls.Label label = new System.Web.UI.WebControls.Label();                 //创建对象
            HiddenField id;                                     //创建对象
            for (int i = 0; i < Repeater1.Items.Count; i++)
            {
                label = (System.Web.UI.WebControls.Label)Repeater1.Items[i].FindControl("Label1");//取对象
                id = (HiddenField)Repeater1.Items[i].FindControl("HiddenField1");//取对象
                int recordid = int.Parse(id.Value.ToString());  //赋值
                if (!string.IsNullOrEmpty(dt_ComInfo.Rows[i]["ReturnDate"].ToString()))
                {
                    label.Text = DateTime.Parse(dt_ComInfo.Rows[i]["ReturnDate"].ToString()).ToShortDateString();
                }
                else
                {
                    label.Text = "未归还";
                }

            }
        }
    }
}