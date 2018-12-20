#include <Servo.h>

Servo servo1;
Servo servo2;
int i;
char * yazibolme;
char * dizi[1];
int obje1y,obje2y;

void setup() {
  Serial.begin(9600);
  servo1.attach(10);
  servo2.attach(11);
    

}

void loop() {
  if(Serial.available()>0){
      String seriport=Serial.readString();
      int karaktersayisi=seriport.length()+1;
      char karakterdizisi[karaktersayisi];
      seriport.toCharArray(karakterdizisi,karaktersayisi);
      yazibolme=strtok(karakterdizisi,"*");
      i=0;
      while(yazibolme !=NULL)
      {
        dizi[i++]=yazibolme;
        yazibolme=strtok(NULL,"*");
      } 
      obje1y=atoi(dizi[0]);
      obje2y=atoi(dizi[1]);
    
      obje1y=map(obje1y,0,480,40,180);
      obje2y=map(obje2y,0,480,40,180);
      delay(15);
      servo1.write(obje1y);
      servo2.write(obje2y);
      Serial.print("proje2a");
  }
  

}
