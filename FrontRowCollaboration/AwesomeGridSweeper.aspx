<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeGridSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="bStartGame" runat="server" OnClick="bStartGame_Click" Text="Start New Game" Width="169px" />
    <br />
    <asp:TextBox ID="txGridSize" runat="server" Width="54px">7</asp:TextBox>
    <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="gameUpdatePanel" runat="server">
        <ContentTemplate>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Visible="False" />
            <br />
            <asp:Panel ID="gameField" runat="server">
                
                <br />
            </asp:Panel>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
