((app) => {
    'use strict';
    app.factory('comicFactory', ['$http', 'urlFactory', ($http, urlf) => {
        return {
            getToday: () => {
                return new Promise((resolve, reject) => {
                    $http.get(urlf.base()+'Comic/Today')
                        .then((response) => {
                            if (response.data.Success)
                                resolve(response.data);
                            else
                                reject(response.data);
                        }, (err) => {
                            reject(err);
                        });
                });
            },
            getByNum: (num) => {
                return new Promise((resolve, reject) => {
                    $http.get(urlf.base() + `Comic/Comic/${num}`)
                        .then((response) => {
                            if (response.data.Success)
                                resolve(response.data);
                            else
                                reject(response.data);
                        }, (err) => {
                            reject(err);
                        });
                });
            }
        };
    }]);
})(angular.module('comic'));