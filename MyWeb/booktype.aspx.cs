using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class booktype : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int id = int.Parse(Request["CategoryID"]);
            DataTable dt = BLL.User_Bll.Get_booktypebyid(id);
            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
    }
}