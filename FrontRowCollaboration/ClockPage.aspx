<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClockPage.aspx.cs" Inherits="FrontRowCollaboration.ClockPage" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Timer using Angular</title>
    <link rel="stylesheet" type="text/css" href="AwesomeStyleSheet.css" />

</head>
<body ng-app="cbTimer">
    <div id="container" ng-controller="cbTimerCtrl">
        <div>
            <div id="clock">{{timer}}</div>
            <%--<input type="button" onclick="toggleTimer()" text="start"/>--%>
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
</body>
</html>

