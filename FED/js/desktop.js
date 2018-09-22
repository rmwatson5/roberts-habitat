require.config({
    urlArgs: "bust=" + cacheBuster,
    baseUrl: "/js",
    paths: {
        "jquery" : "//code.jquery.com/jquery-3.3.1.min",
        "jquery-private": "patches/jquery.no-conflict",
        "modernizr" : "//cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min",
        "shuffle" : "//cdnjs.cloudflare.com/ajax/libs/Shuffle/3.1.1/jquery.shuffle.min",
        "theming" : "vendor/theming.min",
        "framework" : "vendor/framweorks.min"
    },
    shim: {
        "shuffle" : {
            deps: ["jquery", "modernizr"]
        },
        "theming" : {
            deps: ["jquery", "modernizr", "shuffle"]
        },
        "framework" : {
            deps: ["jquery", "modernizr", "shuffle"]
        }
    },
    map: {
    '*': {
        'jquery': 'jquery-private'
    },
        'jquery-private': {
        'jquery': 'jquery'
    }
}
});
