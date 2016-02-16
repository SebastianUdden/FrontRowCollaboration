<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="MainContentPage.aspx.cs" Inherits="FrontRowCollaboration.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <img src="flag.svg.png" />

    <input type="text" ng-model="textblock" />
    <img src="Pictures/mine.jpg" />
    <img src="Pictures/76px-Minesweeper_questionmark.svg.png" />
    <img src="Pictures/Clicked_MineSweeper.png" />
    <img src="Pictures/NotClicked_MineSweeper.png" />
    <img src="Pictures/76px-Minesweeper_flag.svg.png" />
    <img src="Pictures/76px-Minesweeper_2.svg.png" />
    <img src="Pictures/76px-Minesweeper_1.svg.png" />
    <p>Mine URL = http://media2.androidappsgame.com/1/214881/com-jipsaan-minesweeper-214881.jpg </p>
    <p>Flag URL = https://upload.wikimedia.org/wikipedia/commons/8/83/Minesweeper_flag.svg </p>
    <p>Questionmark URL = https://upload.wikimedia.org/wikipedia/commons/e/e1/Minesweeper_questionmark.svg </p>
    <p>Opened square URL = https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/Minesweeper_0.svg/76px-Minesweeper_0.svg.png </p>
    <p>1 square URL = https://upload.wikimedia.org/wikipedia/commons/c/ca/Minesweeper_1.svg </p>
    <p>2 square URL = https://upload.wikimedia.org/wikipedia/commons/4/44/Minesweeper_2.svg </p>
    <p>Unopened square URL = https://upload.wikimedia.org/wikipedia/commons/c/c7/Minesweeper_unopened_square.svg </p>
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
</asp:Content>
