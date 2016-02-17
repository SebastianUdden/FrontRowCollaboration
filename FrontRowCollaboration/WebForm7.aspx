<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="FrontRowCollaboration.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ng-app="cbTimer">
    <div id="container" ng-controller="cbTimerCtrl">
                <div>
                    <div id="clock">{{timer}}</div>
                    <button onclick="return false;" ng-click="toggleTimer()">{{mode}}</button>
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
</asp:Content>
