<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_apply_edit.aspx.cs" Inherits="admin_apply_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .m_right {
            margin-left: 100px;
            margin-top: 30px;
        }

        .btn_tj1 {
            margin-top: 40px;
            height: 35px;
            width: 130px;
            font-size: 17px;
            background-color: #62A8D1;
            color: #fff;
            border: none;
        }

            .btn_tj1:hover {
                background-color: #006CBE;
            }

        .mem_tit {
            font-size: 23px;
        }

        .m_des {
            margin-top: 30px;
        }

        .lab1 {
            margin-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="m_right">
            <p></p>
            <div class="mem_tit">续用审核</div>
            <div class="m_des">

                <div class="lab1">用户姓名：<asp:Label ID="txb_name" runat="server" Text="Label"></asp:Label></div>
                </br>
                                
          <div class="lab1">续用档案：<asp:Label ID="txb_book" runat="server" Text="Label"></asp:Label></asp:TextBox></div>
                </br>
                <div class="lab1">原本应还日期：<asp:Label ID="txb_num" runat="server" Text="Label"></asp:Label></asp:TextBox></div>
                </br>         
                 <div class="lab1">申请归还日期：<asp:Label ID="TextBox1" runat="server" Text="Label"></asp:Label></asp:TextBox></div>
                </br>  

                <asp:Button ID="Button1" runat="server" Text="通过续用申请" CssClass="btn_tj1" OnClick="Button1_Click" />

            </div>
        </div>
    </form>
</body>
</html>
