// https://happycoding.io/examples/processing/animation/random-walker#:~:text=A%20random%20walker%20is%20a,on%20a%20piece%20of%20paper.
float x;
float y;

void setup() {
  size(400, 300);
  
  //start in middle of screen
  x = width/2;
  y = height/2;

  //gray background
  background(200);
  
  //make the simulation faster
  frameRate(1000);
}

void draw() {
  
  stroke(random(-1, 1));
  
  //randomly move
  x += random(-1, 1);
  y += random(-1, 1);
  
  //prevent going off left or right
  if(x < 0){
    x = width;
  }
  if(x > width){
    x = 0;
  }

  //prevent going off top or bottom
  if(y < 0){
    y = height;
  }
  if(y > height){
    y = 0;
  }
  
  //draw the point
  point(x, y);
}
