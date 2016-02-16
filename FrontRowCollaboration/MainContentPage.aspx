<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="MainContentPage.aspx.cs" Inherits="FrontRowCollaboration.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <div class="navbar-header">
                <a class="navbar-brand" href="#">Front Row Collaboration Official Website</a>
            </div>
            <ul class="nav navbar-nav">
                <li class="active"><a href="#">Home</a></li>
                <li><a href="#">Usless Information</a></li>
                <li><a href="#">Link to google</a></li>
                <li><a href="#">A map</a></li>
            </ul>
        </div>
    </nav>

    <p>Här är flaggbilden</p>
    <img src="flag.svg.png" />
     
    <input type="text" ng-model="textblock"/>

    <h1>This is the AngularJS connection: {{textblock}}</h1>
    <p id="test">Click here</p>
    <!--This is the aside-->

    <br />
    <br />
    <br />
    <aside>The ASIDE</aside>

    <!--This is the footer-->
    <footer>The FOOTER</footer>

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
    <button id="theBIGASSButton" style="width:20em; height:20em;" onclick="shitScript();"></button>
</asp:Content>
