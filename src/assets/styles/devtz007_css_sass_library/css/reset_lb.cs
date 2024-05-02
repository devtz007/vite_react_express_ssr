


/*------------------------------------*/
/* RESET                              */
/*------------------------------------*/
/* Resetting font-family, text size adjustment, font smoothing, and tap highlight color for HTML */
html {
  font-family: Arial, Helvetica, sans-serif;
  -webkit-text-size-adjust: 100%;
  -webkit-font-smoothing: antialiased;
  -webkit-tap-highlight-color: transparent;
  font-size: 16px;
  -webkit-box-sizing: border-box;
          box-sizing: border-box;
}


/* Resetting margin, padding, border, outline, font-size, font, vertical-align, and line-height for all elements */
html,
body,
div,
section,
span,
applet,
object,
iframe,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
p,
blockquote,
pre,
abbr,
acronym,
address,
big,
cite,
code,
del,
dfn,
em,
img,
ins,
kbd,
q,
s,
samp,
small,
strike,
strong,
sub,
sup,
tt,
var,
b,
u,
i,
center,
dl,
dt,
dd,
ol,
ul,
li,
fieldset,
form,
label,
legend,
table,
caption,
tbody,
tfoot,
thead,
tr,
th,
td,
article,
aside,
canvas,
details,
figcaption,
figure,
footer,
header,
hgroup,
menu,
nav,
section,
summary,
time,
mark,
audio,
video,
button,
a {
  margin: 0;
  padding: 0;
  border: none;
  outline: none;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline;
  line-height: normal;
}

/* Resetting font-size and font-weight for heading elements */
h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/* Resetting list-style for ordered and unordered lists */
ol,
ul {
  list-style: none;
}

/* Setting display and vertical alignment for certain media elements */
img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  vertical-align: middle;
}

/* Setting maximum width for images and videos to prevent overflow */
img,
video {
  max-width: 100%;
  height: auto;
}

/* Inheriting box-sizing and font-smoothing, setting word-break and word-wrap properties */
*,
*::before,
*::after {
  -webkit-box-sizing: inherit;
          box-sizing: inherit;
  -webkit-font-smoothing: antialiased;
  word-break: break-word;
  word-wrap: break-word;
  border-width: 0;
  border-style: solid;
}

/* Setting styles for buttons and links */
button,
a {
  cursor: pointer;
  text-decoration: none;
  font-style: normal;
  font-weight: normal;
  color: blue;
  text-transform: none;
  border-right-width: 0px;
  border-left-width: 0px;
  border-top-width: 0px;
  border-bottom-width: 0px;
}

/* Removing default focus outline for buttons and links */
button:focus,
a:focus {
  outline: none;
}

/* Setting display property for semantic elements */
article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
menu,
nav,
section {
  display: block;
}

/* Setting default line-height for body */
body {
  line-height: 1;
}

/* Removing default quotes for blockquote and q elements */
blockquote,
q {
  quotes: none;
}
blockquote:before,
blockquote:after,
q:before,
q:after {
  content: ’’;
  content: none;
}

/* Removing default text-decoration for inserted elements */
ins {
  text-decoration: none;
}

/* Setting text-decoration for deleted elements */
del {
  text-decoration: line-through;
}

/* Resetting table border properties */
table {
  border-collapse: collapse;
  border-spacing: 0;
}


/* This section provides styles for date picker input */

/* Styling date picker input fields */
input[type="date"]::-webkit-datetime-edit {
  padding: 0;
}
input[type="date"]::-webkit-datetime-edit-fields-wrapper {
  background-color: none;
}
input[type="date"]::-webkit-datetime-edit-text {
  color: inherit;
  padding: 0 0.45em;
}

/* Styling month field */
input[type="date"]::-webkit-datetime-edit-month-field {
  color: inherit;
  text-transform: uppercase;
}

/* Styling day field */
input[type="date"]::-webkit-datetime-edit-day-field {
  color: inherit;
  text-transform: uppercase;
}

/* Styling year field */
input[type="date"]::-webkit-datetime-edit-year-field {
  color: inherit;
  text-transform: uppercase;
}

/* Hiding inner spin button */
input[type="date"]::-webkit-inner-spin-button {
  display: none;
}

/* Styling calendar picker indicator */
input[type="date"]::-webkit-calendar-picker-indicator {
  height: 10px;
  cursor: pointer;
  border-radius: 4px;
  margin-right: 0px;
  opacity: 0.5;

  /* Applying filters for visual effects */
  -webkit-filter: invert(39%) sepia(85%) saturate(5644%) hue-rotate(206deg) brightness(106%) contrast(101%);
  filter: invert(39%) sepia(85%) saturate(5644%) hue-rotate(206deg) brightness(106%) contrast(101%);
}

/* Hover effect for calendar picker indicator */
input[type="date"]::-webkit-calendar-picker-indicator:hover {
  opacity: 1;
}


/*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*\
  devtz007
\*++++++++++++++++++++++++++++++++++++*/
