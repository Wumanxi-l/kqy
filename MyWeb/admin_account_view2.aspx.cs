using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_account_view2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = BLL.Admin_Bll.Get_ComAccount();
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }
}