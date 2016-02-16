<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <nav class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#">Front Row Collaboration Official Website</a>
                </div>
                <ul class="nav navbar-nav">
                    <li class="active"><a href="MainContentPage.aspx">Home</a></li>
                    <li><a href="AwesomeMineSweeper.aspx">Minesweeper Game</a></li>
                    <li><a href="AboutMineSweeper.aspx">About Minesweeper</a></li>
                    <li><a href="SecondMinesweeper.aspx">MineSweeper Testing</a></li>
                </ul>
            </div>
        </nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="gameField" runat="server" Height="50px" Width="50px">

    </asp:Panel>
</asp:Content>
