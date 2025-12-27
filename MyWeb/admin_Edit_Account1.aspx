<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_Edit_Account1.aspx.cs" Inherits="admin_Edit_Account1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        .view {
            width: 78%;
            margin-top: 20px;
            margin-bottom: 40px;
            background-color: #fff;
            padding-left: 70px;
            padding-top: 15px;
            float: left;
            margin-left: 40px;
        }

        .txb1 {
            height: 40px;
            width: 300px;
            font-size: 17px;
        }

        .btn_save {
            margin-top: 40px;
            margin-left: 100px;
            height: 40px;
            width: 100px;
            font-size: 17px;
        }

        .btn_reset {
            margin-top: 40px;
            margin-left: 40px;
            height: 40px;
            width: 100px;
            font-size: 17px;
            margin-bottom: 20px;
        }

        .lab1 {
            margin-top: 40px;
            margin-left: 100px;
            font-size: 17px;
        }

        .lab {
            margin-top: 20px;
            margin-left: 100px;
            font-size: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="view">
            <h3>账号管理-账号编辑</h3>

            </br>
            <div class="lab">账号：<asp:Label ID="TextBox1" runat="server" CssClass="txb1"></asp:Label></div>
            </br>
            <div class="lab">密码：<asp:Label ID="TextBox2" runat="server" CssClass="txb1"></asp:Label></div>
            </br>
            <div class="lab">所属公司：<asp:Label ID="Label2" runat="server"></asp:Label></div>
            </br>
           <div class="lab">
               <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>
            </br>
            <div class="lab">
                <asp:Button ID="Button1" runat="server" Text="审核结果" OnClick="Button1_Click" /></div>
        </div>
    </form>
</body>
</html>
