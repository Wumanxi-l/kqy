<%@ Page Language="C#" AutoEventWireup="true" CodeFile="borrowinfo.aspx.cs" Inherits="borrowinfo" %>

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
        <div style="margin-bottom: 40px;">
            <div class="container">
                <div style="font-size: 23px; margin-left: 30px;">使用记录</div>
                </br>
                <div style="width: 1000px; margin-left: 80px;">
            
                    <div class="compete_list">
                        <table id="sample-table-1" class="table table-striped table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>编号</th>
                                    <th>姓名</th>
                                    <th>身份证号码</th>
                                    <th>使用日期</th>
                                    <th>应还日期</th>
                                    <th>归还日期</th>
                                    <th>操作</th>
                                </tr>
                            </thead>
                            <tbody>
                                <asp:Repeater ID="Repeater1" runat="server">
                                    <ItemTemplate>
                                        <tr>
                                         
                 
                                            <td><%#Eval("RecordID") %></td>
                                            <td><%#Eval("PerID") %></td>
                                            <td><%#Eval("IDcard") %></td>
                                            <td><%#DateTime.Parse(Eval("BorrowDate").ToString()).ToShortDateString()%></td>
                                            <td><%#DateTime.Parse(Eval("ObDate ").ToString()).ToShortDateString()%></td>
                                            <td>
                                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
                                            <td>
                                                <a title="归还|续用" href="returnbook.aspx?RecordID=<%#Eval("RecordID") %>&&BookID=<%#Eval("PerID") %>">归还|续用</a>
                                                <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("RecordID")%>' />
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
