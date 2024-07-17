const path = require('path');
const { VueLoaderPlugin } = require('vue-loader');

module.exports = {
    entry: './wwwroot/js/main.js',
    output: {
        path: path.resolve(__dirname, './wwwroot/dist'),
        filename: 'bundle.js'
    },
    module: {
        rules: [
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            },
            {
                test: /\.js$/,
                loader: 'babel-loader',
                exclude: /node_modules/
            },
            {
                test: /\.css$/,
                use: [
                    'vue-style-loader',
                    'css-loader'
                ]
            }
        ]
    },
    resolve: {
        alias: {
            'vue$': 'vue/dist/vue.esm-bundler.js'
        },
        extensions: ['.js', '.vue', '.json']
    },
    devServer: {
        static: {
            directory: path.join(__dirname, 'wwwroot'),
        },
        hot: true
    },
    plugins: [
        new VueLoaderPlugin()
    ],
    mode: 'development'
};
