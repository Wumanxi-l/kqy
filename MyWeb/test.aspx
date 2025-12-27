<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
                transform: translateX(100%);
            }

            to {
                transform: translateX(-100%);
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
        <div id="scrollingContainer">
            <div id="scrollingContent">
                <div class="scrollingItem">Item 1</div>
            
            </div>
        </div>
    </form>
</body>
</html>
