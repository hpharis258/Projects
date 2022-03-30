import Player from './player.js';
let canvas = document.getElementById("gameScreen");

let con = canvas.getContext("2d"); //Context

let gameWidth = canvas.width;
let gameHeight = canvas.width;

con.fillStyle = '#f00';
con.fillRect(20,70, 20, 20);
/*
con.fillRect(250, 0, 20, 200);
con.clearRect(250, 0, 1, 200)
*/

let player1 = new Player(gameWidth, gameHeight);

player1.draw;
alert(gameHeight);