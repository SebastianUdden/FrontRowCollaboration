<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AboutMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm3" %>

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
        
        <h1>Övning Extra 2 – ASP.NET Minesweep</h1>

        <p> Det klassiska minröjningspelet ska byggas i ASP.NET. Spelet ska köras av en spelare. Antal klick ska
        sparas i en databas för att kunna presentera en highscoretabell. En spelplan ska ha 10*10 rutor och 5
        minor ska slumpas ut på spelplanen.</p>

        <h1>Spelets gång</h1>
        <p>Klickar man på en ruta som inte innehåller en mina ska denna och intilliggande tomma rutor rensas.
        Rutor som gränsar till eller innehåller en eller flera minor ska inte rensas. I rutor som gränsar till en
        mina ska antalet minor den angränsar till skrivas ut. Ett högerklick ska markera att rutan innehåller
        en mina. Spelet är vunnet när alla minor är markerade och samtliga tomma rutor rensade.
        Exempel på spel.</p>

        <h2>Extra</h2>
        <p>Man ska kunna spara spel för att senare kunna fortsätta.</p>

        <h2>Extra</h2>
        <p>Vid start av spel ska svårighetsgrad kunna väljas. Easy – 5 minor, medium – 7 minor, hard – 10 minor.
        Separata highscoretabeller ska redovisas.</p>

        <h2>Extra</h2>
        <p>Naturligtvis ska spelet fungera lika bra i en mobil. Använd Bootstrap eller jQuery mobile för att
        anpassa spelplanen efter detta.</p>

</asp:Content>
