<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AngularMineSweeper.aspx.cs" Inherits="FrontRowCollaboration.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div ng-controller="MinesweeperController">
        <label>
            Value1:
            <input type="checkbox" ng-model="checkboxModel.value1">
        </label>
        <br />
        <tt>value1 = {{checkboxModel.value1}}</tt>
        <br />


        <h1 class="BIGMESSAGE">The EPIC MineSweeper</h1>
        <h3 class="BIGMESSAGE" ng-if="isWinMessageVisible">You won!</h3>
        <table id="AngularMineSweeper" class="minefield">
            <tr ng-repeat="row in minefield.rows">
                <td ng-repeat="spot in row.spots" ng-click="uncoverSpot(spot)">
                    <img ng-if="spot.isCovered" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/covered.png" />
                    <img ng-if="!spot.isCovered && spot.content == 'empty'" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/empty.png" />
                    <img ng-if="!spot.isCovered && spot.content == 'mine'" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/mine.png" />
                    <img ng-if="!spot.isCovered && checkboxModel.value1(true)" src="https://upload.wikimedia.org/wikipedia/commons/8/83/Minesweeper_flag.svg" />
                    <img ng-if="!spot.isCovered && spot.content == 1" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-1.png" />
                    <img ng-if="!spot.isCovered && spot.content == 2" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-2.png" />
                    <img ng-if="!spot.isCovered && spot.content == 3" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-3.png" />
                    <img ng-if="!spot.isCovered && spot.content == 4" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-4.png" />
                    <img ng-if="!spot.isCovered && spot.content == 5" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-5.png" />
                    <img ng-if="!spot.isCovered && spot.content == 6" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-6.png" />
                    <img ng-if="!spot.isCovered && spot.content == 7" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-7.png" />
                    <img ng-if="!spot.isCovered && spot.content == 8" src="http://luis-perez.s3-us-west-2.amazonaws.com/angularjs-minesweeper-game/number-8.png" />
                </td>
            </tr>
        </table>
        <h1 class="BIGMESSAGE" ng-if="isFailMessageVisible">You lose!</h1>
        <br />
        <br />
        <br />
    </div>
    <h1 class="BIGMESSAGE">made in AngularJS</h1>
</asp:Content>
