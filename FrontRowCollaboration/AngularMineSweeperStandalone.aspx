<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AngularMineSweeperStandalone.aspx.cs" Inherits="FrontRowCollaboration.AngularMineSweeperStandalone" %>

<!DOCTYPE html>
<html ng-app="AngularMineSweeper">


<head runat="server">
    <title>AWESOMESWEEPER</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <%--<script src="main.js"></script>--%>


    <link href="AwesomeStyleSheet.css" rel="stylesheet" />

    <ul id="Menu">
        <li><a href="MainContentPage.aspx" class="MenuButton">Home</a></li>
        <li><a href="AwesomeMineSweeper.aspx" class="MenuButton">First Minesweeper Game</a></li>
        <li><a href="AboutMineSweeper.aspx" class="MenuButton">About Minesweeper</a></li>
        <li><a href="AngularMineSweeperStandalone.aspx" class="MenuButton">Try Angular Minesweeper</a></li>
        <li><a href="WebForm6.aspx" class="MenuButton">Show Highscore</a></li>
    </ul>

    <script src="http://ajax.googleapis.com/ajax/libs/angularjs/1.2.6/angular.min.js"></script>
    <link href="AwesomeStyleSheet.css" rel="stylesheet" />


    <script>
        angular.module('AngularMineSweeper', [])
.controller('MineSweeperController', ['$scope', '$log', function ($scope, $log) {
    $scope.$log = $log;
    $scope.message = 'Hello World!';
}]);


    function createMinefield() {
        var minefield = {};
        minefield.rows = [];

        for (var i = 0; i < 9; i++) {
            var row = {};
            row.spots = [];

            for (var j = 0; j < 9; j++) {
                var spot = {};
                spot.isCovered = true;
                spot.content = "empty";
                row.spots.push(spot);
            }

            minefield.rows.push(row);
        }

        placeManyRandomMines(minefield);
        calculateAllNumbers(minefield);

        return minefield;
    }

    function getSpot(minefield, row, column) {
        return minefield.rows[row].spots[column];
    }

    function placeRandomMine(minefield) {
        var row = Math.round(Math.random() * 8);
        var column = Math.round(Math.random() * 8);
        var spot = getSpot(minefield, row, column);
        spot.content = "mine";
    }

    function placeManyRandomMines(minefield) {
        for (var i = 0; i < 10; i++) {
            placeRandomMine(minefield);
        }
    }

    function calculateNumber(minefield, row, column) {
        var thisSpot = getSpot(minefield, row, column);

        // if this spot contains a mine then we can't place a number here
        if (thisSpot.content == "mine") {
            return;
        }

        var mineCount = 0;

        // check row above if this is not the first row
        if (row > 0) {
            // check column to the left if this is not the first column
            if (column > 0) {
                // get the spot above and to the left
                var spot = getSpot(minefield, row - 1, column - 1);
                if (spot.content == "mine") {
                    mineCount++;
                }
            }

            // get the spot right above
            var spot = getSpot(minefield, row - 1, column);
            if (spot.content == "mine") {
                mineCount++;
            }

            // check column to the right if this is not the last column
            if (column < 8) {
                // get the spot above and to the right
                var spot = getSpot(minefield, row - 1, column + 1);
                if (spot.content == "mine") {
                    mineCount++;
                }
            }
        }

        // check column to the left if this is not the first column
        if (column > 0) {
            // get the spot to the left
            var spot = getSpot(minefield, row, column - 1);
            if (spot.content == "mine") {
                mineCount++;
            }
        }

        // check column to the right if this is not the last column
        if (column < 8) {
            // get the spot to the right
            var spot = getSpot(minefield, row, column + 1);
            if (spot.content == "mine") {
                mineCount++;
            }
        }

        // check row below if this is not the last row
        if (row < 8) {
            // check column to the left if this is not the first column
            if (column > 0) {
                // get the spot below and to the left
                var spot = getSpot(minefield, row + 1, column - 1);
                if (spot.content == "mine") {
                    mineCount++;
                }
            }

            // get the spot right below
            var spot = getSpot(minefield, row + 1, column);
            if (spot.content == "mine") {
                mineCount++;
            }

            // check column to the right if this is not the last column
            if (column < 8) {
                // get the spot below and to the right
                var spot = getSpot(minefield, row + 1, column + 1);
                if (spot.content == "mine") {
                    mineCount++;
                }
            }
        }

        if (mineCount > 0) {
            thisSpot.content = mineCount;
        }
    }

    function calculateAllNumbers(minefield) {
        for (var y = 0; y < 9; y++) {
            for (var x = 0; x < 9; x++) {
                calculateNumber(minefield, y, x);
            }
        }
    }

    function hasWon(minefield) {
        for (var y = 0; y < 9; y++) {
            for (var x = 0; x < 9; x++) {
                var spot = getSpot(minefield, y, x);
                if (spot.isCovered && spot.content != "mine") {
                    return false;
                }
            }
        }

        return true;
    }

    function hasLost(minefield) {
        for (var y = 0; y < 9; y++) {
            for (var x = 0; x < 9; x++) {
                var spot = getSpot(minefield, y, x);
                if (!spot.isCovered && spot.content == "mine") {
                    return true;
                }
            }
        }

        return false;
    }

    function MinesweeperController($scope) {
        $scope.minefield = createMinefield();
        $scope.uncoverSpot = function (spot) {
            spot.isCovered = false;
            if (hasWon($scope.minefield)) {
                $scope.isWinMessageVisible = true;
            }
        };
    }

    function MinesweeperController($scope) {
        $scope.minefield = createMinefield();
        $scope.uncoverSpot = function (spot) {
            spot.isCovered = false;
            if (hasLost($scope.minefield)) {
                $scope.isFailMessageVisible = true;
            }
        };
    }

    </script>
</head>
<body>
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
</body>
</html>
