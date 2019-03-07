((app) => {
    'use strict';
    app.factory('urlFactory', ['$http', ($http) => {
        const canonical = document.querySelector('link[rel=canonical]').href;
        return {
            base: () => {
                return canonical;
            },
            getSegment: (segment) => {
                const urlsplited = location.href.split('/');
                const segments = urlsplited.slice(3, urlsplited.length);

                if (typeof segment === 'string') {
                    if (segment === 'last') {
                        return segments[segments.length - 1];
                    }
                    if (segment === 'first') {
                        return segments[0];
                    }
                }
                if (typeof segment === 'number') {
                    if (segment < segments.length && segment >= 0) {
                        return segments[segment];
                    }
                }
                return null;
            }
        };
    }]);
})(angular.module('comic'));