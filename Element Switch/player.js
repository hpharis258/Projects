export default 
class Player {
    constructor(gameWidth, gameHeight){
        this.width = 20;
        this.height = 230;

        this.position = {
            x: gameWidth / 2 - this.width / 2,
            y: gameHeight - this.height - 10,
        }
    }
    

    draw(con){
        con.fillRect(this.position.x, this.position.y, this.width, this.height);        
    }

}