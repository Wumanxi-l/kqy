<%@ Page Language="C#" AutoEventWireup="true" CodeFile="book_detail_view.aspx.cs" Inherits="book_detail_view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <title>档案详情</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    
        <link rel="stylesheet" href="css/bootstrap-datetimepicker.min.css" />
     <link rel="stylesheet" href="css/ok.css" />
    <style>
        body {
            background: url('images/background_image.jpg') no-repeat center center fixed;
            background-size: cover;
            background-color: #b3e0ff; 
            color: #00264d; 
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        .container {
            padding: 50px;
        }

        .ss {
            margin-top: -50px;
        }

        .book-details-container {
            background-color: rgba(179, 224, 255, 0.9);
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0px 0px 20px 0px #00264d;
        }

        .book-details-container1 {
            background-color: rgba(240,255,255, 0.9); 
            padding: 30px;
            margin-bottom: 15px;
            border-radius: 15px;
            box-shadow: 0px 0px 20px 0px #00264d;
        }

        .book-cover {
            max-width: 200px;
            margin-bottom: 20px;
        }

        .book-title {
            color: #00264d; 
            font-size: 24px;
            font-weight: bold;
            margin-bottom: 10px;
        }

        .book-author {
            color: #004080;
            font-size: 18px;
            margin-bottom: 10px;
        }

        .book-description {
            color: #00264d; 
            margin-bottom: 20px;
        }

        .book-details-actions {
            display: flex;
            justify-content: space-between;
            align-items: center;
        }

        .btn-primary {
            background-color: #00264d; /* 深蓝色按钮 */
            border-color: #00264d;
            color: #b3e0ff; /* 浅蓝色文字 */
            font-weight: bold;
            letter-spacing: 1px;
        }

            .btn-primary:hover {
                background-color: #004080; 
                border-color: #004080;
                color: #b3e0ff;
            }

        .similar-books {
            margin-top: 30px;
        }

        .similar-books-title {
            color: #00264d;
            font-size: 20px;
            font-weight: bold;
            margin-bottom: 20px;
        }

        .similar-book-card {
            background-color: rgba(179, 224, 255, 0.9);
            padding: 15px;
            margin: 10px;
            box-shadow: 0px 0px 15px 0px #00264d;
        }
    </style>
    <style>
        .ranking_num_top {
            color: red;
        }

        .ranking_num {
            font-size: 28px;
            width: 30px;
            height: 60px;
            float: left;
        }

        .ranking_body {
            float: left;
            width: 260px;
            height: 40px;
            font-size: 14px;
        }

        .ranking_text {
            height: 30px;
        }

        .ranking_time {
            font-size: 12px;
        }

        .area_text {
            height: 150px;
            width: 400px;
        }

        .num1 {
            color: #808080;
            font: 14px;
        }

        .rank_time {
            color: #808080;
            font: 14px;
        }

        .ranking_text {
            font: 16px;
        }

        .pic {
            width: 120px;
            height: 150px;
            margin-top: -140px;
        }

        .t1 {
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="book-details-container">
                <div class="row">
                    <div class="col-md-4">
                        <asp:Image ID="Image1" runat="server" class="img-fluid book-cover" />
                    </div>
                    <div class="col-md-8">
                        <p class="book-title">
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </p>
                        <p class="book-author">姓名：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></p>
                        <p class="book-author">性别：<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></p>
                        <p class="book-author">身份证：<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label></p>
                        <p class="book-author">出生日期：<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></p>
                         <p class="book-author">学历：<asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></p>
                         <p class="book-author">籍贯：<asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></p>
                         <p class="book-author">所属公司：<asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></p>
                         <p class="book-author">奖惩信息：<asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></p>
                        <p class="book-author">工作经验：<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></p>
                        <p class="book-author">培训信息：<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></p>
                        <p class="book-author">库存：<asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></p>
                        <p class="book-description">
                        </p>

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

                        <div class="book-details-actions">
                            <asp:Button ID="Button1" runat="server" Text="使用" OnClick="Button1_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        
    </form>
</body>
</html>
