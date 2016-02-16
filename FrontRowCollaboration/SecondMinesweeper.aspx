<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="SecondMinesweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is the testing ground</h1>


<%--    <asp:GridView ID="GridView1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataSourceID="highscore" ForeColor="Black" GridLines="None">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Namn" />
            <asp:BoundField DataField="score" HeaderText="Poäng" />
        </Columns>
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>--%>
    <asp:XmlDataSource ID="highscore" runat="server" DataFile="~/highscore.xml"></asp:XmlDataSource>

        <asp:GridView ID="GridView3" CssClass="table" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="name" />
            <asp:BoundField DataField="score" HeaderText="score" />
        </Columns>
    </asp:GridView>

</asp:Content>
