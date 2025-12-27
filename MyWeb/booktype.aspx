<%@ Page Language="C#" AutoEventWireup="true" CodeFile="booktype.aspx.cs" Inherits="booktype" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/search/1.css" />
    <link rel="stylesheet" href="css/search/3.css" />

    <link rel="stylesheet" href="css/search/2.css" />

    <link rel="stylesheet" href="css/search/index1.css" />
    <link rel="stylesheet" href="css/search/999.css" />
    <link rel="stylesheet" href="css/search/Search.css" />
    <style>
        body {
            background: url('images/background_image.jpg') no-repeat center center fixed;
            background-size: cover;
            background-color: #b3d9ff; /* 蓝色背景 */
            color: #333; /* 主体文本颜色 */
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <nav class="navbar navbar-expand-lg navbar-dark fixed-top">
            <a class="navbar-brand" href="#">跨企业人事档案共享系统</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ">
                    <li class="nav-item ">
                        <a class="nav-link" href="Default.aspx">首页</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="book_list.aspx">档案列表</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="myinfo.aspx">个人中心</a>
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
        <div style="margin-bottom: 10px;">
            <div class="container">
                <div style="width: 1000px; margin-left: 40px; margin-top: 15px;">
   
                    <div class="clearfix">
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <a target="_blank" href="book_detail_view.aspx?bookid=<%#Eval("PerID") %>" class="module-pro-item fl">
                                    <div class="pro-img">
                                        <img src="/UploadImg/<%#Eval("PerImg").ToString()%>" alt="">
                                    </div>
                                    <span class="text-color-6 ellipsis"><%#Eval("CateName")%></span>&nbsp&nbsp&nbsp&nbsp<span style="color: rgba(0,0,0,.2); font-size: 10px;"></span>
                                    <div class="clearfix pro-item-bottom">
                                        <p class="pro-price fl align-center"><%#Eval("PerName")%></p>

                                        
                                    </div>
                                </a>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
