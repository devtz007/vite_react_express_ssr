module.exports = {
  plugins: {
    tailwindcss: {},
    autoprefixer: {},
    precss: {},
    "postcss-preset-env": {
        stage: 1,
    },
    "postcss-import": {},

    cssnano: {
      preset: "default",
    },
  },
};
