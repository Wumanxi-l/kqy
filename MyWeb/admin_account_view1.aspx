<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_account_view1.aspx.cs" Inherits="admin_account_view1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
</head>
<body>
    <form id="form1" runat="server">
           <div class="margin clearfix">
            <div class="border clearfix">
                <span class="l_f">
   
                </span>

            </div>
            <div class="compete_list">
                <table id="sample-table-1" class="table table-striped table-bordered table-hover">
                    <thead>
                        <tr>
                            <th class="center">选择</th>
                            <th>编号</th>
                            <th>用户名</th>
                            <th>密码</th>
                            <th class="hidden-480">操作</th>
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
                                    <td><%#Eval("UserId") %></td>
                                    <td><%#Eval("UserName") %></td>
                                    <td><%#Eval("UserPwd") %>
                                    </td>
                                    <td>
                                        <a title="编辑" href="admin_Edit_Account.aspx?UserId=<%#Eval("UserId") %>&&Count=<%#Container.ItemIndex + 1%>" class=" btn btn-xs btn-info"><i class="fa fa-edit bigger-120"></i></a>
                                    </td>
                                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("UserId")%>' />
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
