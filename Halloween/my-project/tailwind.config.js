module.exports = {
  content: ["./index.html", "./src/**/*.{vue,js,ts,jsx,tsx}"],
  theme: {
    container:{
      center:true,
      padding:{
        default:'1rem',
        sm:'3rem',
        lg:'6rem',
      },
    },
    extend: {
      colors: {
        primary: {
          100: "#06C2AE",
          200: "#02889B",
        },
        secondary: "#FF693A",
      },
    },
  },
  plugins: [],
};
