@import url(https://fonts.googleapis.com/css?family=Lato:400,300,700);
body {
  -webkit-text-size-adjust: 100%;
  font-family: 'Lato', sans-serif;
  text-rendering: optimizeLegibility;
  -webkit-font-smoothing: antialiased;
}

input {
  -webkit-appearance: none;
}

*, *:after, *:before {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

a {
  text-decoration: none;
}

.pen-description {
  margin: 60px 0;
  text-align: center;
}
.pen-description .summary {
  margin-bottom: 10px;
}
.pen-description .note {
  color: #555;
  font-size: .85rem;
}

html, body {
  min-height: 100%;
}

body {
  background-image: url('data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4gPHN2ZyB2ZXJzaW9uPSIxLjEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyI+PGRlZnM+PGxpbmVhckdyYWRpZW50IGlkPSJncmFkIiBncmFkaWVudFVuaXRzPSJvYmplY3RCb3VuZGluZ0JveCIgeDE9IjAuMCIgeTE9IjEuMCIgeDI9IjEuMCIgeTI9IjAuMCI+PHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0iIzJhMmY2NiIvPjxzdG9wIG9mZnNldD0iMTAwJSIgc3RvcC1jb2xvcj0iIzc4YjRiYSIvPjwvbGluZWFyR3JhZGllbnQ+PC9kZWZzPjxyZWN0IHg9IjAiIHk9IjAiIHdpZHRoPSIxMDAlIiBoZWlnaHQ9IjEwMCUiIGZpbGw9InVybCgjZ3JhZCkiIC8+PC9zdmc+IA==');
  background-size: 100%;
  background-image: linear-gradient(to right top, #2a2f66 0%, #78b4ba 100%);
  display: flex;
}

li {
  list-style: none;
  position:   relative;
}

.container {
  margin: auto;
  margin-top: 50px;
  min-width: 400px;
  width: 1400px;
  display: flex;
  align-items: flex-start;
}

.col {
  background-color: rgba(202, 206, 213, 0.8);
  float: left;
  margin: 10px;
  border-radius: 5px;
  flex-basis: auto;
  flex-grow: 1;
  flex: 1;
  min-width: 200px;
  transition: all 0.2s ease-in-out;
}
.col:hover {
  background-color: rgba(202, 206, 213, 0.95);
}

.card {
  background-color: #fff;
  border-radius: 4px;
  cursor: pointer;
  margin: 15px;
  transition: all 0.3s ease-in-out;
  line-height: 1.5rem;
  box-shadow: 0 1px #aaa;
}
.card div {
  padding: 15px;
}
.card.tile:hover {
  box-shadow: 0 3px 20px rgba(35, 47, 52, 0.3);
}

.edit {
  border-radius: 5px;
  padding: 15px;
  width: 98%;
}

.column-wrapper {
  min-height: 40px;
}

.clearfix:after {
  content: " ";
  display: block;
  clear: both;
}

.list-name {
  color: #1C2640;
  font-size: .9rem;
  font-weight: bold;
  padding: 15px;
}

.add {
  display: block;
  background: none;
  box-shadow: none;
  color: rgba(51, 51, 51, 0.7);
  padding-bottom: 0;
  padding-left: 0;
  padding-top: 0;
}
.add:hover {
  color: #333;
  box-shadow: none;
}

.no-tile:hover {
  box-shadow: none;
}

textarea {
  outline: 0 none;
  font-family: 'Lato';
  font-size: 1rem;
  line-height: 1.5rem;
  -webkit-appearance: none;
  resize: vertical;
  min-height: 36px;
  border: 0 none;
  box-shadow: none;
  width: 100%;
}

.save {
  display: none;
  text-align: center;
  padding: 10px 15px;
  color: #fff;
  background-color: rebeccapurple;
  border-radius: 5px;
  float: right;
  margin: 15px;
}

.save-edit {
  text-align: center;
  padding: 10px 15px;
  color: #fff;
  background-color: rebeccapurple;
  border-radius: 5px;
  display: table;
  margin: 15px;
  top: -15px;
  position: absolute;
  right: -90px;
  z-index: 100;
}

.cancel {
  display: none;
  color: #777;
  padding: 15px;
  margin-top: 10px;
  float: right;
  transition: color 0.2s ease-in-out;
}
.cancel:hover {
  color: #555;
}

.disabled {
  opacity: .5;
  cursor: default;
}

.js-remove {
  padding: 10px;
  display: none;
  cursor: pointer;
  color: #c00;
  top: 0;
  bottom: 0;
  margin: auto;
  right: 5px;
  position: absolute;
  font-style: normal;
  z-index: 5;
}
.js-remove:hover {
  color: #990000;
  text-shadow: 0 0 15px #cc0000;
}

#col_4 li {
  padding-left: 20px;
  position: relative;
}
#col_4 li .save-edit {
  left: -90px;
}
#col_4 li:before {
  content: "\f00c";
  font-family: 'FontAwesome';
  color: #50B948;
  margin-right: 10px;
  position: absolute;
  left: 10px;
  margin-top: 15px;
}

.mute {
  opacity: .2;
}

.add {
  padding: 15px;
}

.card:not(.no-tile):hover i {
  display: table;
}

.card.remove:hover i {
  display: none;
}
