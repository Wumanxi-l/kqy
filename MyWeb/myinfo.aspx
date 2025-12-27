<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myinfo.aspx.cs" Inherits="myinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <style>
        body {
            background: url('images/background_image.jpg') no-repeat center center fixed;
            background-size: cover;
            background-color: #b3d9ff; 
            color: #333;
        }

        .navbar {
            background-color: #004080; 
        }

        .navbar-brand, .navbar-nav .nav-link {
            color: #ffffff;
        }

        .jumbotron {
            background-color: rgba(225,255,255, 0.8);
            padding: 40px;
            margin-bottom: 20px;
        }

        h2 {
            color: #004080;
        }

        .container {
            background-color: rgba(245,255,250, 0.8); 
            padding: 20px;
            margin-top: 20px;
        }

        .book-card {
            background-color: rgba(179, 217, 255, 0.8);
            padding: 20px;
            margin: 10px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px 0px #666666;
        }

        .btn-primary {
            background-color: #004080;
            border-color: #004080;
        }

            .btn-primary:hover {
                background-color: #00264d;
                border-color: #00264d;
            }

        .gh {
            width: 150px;
            height: 30px;
        }

        .tp {
            margin-left: 40px;
        }

        .uu {
            width: 100px;
            height: 33px;
            background-color: limegreen;
            border: none;
            color: white;
            margin-top: 20px;
        }

            .uu:hover {
                background-color: forestgreen;
                text-decoration: none;
                cursor: pointer;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark fixed-top">
            <a class="navbar-brand" href="#">跨企业人事档案共享服务系统</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ">
                    <li class="nav-item ">
                        <a class="nav-link" href="Default.aspx">首页</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="book_list.aspx">档案列表</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link active" href="myinfo.aspx">个人中心</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="borrowinfo.aspx">使用记录</a>
                    </li>
                   <li class="nav-item">
            <a class="nav-link" href="member.aspx">成为会员</a>
        </li>
                </ul>
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="login.aspx">退出登录</a>
                    </li>
             
                </ul>
            </div>
        </nav>
        <div class="jumbotron">
            <div class="container">
                <h1 class="display-4">欢迎来到跨企业人事档案共享服务系统</h1>
                <p class="lead">人事档案随心查，企业协作无障碍，跨企共享，开启人力新生态。</p>
            </div>
        </div>
        <div class="container">
            <div class="panel-title tp">
                <div class="compete_list ok">
                    <div class="rr">
                        <h2>企业信息</h2>
                    </div>
                </div>
                <div style="margin-top: 30px;"></div>
                <div class="ee1">使用者职务：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></div>
                </br>
   
     <div class="ee1">企业名称：<asp:DropDownList ID="DropDownList2" runat="server" CssClass="gh"></asp:DropDownList></div>

                </br>
          <div class="ee1">电话：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></div>
                </br>
          <div class="ee1">电子邮件：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></div>

                </br>
           
           <asp:Button ID="Button3" runat="server" Text="更新" CssClass="uu" OnClick="Button3_Click" />
            </div>

        </div>
        <div style="margin-bottom: 40px;"></div>
    </form>
</body>
</html>
