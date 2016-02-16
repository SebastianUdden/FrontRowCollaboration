<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <div class="navbar-header">
                    <a class="navbar-brand" href="#">Front Row Collaboration Official Website</a>
                </div>
                <ul class="nav navbar-nav">
                    <li class="active"><a href="MainContentPage.aspx">Home</a></li>
                    <li><a href="MineSweeper.aspx">Minesweeper Game</a></li>
                    <li><a href="AboutMineSweeper.aspx">About Minesweeper</a></li>
                    <li><a href="#">A map</a></li>
                </ul>
            </div>
        </nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is the minesweeper page</h1>
</asp:Content>
