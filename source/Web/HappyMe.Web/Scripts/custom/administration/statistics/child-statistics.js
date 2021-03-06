﻿var HappyMe = HappyMe || {};

HappyMe.ChildStatistics = (function (colorUtils) {
    'use strict';

    var loadWinLoseRatioStatistics = function (selector, data) {
        var context = document.getElementById(selector);
        var chart = new Chart(context, {
            data: data
        });

        return chart;
    };

    var loadAverageTimePerModuleStatistics = function (selector, data) {
        var context = document.getElementById(selector);
        var chart = new Chart(context, {
            type: 'bar',
            label: 'Test label',
            data: {
                labels: data.map(function (element) {
                    return element.moduleName;
                }),
                datasets: {
                    data: data.map(function (element) {
                        return element.averageTime;
                    }),
                    backgroundColor: colorUtils.getDistinctColors(data.length)
                }
            },
            options: {}
        });

        return chart;
    };

    var loadPlayedModuleStatistics = function (selector, data) {
        var context = document.getElementById(selector);
        var chart = new Chart(context, {
            data: data
        });

        return chart;
    };

    return {
        loadWinLoseRatioStatistics: loadWinLoseRatioStatistics,
        loadAverageTimePerModuleStatistics: loadAverageTimePerModuleStatistics,
        loadPlayedModuleStatistics: loadPlayedModuleStatistics
    };

})(HappyMe.ColorUtils);
