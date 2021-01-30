'use strict';

var gulp = require('gulp'),
    concat = require('gulp-concat'),
    cssmin = require('gulp-cssmin'),
    htmlmin = require('gulp-htmlmin'),
    uglify = require('gulp-uglify'),
    merge = require('merge-stream'),
    del = require('del'),
    replace = require('gulp-replace'),
    bundleconfig = require('./bundleconfig.json');

const regex = {
    css: /\.css$/,
    html: /\.(html|htm)$/,
    js: /\.js$/
};

gulp.task('min:js', async function () {
    merge(getBundles(regex.js).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(uglify())
            .pipe(gulp.dest('.'));
    }))
});

gulp.task('min:copyfonts', async function () {
    return gulp.src(['wwwroot/assets/vendor/icon-line/fonts/*.{ttf,woff,eof,svg,eot,html}',
        'wwwroot/assets/vendor/icon-hs/fonts/*.{ttf,woff,eof,svg,eot,html}',
        'wwwroot/assets/vendor/icon-etlinefont/fonts/*.{ttf,woff,eof,svg,eot,html}',
        'wwwroot/assets/vendor/icon-awesome/fonts/*.{ttf,woff,eof,svg,eot,html}',
        'wwwroot/assets/vendor/icon-line-pro/**/*.{ttf,woff,eof,svg,eot,html}',
    ])
        .pipe(gulp.dest('wwwroot/css/fonts'));
});
var options = {
    searchValue: 'string'
};
gulp.task('min:replace', async function () {
    gulp.src(['wwwroot/css/icon.min.css'])
        .pipe(replace('../fonts/Simple-Line-Iconsb26c-2.html', 'fonts/Simple-Line-Iconsb26c-2.html'), options)
        .pipe(replace('../fonts/fontawesome-webfont3e6e.html', 'fonts/fontawesome-webfont3e6e.html'), options)
        .pipe(replace('../fonts/Simple-Line-Iconsb26c.html', 'fonts/Simple-Line-Iconsb26c.html'), options)
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('min:iconproreplace', async function () {
    gulp.src(['wwwroot/assets/vendor/icon-line-pro/style.css'])
        .pipe(replace('url("', 'url("fonts/'))
        .pipe(gulp.dest('wwwroot/css/icon-pro'));
});
gulp.task('min:css', async function () {
    merge(getBundles(regex.css).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(cssmin())
            .pipe(gulp.dest('.'));
    }))
});

gulp.task('min:html', async function () {
    merge(getBundles(regex.html).map(bundle => {
        return gulp.src(bundle.inputFiles, { base: '.' })
            .pipe(concat(bundle.outputFileName))
            .pipe(htmlmin({ collapseWhitespace: true, minifyCSS: true, minifyJS: true }))
            .pipe(gulp.dest('.'));
    }))
});

gulp.task('min', gulp.series(['min:js', 'min:css', 'min:html', 'min:copyfonts']));
gulp.task('replacepath', gulp.series(['min:replace']));
gulp.task('iconproreplace', gulp.series(['min:iconproreplace']));

gulp.task('clean', () => {
    return del(bundleconfig.map(bundle => bundle.outputFileName));
});

gulp.task('watch', () => {
    getBundles(regex.js).forEach(
        bundle => gulp.watch(bundle.inputFiles, gulp.series(["min:js"])));

    getBundles(regex.css).forEach(
        bundle => gulp.watch(bundle.inputFiles, gulp.series(["min:css"])));

    getBundles(regex.html).forEach(
        bundle => gulp.watch(bundle.inputFiles, gulp.series(['min:html'])));
});

const getBundles = (regexPattern) => {
    return bundleconfig.filter(bundle => {
        return regexPattern.test(bundle.outputFileName);
    });
};

gulp.task('default', gulp.series("min"), gulp.series("replacepath"));