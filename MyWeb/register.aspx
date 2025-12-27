<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>跨企业人事档案共享服务系统</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />

    <style>
        body {
            background: url('images/2.jpg') no-repeat center center fixed;
            background-size: cover;
            background-color: #b3e0ff; /* 浅蓝色背景 */
            color: #00264d; /* 深蓝色文本颜色 */
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        .login-container {
            background-color: rgba(225,255,255, 0.8);
            padding: 40px;
            margin: 100px auto; /* 居中显示 */
            max-width: 500px;
            border-radius: 15px;
            box-shadow: 0px 0px 20px 0px #00264d;
        }

        h2 {
            color: #00264d; /* 深蓝色标题 */
            text-align: center;
            margin-bottom: 30px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-control {
            background-color: white; /* 浅蓝色输入框 */
            border-color: #004080; /* 深蓝色边框 */
            color: #00264d; /* 深蓝色文字 */
        }

        .btn-primary {
            background-color: #00264d; /* 深蓝色按钮 */
            border-color: #00264d;
            color: #b3e0ff; /* 浅蓝色文字 */
            width: 100%;
            padding: 15px;
            font-weight: bold;
            letter-spacing: 1px;
            font-size: 16px;
        }

            .btn-primary:hover {
                background-color: #004080; /* 深蓝色悬停状态 */
                border-color: #004080;
                color: #b3e0ff; /* 浅蓝色文字 */
            }

        .forgot-password {
            text-align: right;
            color: #004080; /* 深蓝色链接颜色 */
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
                <h2>欢迎新用户注册</h2>

                <div class="form-group">
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="用户名" required></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="密码" type="password" required></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="重复密码" type="password" required></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="*两次密码不一致" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ForeColor="#CC0000"></asp:CompareValidator>、
                </div>
                <div class="form-group">

                    <span  class="fl">
                        <label class="r_rad">
                            <asp:CheckBox ID="CheckBox2" runat="server" />
                        </label>
                        <label class="r_txt">我已阅读并接受《用户协议》</label>
                    </span>

                </div>
                <asp:Button ID="Button1" runat="server" Text="注册" OnClick="Button1_Click" class="btn btn-primary" />
                <div class="forgot-password">
                    <a href="login.aspx">已有帐号？立即登录！</a>
                      
                </div>

            </div>
        </div>


        <script src="js/jquery-3.2.1.slim.min.js"></script>
        <script src="js/popper.min.js"></script>
        <script src="js/bootstrap.min.js"></script>
    </form>
</body>
</html>
