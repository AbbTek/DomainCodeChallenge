(function () {
    'use strict';

    angular
		.module('domain.matcher',
		[
		'domain.core',
        'uiGmapgoogle-maps'
		])
    	.config(function (uiGmapGoogleMapApiProvider) {
    		uiGmapGoogleMapApiProvider.configure({
    		    //    key: 'your api key',
    		    v: '3.23', //defaults to latest 3.X anyhow
    		    libraries: ''
    		});
    	});
})();