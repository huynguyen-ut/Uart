
void setup() {
        Serial.begin(9600);     // mở serial với baudrate 9600
        pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {

        if (Serial.available() > 0) {
          String incom=Serial.readString();
          Serial.println(incom);
                // đọc chữ liệu
               if (incom=="on") {
                  digitalWrite(LED_BUILTIN, HIGH);
                 
                } else if(incom=="off") {
                 
                  digitalWrite(LED_BUILTIN, LOW);
                }
         }
    
} 
