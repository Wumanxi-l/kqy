<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_book_edit1.aspx.cs" Inherits="admin_book_edit1" %>

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
            height: 40px;
            width: 100px;
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
            <div class="mem_tit">确认入职信息</div>
            <div class="m_des">

                <div class="lab1">姓名：<asp:Label ID="txb_PerName" runat="server" CssClass="txb1"></asp:Label></div>
                </br>
    <div class="lab1">性别：<asp:Label ID="txb_PerSex" runat="server" CssClass="txb1"></asp:Label></div>
                </br>               
  <div class="lab1">身份证号码：<asp:Label ID="txb_IDcard" runat="server" CssClass="txb1"></asp:Label></div>
                </br>
  <div class="lab1">出生日期：<asp:Label ID="txb_date" runat="server" CssClass="txb1"></asp:Label></div>
                </br>
  <div class="lab1">学历：<asp:Label ID="txb_education" runat="server" CssClass="txb1"></asp:Label></div>
                </br>
  <div class="lab1">籍贯：<asp:Label ID="txb_address" runat="server" CssClass="txb1"></asp:Label></div>
                </br>

  <div class="lab1">奖惩信息：<asp:Label ID="txb_JiangCheng" runat="server" CssClass="txb1"></asp:Label></div>
                </br>
  <div class="lab1">工作经验：<asp:Label ID="txb_GZjingyan" runat="server" CssClass="txb1"></asp:Label></div>
                </br>         
   <div class="lab1">培训信息：<asp:Label ID="txb_Train" runat="server" CssClass="txb1"></asp:Label></div>
                </br>   
  <div class="lab1">库存：<asp:Label ID="txb_num" runat="server" CssClass="txb1"></asp:Label></div>
                </br> 
        <div class="lab1">照片：</div>

                <asp:Image ID="Image1" runat="server" AlternateText="请上传照片" Width="100px" Height="100px" Style="margin-left: 50px;" />
                </br> 

                <asp:Button ID="Button1" runat="server" Text="确认入职" CssClass="btn_tj1" OnClick="Button1_Click" />

            </div>
        </div>
    </form>
</body>
</html>
