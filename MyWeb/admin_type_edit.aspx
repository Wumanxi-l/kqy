<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin_type_edit.aspx.cs" Inherits="admin_type_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
           <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="css/style1.css" />
    <link href="assets/css/codemirror.css" rel="stylesheet">
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
    <style>
        .view {
            width: 78%;
            margin-top: 20px;
            margin-bottom: 40px;
            background-color: #fff;
            padding-left: 70px;
            padding-top: 15px;
            float: left;
            margin-left: 40px;
            font-size: 17px;
        }
        .txb1 {
        margin-bottom:20px;
        }
         .yy {
             margin-top:15px;
        margin-bottom:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="view">
            <div class="lab">公司名称：<asp:TextBox ID="txb_name" runat="server" CssClass="txb1"></asp:TextBox></div>
            <p class="update-title">更改封面照片：</p>
            <div class="update-item-tp ">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="320px" Height="100px" />
                <asp:Image ID="Image1" runat="server" AlternateText="请上传照片" Width="100px" Height="100px" CssClass="imgcss" />
            </div>
            <asp:Button ID="Button2" runat="server" Text="上传"  CssClass="yy" OnClick="Button2_Click"/></br>
        <asp:Label ID="uploadimg" runat="server" Text="" CssClass="lab"></asp:Label>
            </br>
        <asp:Button ID="Button1" runat="server" Text="保存" CssClass="btn btn-warning" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
