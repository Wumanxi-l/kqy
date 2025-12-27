<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <style>
        body {
            background-color: #e6f7ff; 
        }

        .container {
            margin-top: 50px;
        }

        h2 {
            color: #004080; /* 深蓝色标题 */
            text-align: center;
        }

        hr {
            border-color: #004080; /* 深蓝色分隔线 */
        }

        .row {
            justify-content: center;
        }

        .col-md-6 {
            background-color: #b3d9ff; /* 中蓝色容器背景 */
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px 0px #666666; /* 阴影效果 */
            margin: 10px;
        }

        table {
            background-color: #ffffff; /* 白色表格背景 */
        }

        th, td {
            text-align: center;
        }

        .form-group label {
            color: #004080; /* 深蓝色表单标签 */
        }

        button {
            background-color: #004080; /* 深蓝色按钮 */
            color: #ffffff; /* 白色按钮文字 */
            border: none;
        }

        button:hover {
            background-color: #00264d; /* 深蓝色按钮悬停状态 */
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
        <h2>跨企业人事档案共享服务系统</h2>
        <hr />

        <div class="row">
            <div class="col-md-6">
                <h3>档案列表</h3>
                <table class="table">
                    <thead>
                        <tr>
                            <th>姓名</th>
                            <th>身份证号码</th>
                            <th>出生日期</th>
                        </tr>
                    </thead>
                    <tbody>
                        <!-- 这里使用服务器端代码绑定数据 -->
                        <asp:Repeater ID="bookRepeater" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("PerName") %></td>
                                    <td><%# Eval("IDcard") %></td>
                                    <td><%# Eval("birth", "{0:yyyy-MM-dd}") %></td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>

            <div class="col-md-6">
           
                    <div class="form-group">
                        <label for="txtTitle">姓名：</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtAuthor">身份证号码：</label>
                        <asp:TextBox ID="txtAuthor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtPublishDate">出生日期：</label>
                        <asp:TextBox ID="txtPublishDate" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <button type="submit" class="btn btn-primary">添加档案</button>
          
            </div>
        </div>
    </div>

    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
