<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <ul id="Menu">
        <li><a href="MainContentPage.aspx" class="MenuButton" >Home</a></li>
        <li><a href="AwesomeMineSweeper.aspx" class="MenuButton">Minesweeper Game</a></li>
        <li><a href="AboutMineSweeper.aspx" class="MenuButton">About Minesweeper</a></li>
        <li><a href="SecondMinesweeper.aspx" class="MenuButton">MineSweeper Testing</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="gameField" runat="server" Height="50px" Width="50px">

    </asp:Panel>
    <asp:Button ID="Button1" runat="server" Height="50px" OnClick="Button1_Click" Text="testbutton" Width="100px" />
</asp:Content>
