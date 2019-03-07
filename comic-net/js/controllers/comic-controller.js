((app) => {
    'use strict';
    app.controller('comicController', ['$scope', 'urlFactory', 'comicFactory', ($scope, urlFactory, comicFact) => {
        $scope.comic = {};

        $scope.loadTodayComic = () => {
            comicFact.getToday()
                .then((result) => {
                    $scope.comic = result.Data;
                    $scope.$apply();
                }).catch((err) => {
                    console.error(err);
                })
        };
        var id = urlFactory.getSegment('last');
        if (id.toLowerCase() === 'index' || id === '') {
            $scope.loadTodayComic();
        }
    }]);
})(angular.module('comic'));