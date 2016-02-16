<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="MainContentPage.aspx.cs" Inherits="FrontRowCollaboration.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <ul id="Menu">
        <li><a href="MainContentPage.aspx" class="MenuButton" >Home</a></li>
        <li><a href="AwesomeMineSweeper.aspx" class="MenuButton">Minesweeper Game</a></li>
        <li><a href="AboutMineSweeper.aspx" class="MenuButton">About Minesweeper</a></li>
        <li><a href="SecondMinesweeper.aspx" class="MenuButton">MineSweeper Testing</a></li>
    </ul>

<%--    <%--<nav class="navbar navbar-default">--%>
    <%--<div class="container-fluid">--%>
    <%--<div class="navbar-header">
                    <a class="navbar-brand" href="#">Front Row Collaboration Official Website</a>--%>
    <%--</div>--%>
    <%--<ul class="nav navbar-nav">--%>
    
    <%--</ul>--%>
    <%--</div>--%>
    <%--</nav>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <img src="flag.svg.png" />

    <input type="text" ng-model="textblock" />

    <h3>AngularJS connection: {{textblock}}</h3>
    <p id="test">Click here</p>
    <!--This is the aside-->

    <br />
    <br />
    <br />
    <aside>The ASIDE</aside>


    <!--AngularJS-link-->
    <script src="angular.min.js"></script>

    <script>
        var x = 10;
        var y = 5;

        function shitScript() {
            for (var i = 0; i < x; i++) {
                alert("skiten funkar", i);
            }
        }

    </script>
    <button id="theBIGASSButton" style="width: 100%; height: 20em;" onclick="shitScript();"></button>
    
    <!--This is the footer-->
    <footer>The FOOTER</footer>
</asp:Content>
