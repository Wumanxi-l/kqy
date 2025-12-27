<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member.aspx.cs" Inherits="member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>跨企业人事档案共享服务系统</title>
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
    </style>
    <style>
        #scrollingContainer {
            overflow: hidden;
            white-space: nowrap;
        }

        #scrollingContent {
            display: inline-block;
            white-space: nowrap;
            animation: scroll 10s linear infinite;
        }

        @keyframes scroll {
            from {
                transform: translateX(5%);
            }

            to {
                transform: translateX(-90%);
            }
        }

        .scrollingItem {
            padding: 10px;
            display: inline-block;
            margin-right: 20px;
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
                    <li class="nav-item active">
                        <a class="nav-link" href="#">首页</a>
                    </li>
                    <li class="nav-item">
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
        <div class="container">
            <div id="scrollingContainer">
                <div id="scrollingContent">
                    <div class="scrollingItem">欢迎来到跨企业人事档案共享服务系统! 人事档案随心查，企业协作无障碍，跨企共享，开启人力新生态。 温馨提示：每次使用档案只能续用一次!!!</div>

                </div>
            </div>
        </div>
        <div style="margin-bottom: 40px;">
            <div class="container">
                <div style="font-size: 23px; margin-left: 30px;">成为会员</div>
                </br>
                <div style="width: 1000px; margin-left: 80px;">

                    <div class="clearfix">



                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

                        <asp:Button ID="Button1" runat="server" Text="提交会费" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
        <script src="js/jquery-3.2.1.slim.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>

        <script>

</script>
    </form>
</body>
</html>
