const gulp = require('gulp');
const sass = require('gulp-sass');
const bourbon = require('node-bourbon');
const imagemin = require('gulp-imagemin');
const babel = require('gulp-babel');
const fs = require('fs');

let config;
if (fs.existsSync('./gulp-config.js.user')) {
    config = require("./gulp-config.js.user")();
}
else {
    config = require("./gulp-config.js")()
}

// FED Paths
const FED_ASSETS = "./FED/assets";
const FED_PATHS = {
    FED_SASS_SRC: [FED_ASSETS + '/sass/**/*.scss'],
    FED_JS_SRC: [FED_ASSETS + '/js/**/*.js', '!' + FED_ASSETS + '/js/vendor/**/*', '!' + FED_ASSETS + '/js/json/**/*'],
    FED_JSON_SRC: [FED_ASSETS + '/js/json/**/*'],
    FED_JS_VENDOR_SRC: [FED_ASSETS + '/js/vendor/*.js'],
    FED_SASS_DEST: FED_ASSETS + '/css/',
    FED_SPEAK_SRC: [FED_ASSETS + '/client/**/*.*'],
    FED_IMAGES_SRC: ['./FED/img/**/*']
};

// BED Paths
const BED_ASSETS = "./src/Project/code";
const BED_PATHS = {
    BED_RAZOR_SRC: BED_ASSETS + '/**/*.cshtml',
    BED_SASS_SITE_DEST: config.websiteRoot + '/css/',
    BED_JS_SITE_DEST: config.websiteRoot + '/js/',
    BED_RAZOR_SITE_DEST: config.websiteRoot,
    BED_SPEAK_SITE_DEST: config.websiteRoot + "/sitecore/shell/client/"
};

gulp.task('sassBuild', function () {
    const task = gulp.src(FED_PATHS.FED_SASS_SRC)
        .pipe(sass({
            outputStyle: 'expanded',
            includePaths: bourbon.includePaths,
            sourceComments: true
        }).on('error', sass.logError))
        .pipe(gulp.dest(FED_PATHS.FED_SASS_DEST));

    if (config.runBedBuild) {
        task.pipe(gulp.dest(BED_PATHS.BED_SASS_SITE_DEST));
    }

    return task;
});

// minifies js files
gulp.task('jsBuild', function () {
    const task = gulp.src(FED_PATHS.FED_JS_SRC)
        .pipe(gulp.dest(BED_PATHS.BED_JS_SITE_DEST));

        return task;
});

gulp.task('imagesBuild', function () {
    return gulp.src(FED_PATHS.FED_IMAGES_SRC)
        .pipe(imagemin([imagemin.jpegtran(), imagemin.optipng(), imagemin.svgo()], { verbose: true }))
        .pipe(gulp.dest(BED_PATHS.BED_IMAGES_DEST))
        .pipe(gulp.dest(BED_PATHS.BED_IMAGES_SITE_DEST));
});

gulp.task('speakBuild', function () {
    return gulp.src(FED_PATHS.FED_SPEAK_SRC)
        .pipe(gulp.dest(BED_PATHS.BED_SPEAK_SITE_DEST))
});

// copies Razor Files
gulp.task('razorBuild', function () {
    return gulp.src(BED_PATHS.BED_RAZOR_SRC)
        .pipe(gulp.dest(BED_PATHS.BED_RAZOR_SITE_DEST))
});

gulp.task('fedWatch', function () {
    gulp.watch(FED_PATHS.FED_SASS_SRC, ['sassBuild']);
    return false;
});

gulp.task('bedWatch', function () {
    gulp.watch(FED_PATHS.FED_SASS_SRC, ['sassBuild']);
    gulp.watch(FED_PATHS.FED_JS_SRC, ['jsBuild']);
    gulp.watch(BED_PATHS.BED_RAZOR_SRC, ['razorBuild']);
    gulp.watch(FED_PATHS.FED_SPEAK_SRC, ['speakBuild']);
    return false;
});

// default build task. this gets called when the user calls 'gulp'
gulp.task('image', ['imagesBuild']);
gulp.task('fed', ['fedWatch', 'sassBuild']);
gulp.task('bed', ['bedWatch', 'sassBuild', 'jsBuild', 'razorBuild', 'speakBuild']);
