import processing.sound.*;
import processing.serial.*;

Serial myPort;
SoundFile file;
AudioIn in;
Amplitude amp;
boolean playSound = false;

void setup() {
  size(640, 360);
  background(255);
  
  String portName = Serial.list()[3];
  print(portName);
  myPort = new Serial(this, portName, 9600);
  
  
    
  // Load a soundfile from the /data folder of the sketch and play it back
  file = new SoundFile(this, "door-strong-knocking.mp3");
  amp = new Amplitude(this);
  in = new AudioIn(this, 0);
  in.start();
  amp.input(in);
}

void draw() {
  if(amp.analyze() > 0.4){
    // println(amp.analyze());
    playSound = ! playSound;
  }
  
  if(playSound){
     file.play(); 
     myPort.write('1');
  }
  else{
    // file.stop();
  }
  
  if(mousePressed == true){
    myPort.write('1');
    println("1");
  }
  else{
    myPort.write('0');
    println("0");
  }
}
