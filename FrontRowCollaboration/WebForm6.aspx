<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="FrontRowCollaboration.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="GridView1" CssClass="table" runat="server" AutoGenerateColumns="false">
        <columns>
            <asp:BoundField DataField="name" HeaderText="name" />
            <asp:BoundField DataField="score" HeaderText="score" />
        </columns>
    </asp:GridView>
</asp:Content>
