module.exports = function () {
    var instanceRoot = "C:\\inetpub\\wwwroot\\RobertsHabitat";
    var config = {
        websiteRoot: instanceRoot,
        sitecoreLibraries: instanceRoot + "\\bin",
        runBedBuild: true
    };
    return config;
}
