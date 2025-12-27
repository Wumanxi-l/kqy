<%@ Page Language="C#" AutoEventWireup="true" CodeFile="returnbook.aspx.cs" Inherits="returnbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>跨企业人事档案共享服务系统</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/bootstrap-datetimepicker.min.css" />
    <link rel="stylesheet" href="css/ok.css" />
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
            background-color: rgba(245,255,250, 1);
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
            margin-top: 15px;
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

        .tp {
            margin-left: 20px;
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
                        <a class="nav-link" href="myinfo.aspx">个人中心</a>
                    </li>
                    <li class="nav-item active">
                        <a class="nav-link" href="borrowinfo.aspx">使用记录</a>
                    </li>
                       <li class="nav-item">
            <a class="nav-link" href="member.aspx">成为会员</a>
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
        <div style="margin-bottom: 40px;">
            <div class="container">
                <div class="panel-title tp">
                    <div class="compete_list ok">
                        <div class="rr">
                            <div style="font-size: 22px;">归还</div>
                        </div>
                    </div>
                    <div style="margin-top: 10px;"></div>
                    <div class="ee1">使用日期：<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></div>
                    <div style="margin-top: 5px;"></div>
                    <div class="ee1">应还日期：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></div>


                    <asp:Button ID="Button3" runat="server" Text="归还" CssClass="btn_tj1" OnClick="Button3_Click" />

                    <div style="margin-top: 30px;"></div>

                    <div class="compete_list ok">
                        <div class="rr">
                            <div style="font-size: 22px;">续用</div>
                        </div>
                    </div>
                    <div style="margin-top: 10px;"></div>
                    <p class="update-title">选择归还日期：</p>
    
                    <div class="form-group">
                        <div class="input-group date form_date col-md-5" data-date="" data-date-format="" data-link-format="yyyy-mm-dd">
                            <asp:TextBox ID="txdate" runat="server" CssClass="form-control"></asp:TextBox>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
                            <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                        </div>
                    </div>
                    <script type="text/javascript" src="js/jquery-1.8.3.min.js" charset="UTF-8"></script>
                    <script type="text/javascript" src="js/bootstrap-datetimepicker.js" charset="UTF-8"></script>
                    <script type="text/javascript" src="js/bootstrap-datetimepicker.zh-CN.js" charset="UTF-8"></script>
                    <script type="text/javascript">
                        $('.form_date').datetimepicker({
                            language: 'zh-CN',
                            weekStart: 1,
                            todayBtn: 1,
                            autoclose: 1,
                            todayHighlight: 1,
                            startView: 2,
                            minView: 2,
                            forceParse: 0
                        });
                    </script>

                    <asp:Button ID="Button1" runat="server" Text="续用" CssClass="btn_tj1" OnClick="Button1_Click" />
                </div>
            
            </div>
            <div style="margin-bottom: 40px;"></div>
        </div>
    </form>
</body>
</html>
