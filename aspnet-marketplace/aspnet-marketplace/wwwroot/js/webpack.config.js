const path = require("path");

module.exports = {
  entry: "./React/index.js",
  output: {
    filename: "Bundle.js",
    path: path.resolve(__dirname, "dist"),
  },
  module: {
    rules: [{ test: /\.js$/, use: "babel-loader" }],
  },
  optimization: {
    minimize: false,
  },
};
