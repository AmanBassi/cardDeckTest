var app = angular.module('carDeckTestApp', []);

app.controller('carDeckTestApp', function ($scope, $http) {

    $scope.deck = [];
    $scope.deck.cards = [];
    $scope.hand = [];

    $scope.createDeck = function () {
        $scope.deck.cards = [];
        $http.get("/Home/CreateDeck").then(function (response) {
            $scope.deck = response.data;
        });
    }

    $scope.drawCard = function () {
        if ($scope.deck.cards.length > 0) {
            var popped = $scope.deck.cards.pop();
            $scope.hand.push(popped);
        }
    };

    $scope.sortHand = function () {
        $scope.hand.sort(orderByProperty('Suit', 'Rank'));
    }

    $scope.resetHandAndDeck = function () {
        $scope.hand = [];
        $scope.createDeck();
    }

    $scope.createDeck();
});

function orderByProperty(prop) {
    var args = Array.prototype.slice.call(arguments, 1);
    return function (a, b) {
        var equality = a[prop] - b[prop];
        if (equality === 0 && arguments.length > 1) {
            return orderByProperty.apply(null, args)(a, b);
        }
        return equality;
    };
}