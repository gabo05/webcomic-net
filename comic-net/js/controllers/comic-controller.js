((app) => {
    'use strict';
    app.controller('comicController', ['$scope', 'urlFactory', 'comicFactory', ($scope, urlFactory, comicFact) => {
        $scope.comic = {};
        $scope.last = 0;
        $scope.loadTodayComic = () => {
            comicFact.getToday()
                .then((result) => {
                    $scope.comic = result.Data;
                    $scope.last = result.Data.num;
                    $scope.$apply();
                }).catch((err) => {
                    console.error(err);
                })
        };
        $scope.loadComicByNum = (num) => {
            comicFact.getByNum(num)
                .then((result) => {
                    $scope.comic = result.Data;
                    $scope.last = parseInt(result.Message);
                    const newurl = `${urlFactory.base()}comic/${$scope.comic.num}`
                    window.history.pushState('object', 'Comic #' + $scope.comic.num, newurl);
                    $scope.$apply();
                }).catch((err) => {
                    console.error(err);
                })
        };
        const id = urlFactory.getSegment('last');

        if (id.toLowerCase() === 'index' || id === '') {
            $scope.loadTodayComic();
        }
        const iid = parseInt(id);

        if (!isNaN(iid)) {
            $scope.loadComicByNum(iid);
        }

        $scope.previous = (e) => {
            e.preventDefault();
            if ($scope.comic.num > 1) {
                $scope.loadComicByNum($scope.comic.num - 1);
            }
        };
        $scope.next = (e) => {
            e.preventDefault();
            if ($scope.comic.num < $scope.last) {
                $scope.loadComicByNum($scope.comic.num + 1);
            }
        };
    }]);
})(angular.module('comic'));