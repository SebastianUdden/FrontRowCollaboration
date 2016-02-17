<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ng-app="cbTimer">
    

    <%--<br />

      <body ng-controller="CountDownCtrl">

    {{value}}

    <button ng-click="start()">Start</button>
    <button ng-click="stop()">Stop</button>    
  </body>--%>


    <%--<div data-ng-app="stopWatchApp" data-ng-controller="stopWatchDemoCtrl">

        <div data-ng-repeat="options in stopwatches">
            <div bb-stopwatch options="options">
                <div class="container">
                    <div class="stopWatch numbers">
                        {{options.elapsedTime | stopwatchTime}}
                    </div>
                    <button class="btn" ng-click="startTimer()">Start</button>
                    <button class="btn" ng-click="stopTimer()">Stop</button>
                    <button class="btn" ng-click="resetTimer()">Reset</button>
                </div>
            </div>
            <div class="log" ng-repeat="log in options.log">
                {{log/1000}} seconds
            </div>
        </div>
    </div>--%>
    <br />
    <br />
    <br />
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
