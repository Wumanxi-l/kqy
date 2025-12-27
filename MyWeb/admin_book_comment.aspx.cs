using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_book_comment : System.Web.UI.Page
{
    public static string now;
    int pagesize = 5;
    public static DataTable dt_ComInfo = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dt_ComInfo = BLL.Admin_Bll.Get_com();
            ViewState["pageindex"] = 1;
            int totalcount = dt_ComInfo.Rows.Count;
            if (totalcount == 0)
            {
                Label4.Text = "没有评论发布";

            }
            else
            {
                if (totalcount % pagesize == 0)       //得到最后一页页数（总共页数）
                {
                    ViewState["pagelastindex"] = totalcount / pagesize;   //页数正好的情况
                }
                else
                {
                    ViewState["pagelastindex"] = totalcount / pagesize + 1;  //最后一页不足5个（余数可为1，2，3，4）
                }

                if (int.Parse(ViewState["pagelastindex"].ToString()) == 1)     //总共不到一页
                {
                    if (totalcount % pagesize != 0)            //不满一页(1,2,3,4项)
                    {
                        Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, (int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize + dt_ComInfo.Rows.Count % pagesize, dt_ComInfo);
                    }
                    else           //  数据只有一页(5项满了)
                    {
                        Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

                    }
                }
                else
                {
                    Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

                }
                Label3.Text = ViewState["pagelastindex"].ToString();
            }
            now = ViewState["pageindex"].ToString();
            Repeater1.DataBind();

            Label2.Text = ViewState["pageindex"].ToString();

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
                int reviewid = int.Parse(id.Value.ToString());  //赋值
                if (BLL.Admin_Bll.Delete_commnet(reviewid))
                {
                    Response.Write("<script>alert('删除成功');location.href='admin_book_comment.aspx'</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败');location.href='admin_book_comment.aspx'</script>");
                }
            }

        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ViewState["pageindex"] = 1;
        dt_ComInfo = BLL.Admin_Bll.Search_com(search_name.Text, search_teacher.Text, TextBox1.Text);
        if (dt_ComInfo.Rows.Count == 0)   //查询结果为空，则放上所有搜索项
        {
            dt_ComInfo = BLL.Admin_Bll.Get_com();
            txbnotice.Text = "未查询到符合条件的结果，下列结果为所有评论";
        }
        else                           //查询到结果
        {
            txbnotice.Text = "搜索结果如下：";
        }
        int totalcount = dt_ComInfo.Rows.Count;    //总共数据条数
        if (totalcount % pagesize == 0)       //得到最后一页页数（总共页数）
        {
            ViewState["pagelastindex"] = totalcount / pagesize;
        }
        else { ViewState["pagelastindex"] = totalcount / pagesize + 1; }

        if (int.Parse(ViewState["pagelastindex"].ToString()) == 1)     //总共不到一页
        {
            if (totalcount % pagesize != 0)            //不满一页(1,2,3,4项)
            {
                Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, (int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize + dt_ComInfo.Rows.Count % pagesize, dt_ComInfo);

            }
            else           //  数据只有一页(5项满了)
            {
                Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

            }
        }
        else
        {
            Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

        }
        now = ViewState["pageindex"].ToString();
        Repeater1.DataBind();


        Label2.Text = ViewState["pageindex"].ToString();
        Label3.Text = ViewState["pagelastindex"].ToString();
    }
    public static DataTable DtSelect(int start, int end, DataTable oDT)
    {
        DataTable NewTable = oDT.Clone();
        DataRow[] rows = oDT.Select("1=1");
        for (int i = start; i < end; i++)
        {
            NewTable.ImportRow((DataRow)rows[i]);
        }
        return NewTable;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        ViewState["pageindex"] = 1;
        if (int.Parse(ViewState["pagelastindex"].ToString()) == 1)   //总共不到一页
        {
            if (dt_ComInfo.Rows.Count % pagesize != 0)            // 最后会余下1，2，3，4项
            {
                Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, (int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize + dt_ComInfo.Rows.Count % pagesize, dt_ComInfo);

            }
            else              // 最后不余项，全满
            {
                Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

            }
        }
        else            //总共页数比一页多，则一页必定全满
        {
            Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

        }
        now = ViewState["pageindex"].ToString();
        Repeater1.DataBind();

        Label2.Text = ViewState["pageindex"].ToString();
        Label3.Text = ViewState["pagelastindex"].ToString();
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        int pageindex = Convert.ToInt32(ViewState["pageindex"]);
        if (pageindex > 1)
        {
            pageindex--;
            ViewState["pageindex"] = pageindex;
            Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);
            now = ViewState["pageindex"].ToString();
            Repeater1.DataBind();

            Label2.Text = ViewState["pageindex"].ToString();
            Label3.Text = ViewState["pagelastindex"].ToString();
        }
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        int pageindex = Convert.ToInt32(ViewState["pageindex"]);
        if (pageindex < Convert.ToInt32(ViewState["pagelastindex"]))
        {
            pageindex++;
            ViewState["pageindex"] = pageindex;
            if (pageindex != int.Parse(ViewState["pagelastindex"].ToString()))            //下一页
            {
                Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

            }
            else
            {
                if (dt_ComInfo.Rows.Count % pagesize != 0)            // 最后会余下1，2，3，4项
                {
                    Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, (int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize + dt_ComInfo.Rows.Count % pagesize, dt_ComInfo);

                }
                else              // 最后不余项，全满
                {
                    Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

                }
            }

            now = ViewState["pageindex"].ToString();
            Repeater1.DataBind();

            Label2.Text = ViewState["pageindex"].ToString();
            Label3.Text = ViewState["pagelastindex"].ToString();
        }
    }


    protected void LinkButton5_Click(object sender, EventArgs e)
    {

        ViewState["pageindex"] = ViewState["pagelastindex"];
        if (dt_ComInfo.Rows.Count % pagesize != 0)            //不满一页(1,2,3,4项)
        {
            Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, (int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize + dt_ComInfo.Rows.Count % pagesize, dt_ComInfo);

        }
        else           //  数据只有一页(5项满了)
        {
            Repeater1.DataSource = DtSelect((int.Parse(ViewState["pageindex"].ToString()) - 1) * pagesize, int.Parse(ViewState["pageindex"].ToString()) * pagesize, dt_ComInfo);

        }

        now = ViewState["pageindex"].ToString();
        Repeater1.DataBind();

        Label2.Text = ViewState["pageindex"].ToString();
        Label3.Text = ViewState["pagelastindex"].ToString();
    }
}