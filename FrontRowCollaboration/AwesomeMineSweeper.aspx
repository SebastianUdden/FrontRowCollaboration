<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br /> 

    <div id="difficultyButtons">
            <label>
            <input type="radio" runat="server" id="rbEasy" class="sepButton" name="difficulty" />
                <span class="overlay">Easy</span></label>
            <label>
            <input type="radio" runat="server" id="rbMedium" class="sepButton" name="difficulty" />
                <span class="overlay">Medium</span></label>
            <label>
            <input type="radio" runat="server" id="rbHard" class="sepButton" name="difficulty" />
                <span class="overlay">Hard</span></label>
            <asp:CheckBox ID="cbFlag" runat="server" Text="Set Flag" />
        </div>
    <br />
    <br />

    <asp:Panel ID="gameField" runat="server" Height="500px" Width="500px">
    </asp:Panel>

    <br />
    <br />
     <br /> 
    <asp:Button ID="bStartNewGame" class="MenuButton" runat="server" OnClick="bStartNewGame_Click" Text="Start New Game" />
    
    <br />
    <br />
</asp:Content>
