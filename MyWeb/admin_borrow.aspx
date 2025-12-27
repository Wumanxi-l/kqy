<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_borrow.aspx.cs" Inherits="admin_borrow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/style1.css" />
    <link href="assets/css/codemirror.css" rel="stylesheet" />
    <link rel="stylesheet" href="assets/css/ace.min.css" />
    <link rel="stylesheet" href="font/css/font-awesome.min.css" />
    <!--[if lte IE 8]>
		  <link rel="stylesheet" href="assets/css/ace-ie.min.css" />
		<![endif]-->
    <script src="js/jquery-1.9.1.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/typeahead-bs2.min.js"></script>
    <script src="assets/js/jquery.dataTables.min.js"></script>
    <script src="assets/js/jquery.dataTables.bootstrap.js"></script>
    <script src="assets/layer/layer.js" type="text/javascript"></script>
    <script src="assets/laydate/laydate.js" type="text/javascript"></script>
    <script type="text/javascript" src="js/jquery.js"></script>
    <style>
        #addmodal {
            position: fixed;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            background: rgba(0,0,0,0.5);
            display: none;
        }

        #viewmodal {
            position: fixed;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            background: rgba(0,0,0,0.5);
            display: none;
        }

        #movemodal {
            position: fixed;
            left: 0px;
            top: 0px;
            right: 0px;
            bottom: 0px;
            background: rgba(0,0,0,0.5);
            display: none;
        }

        .modal-dialog {
            position: relative;
            width: 500px;
            margin: 0px auto;
            background: white;
            border-radius: 5px;
        }

        .modal-header {
            border-bottom: 1px solid #e5e5e5;
            color: #fff;
            background-color: #555;
            height: 40px;
            line-height: 40px;
            padding-left: 20px;
        }

            .modal-header > i {
                font-weight: bold;
                color: #ADADAD;
                float: right;
                cursor: pointer;
            }

        .modal-body {
            position: relative;
            text-align: center;
        }

            .modal-body input {
                width: 202px;
                border: 1px solid #a9a9a9;
                outline: none;
                margin: 10px;
            }

        .modal-footer {
            padding: 15px;
            text-align: right;
            border-top: 1px solid #e5e5e5;
        }
        /*模态框*/
        .modal {
            display: none; /* 默认隐藏 */
            position: fixed; /* 根据浏览器定位 */
            z-index: 1; /* 放在顶部 */
            left: 0;
            top: 0;
            width: 100%; /* 全宽 */
            height: 100%; /* 全高 */
            overflow: auto; /* 允许滚动 */
            background-color: rgba(0,0,0,0.4); /* 背景色 */
        }
        /*模态框内容*/
        .modal-content {
            display: flex; /*采用flexbox布局*/
            flex-direction: column; /*垂直排列*/
            position: relative;
            background-color: #fefefe;
            margin: 15% auto; /*距顶部15% 水平居中*/
            padding: 20px;
            border: 1px solid #888;
            width: 30%;
            animation: topDown 0.4s; /*自定义动画，从模态框内容上到下出现*/
        }

        @keyframes topDown {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }
        /*模态框头部*/
        .modal-header {
            display: flex; /*采用flexbox布局*/
            flex-direction: row; /*水平布局*/
            align-items: center; /*内容垂直居中*/
            justify-content: space-between;
        }
        /*关闭X 样式*/
        .close {
            color: #aaa;
            float: right;
            font-size: 28px;
            font-weight: bold;
            margin-right: 20px;
        }

            .close:hover {
                color: black;
                text-decoration: none;
                cursor: pointer;
            }

        .dd {
            width: 160px;
            height: 30px;
        }

        .gg {
            width: 160px;
            height: 30px;
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

        .ee1 {
            float: left;
            margin-top: 20px;
        }

        .ee2 {
            float: left;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="margin clearfix">
            <div class="border clearfix">
                <span class="l_f">
                    <asp:Button ID="Button1" runat="server" Text="批量删除" class="btn btn-xs btn-danger " OnClick="Button1_Click" />
                    <asp:TextBox ID="search_name" runat="server" placeholder="输入用户姓名"></asp:TextBox>
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="输入档案者姓名"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="搜索" class="btn btn-primary" OnClick="Button2_Click" />
                    <asp:Label ID="txbnotice" runat="server" Style="margin-top: 6px; color: crimson;"></asp:Label>
                </span>

            </div>
            <div class="compete_list">
                <table id="sample-table-1" class="table table-striped table-bordered table-hover">
                    <thead>
                        <tr>
                            <th class="center">选择</th>
                            <th>编号</th>
                            <th>用户姓名</th>
                            <th>档案者姓名</th>
                            <th>使用日期</th>
                            <th>应还日期</th>
                            <th>归还日期</th>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td class="center">
                                        <label>
                                            <asp:CheckBox ID="CheckBox1" runat="server" class="ace" />
                                            <span class="lbl"></span>
                                        </label>
                                    </td>
                                    <td><%#Eval("RecordID") %></td>
                                    <td><%#Eval("PersonName") %></td>
                                    <td><%#Eval("PerName") %></td>
                                    <td><%#DateTime.Parse(Eval("BorrowDate").ToString()).ToShortDateString()%></td>
                                    <td><%#DateTime.Parse(Eval("ObDate").ToString()).ToShortDateString()%></td>
                                    <td>
                                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td>
                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("RecordID")%>' />
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
