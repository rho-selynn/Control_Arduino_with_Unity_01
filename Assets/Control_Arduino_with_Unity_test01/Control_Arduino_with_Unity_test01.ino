// This belongs with the Unity Project called
// "Control_Arduino_with_Unity_01"

int data;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available()) {
    data = Serial.read();
    if (data == 'A') {
      digitalWrite(13,HIGH);
    }
    else {
      digitalWrite(13,LOW);
      
    }
  }
}

// Testing to see if board works
//void loop() {
//Serial.println("Hello World");
//}
