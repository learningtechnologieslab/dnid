char val; // Data received from the serial port

void setup() {
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600); // Start serial communication at 9600 bps
}

// the loop function runs over and over again forever
void loop() {
  if(Serial.available()){
    val = Serial.read();
  }

  if(val == '1'){
    digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
  }
  else{
    digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
  }
  delay(10);                       // wait 10 milliseconds for next reading
}
