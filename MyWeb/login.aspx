<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />

    <style>
        body {
            background: url('images/2.jpg') no-repeat center center fixed;
            background-size: cover;
            background-color: #b3e0ff;
            color: #00264d;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        .login-container {
            background-color: rgba(225,255,255, 0.8);
            padding: 40px;
            margin: 100px auto;
            max-width: 500px;
            border-radius: 15px;
            box-shadow: 0px 0px 20px 0px #00264d;
        }

        h2 {
            color: #00264d;
            text-align: center;
            margin-bottom: 30px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-control {
            background-color: white;
            border-color: #004080;
            color: #00264d;
        }

        .btn-primary {
            background-color: #00264d;
            border-color: #00264d;
            color: #b3e0ff;
            width: 100%;
            padding: 15px;
            font-weight: bold;
            letter-spacing: 1px;
            font-size: 16px;
        }

            .btn-primary:hover {
                background-color: #004080;
                border-color: #004080;
                color: #b3e0ff;
            }

        .forgot-password {
            text-align: right;
            color: #004080;
        }

            .forgot-password:hover {
                text-decoration: underline;
            }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="login-container">
                <h2>欢迎登录跨企业人事档案共享服务系统</h2>

                <div class="form-group">
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="用户名" required></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="密码" required></asp:TextBox>
                </div>
                <div class="form-group">
                    <span class="fl">
                        <label class="r_rad">
                            <asp:CheckBox ID="CheckBox1" runat="server" /></label><label class="r_txt">我已阅读并接受《用户协议》</label>
                    </span>
                </div>
                <asp:Button ID="Button1" runat="server" Text="登录" class="btn btn-primary" OnClick="Button1_Click" />
                <div class="forgot-password">
                    <a href="register.aspx" class="a1">普通用户注册</a>

                </div>
                <div class="forgot-password">

                    <a href="register1.aspx" class="a1">公司管理员注册</a>
                </div>
            </div>
        </div>

        <script src="js/jquery-3.2.1.slim.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
    </form>
</body>
</html>
