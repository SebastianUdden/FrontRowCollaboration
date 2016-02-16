<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <ul id="Menu">
        <li><a href="MainContentPage.aspx" class="MenuButton" >Home</a></li>
        <li><a href="AwesomeMineSweeper.aspx" class="MenuButton">Minesweeper Game</a></li>
        <li><a href="AboutMineSweeper.aspx" class="MenuButton">About Minesweeper</a></li>
        <li><a href="SecondMinesweeper.aspx" class="MenuButton">MineSweeper Testing</a></li>
    </ul>
    <br />
    <img src="mine.jpg" />
    <img src="flag.svg.png" />
    <ul id="DifficultyMenu">
        <input type="button" value="Button" />
        <a href="#" class="MenuButton">Easy</a>
        <a href="#" class="MenuButton">Medium</a>
        <a href="#" class="MenuButton">Hard</a>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="gameField" runat="server" Height="50px" Width="50px">

    </asp:Panel>
    <asp:Button ID="bStartNewGame" runat="server" OnClick="bStartNewGame_Click" Text="Start New Game" />
    </asp:Content>
