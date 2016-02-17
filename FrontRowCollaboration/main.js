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














////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



//function PrintName()
//{
//    document.getElementById("test").innerHTML = "test";
//    i = 0;

//    document.getElementById("test").addEventListener('mouseover', function () {
//        if (i < 5) {
           
//            $("#test").animate({ left:  '+=250px', });
//            i++;

//        }
//        else {
//            i = 0;
//            $("#test").css("left", "0");
//        }
        
//    });
//}

var tmPromise, myApp = angular.module('cbTimer', []);

/**
 * @ngservice initService
 * @param $rootScope
 */
myApp.service('initService', function () {

    //initialize schedule list
    this.timeSchedule = {
        history: []
    };

});

/**
 *  @ngcontroller cbTimerCtrl
 *  @params  $scope, $timeout, $initService
 *  handle toggling between modes, and binding data
 */
myApp.controller('cbTimerCtrl', ['$scope', '$timeout', 'initService', function ($scope, $timeout, initService) {

    var timeStart = 0, timeEnd = 0;
    $scope.timeSchedule = initService.timeSchedule;
    $scope.mode = "Start";
    $scope.timer = "00:00:00";


    function checkTime(i) {
        i = (i < 1) ? 0 : i;
        if (i < 10) { i = "0" + i; }  // add zero in front of numbers < 10
        return i;
    }

    /**
    *  @func startTimer
    *  trigger timer to start, 
    *  recursive, call again when timer expires
    */
    function startTimer() {
        // toggle
        $scope.mode = "Stop";

        var h, m, s, ms, today = new Date();
        // compute for the duration, 
        // normalize for the user
        timeEnd = today.getTime();
        ms = Math.floor((timeEnd - timeStart) / 1000);
        h = checkTime(Math.floor(ms / 3600));
        ms = Math.floor(ms % 3600);
        m = checkTime(Math.floor(ms / 60));
        ms = Math.floor(ms % 60);
        s = checkTime(Math.floor(ms));
        // normalize time string
        $scope.timer = h + ":" + m + ":" + s;

        // timer expired, restart timer
        tmPromise = $timeout(function () {
            startTimer();
        }, 500);
    }

    /**
     * @func stopTimer
     * handle end of timer
     */
    function stopTimer() {
        // toggle
        $scope.mode = "Start";

        // stop timeout service
        $timeout.cancel(tmPromise);

        // add to history
        $scope.timeSchedule.history.push([timeStart,
                                          timeEnd,
                                          (timeEnd - timeStart) / 1000]);
    }

    /***  @func $scope.toggleTimer
     *  toggle between modes
     */
    $scope.toggleTimer = function () {

        // handle modes
        if ($scope.mode === 'Start') {
            var today = new Date();
            timeStart = today.getTime();
            startTimer();
        } else {
            stopTimer();
        }

    };


}]);



//var app = angular.module('myApp', [])

//app.controller('CountDownCtrl', ['$scope', '$timeout', function ($scope, $timeout) { // angular will inject the controller's $scope and the $timeout service
//    // todo
//}]);

//$scope.value = 0;

//// because of JS closures, $scope from the outer context will be included in countdown()'s context. 
//function countdown() {
//    $scope.value++;
//    $scope.timeout = $timeout(countdown, 1000);
//}

//$scope.start = function () {
//    countdown();
//};

//$scope.stop = function () {
//    $timeout.cancel($scope.timeout);
//};





//angular.module('stopWatchApp', [])
//.controller('stopWatchDemoCtrl', ['$scope', function ($scope) {
//    $scope.stopwatches = [{ log: [] }, { interval: 1000, log: [] }, { interval: 2000, log: [] }];
//}])
//.filter('stopwatchTime', function () {
//    return function (input) {
//        if (input) {

//            var elapsed = input.getTime();
//            var hours = parseInt(elapsed / 3600000, 10);
//            elapsed %= 3600000;
//            var mins = parseInt(elapsed / 60000, 10);
//            elapsed %= 60000;
//            var secs = parseInt(elapsed / 1000, 10);
//            var ms = elapsed % 1000;

//            return hours + ':' + mins + ':' + secs + ':' + ms;
//        }
//    };
//})
//.directive('bbStopwatch', ['StopwatchFactory', function (StopwatchFactory) {
//    return {
//        restrict: 'EA',
//        scope: true,
//        link: function (scope, elem, attrs) {

//            var stopwatchService = new StopwatchFactory(scope[attrs.options]);

//            scope.startTimer = stopwatchService.startTimer;
//            scope.stopTimer = stopwatchService.stopTimer;
//            scope.resetTimer = stopwatchService.resetTimer;

//        }
//    };
//}])
//.factory('StopwatchFactory', ['$interval', function ($interval) {

//    return function (options) {

//        var startTime = 0,
//            currentTime = null,
//            offset = 0,
//            interval = null,
//            self = this;

//        if (!options.interval) {
//            options.interval = 100;
//        }

//        options.elapsedTime = new Date(0);

//        self.running = false;

//        function pushToLog(lap) {
//            if (options.log !== undefined) {
//                options.log.push(lap);
//            }
//        }

//        self.updateTime = function () {
//            currentTime = new Date().getTime();
//            var timeElapsed = offset + (currentTime - startTime);
//            options.elapsedTime.setTime(timeElapsed);
//        };

//        self.startTimer = function () {
//            if (self.running === false) {
//                startTime = new Date().getTime();
//                interval = $interval(self.updateTime, options.interval);
//                self.running = true;
//            }
//        };

//        self.stopTimer = function () {
//            if (self.running === false) {
//                return;
//            }
//            self.updateTime();
//            offset = offset + currentTime - startTime;
//            pushToLog(currentTime - startTime);
//            $interval.cancel(interval);
//            self.running = false;
//        };

//        self.resetTimer = function () {
//            startTime = new Date().getTime();
//            options.elapsedTime.setTime(0);
//            timeElapsed = offset = 0;
//        };

//        self.cancelTimer = function () {
//            $interval.cancel(interval);
//        };

//        return self;

//    };


//}]);