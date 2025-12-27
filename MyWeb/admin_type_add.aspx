<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_type_add.aspx.cs" Inherits="admin_type_add" %>

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

        .title {
            font-size:23px;
            
            margin-top: 30px;
            margin-left: 100px;
        }

        .txb1 {
            height: 30px;
            width: 250px;
            font-size: 17px;
        }

        .btn_save {
            margin-top: 40px;
            margin-left: 100px;
            height: 40px;
            width: 100px;
            font-size: 17px;
            background-color: #62A8D1;
            color: #fff;
            border: none;
        }

            .btn_save:hover {
                background-color: #006CBE;
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

        .dp {
            height: 30px;
            width: 120px;
        }

        .update-title {
            margin-left: 100px;
            font-size: 17px;
        }

        .kk {
            margin-left: 100px;
            font-size: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="title">添加公司</div>
        <div class="lab1">公司名称：<asp:TextBox ID="txb_title" runat="server" CssClass="txb1"></asp:TextBox></div>
        </br>
        <p class="update-title">上传照片：</p>
        <div class="update-item-tp ">
            <asp:FileUpload ID="FileUpload1" runat="server" Width="320px" Height="100px" CssClass="kk" />
            <asp:Image ID="Image1" runat="server" AlternateText="请上传照片" Width="350px" Height="300px" CssClass="imgcss" />
        </div>
        <asp:Button ID="Button2" runat="server" Text="上传" OnClick="Button2_Click" CssClass="kk" />
        <asp:Label ID="uploadimg" runat="server" Text="" CssClass="lab"></asp:Label></br>
        <asp:Button ID="Button1" runat="server" Text="添加" CssClass="btn_save" OnClick="Button1_Click" />
    </form>
</body>
</html>
