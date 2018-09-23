require.config({
    urlArgs: "bust=" + cacheBuster,
    baseUrl: "/js",
    paths: {
        "jquery" : "//code.jquery.com/jquery-3.3.1.min",
        "jquery-private": "patches/jquery.no-conflict",
    },
    shim: {
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
