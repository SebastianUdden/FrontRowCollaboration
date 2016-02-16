<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <br />
    <br />

    <ul div="DifficultyMenu">
        <a href="#" class="MenuButton" onclick="EasyMode()">Easy</a>
        <a href="#" class="MenuButton">Medium</a>
        <a href="#" class="MenuButton">Hard</a>
    </ul>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="gameField" runat="server" Height="50px" Width="50px">
    </asp:Panel>
    <asp:Button ID="bStartNewGame" runat="server" OnClick="bStartNewGame_Click" Text="Start New Game" />
    </asp:Content>
