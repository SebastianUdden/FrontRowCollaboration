<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AwesomeMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ng-app="cbTimer">

    

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
        <asp:CheckBox ID="cbFlag" runat="server" Text="Set Flag" />
    </div>
    <br />
    <br />

    <asp:Panel ID="gameField" runat="server" Height="500px" Width="500px">
    </asp:Panel>

    <br />
    <br />
    <br />
    <div id="container" ng-controller="cbTimerCtrl">
        <div>
            <div id="clock">{{timer}}</div>
            <button id="TimerButton" onclick="return false;" ng-click="toggleTimer()">{{mode}}</button>
        </div>
        <div>
            <table>
                <thead>
                    <tr>
                        <th>Start</th>
                        <th>End</th>
                        <th>Duration (secs)</th>
                    </tr>
                </thead>
                <tbody ng-repeat="item in timeSchedule.history">
                    <tr>
                        <td>{{item[0] | date:'MM/dd/yy HH:mm:ss'}}</td>
                        <td>{{item[1] | date:'MM/dd/yy HH:mm:ss'}}</td>
                        <td>{{item[2] | number:1}}</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>

    <script src="//ajax.googleapis.com/ajax/libs/angularjs/1.3.0-rc.3/angular.min.js"></script>
    <script src="main.js"></script>

    <asp:Button ID="bStartNewGame" class="MenuButton" runat="server" OnClick="bStartNewGame_Click" Text="Start New Game" />

    <br />
    <br />

</asp:Content>
