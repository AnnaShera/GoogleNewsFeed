<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RssFeedForm.aspx.cs" Inherits="GoogleNews.RssFeedForm" %>
<%@ Import Namespace="System.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">     
     <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
      <script src="Actions.js" type="text/javascript"></script>
      <link rel="stylesheet" type="text/css" href="stylesheet.css" />
    <title>Rss Feed</title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Google News</h1>
    <div id ="left">
    <h2>Topics</h2>
       <asp:Repeater ID="RssRepeater" runat="server">
        <ItemTemplate>
            <a class="linkToData" href="#"  onclick="extrect(<%# Eval("id")%> );return false;">
            <strong> <%# Eval("title") %> </strong></a>
            <br />  <br />
        </ItemTemplate>
        </asp:Repeater>          
    </div>
        <div id="right">
            <h2>Posts</h2>
            <div id="upper">
            </div>
        </div>
    </form>
</body>
</html>
