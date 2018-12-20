String seriport;


void setup() {
  Serial.begin(9600);
  pinMode(2,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(4,OUTPUT);
  pinMode(5,OUTPUT);
}

void loop() {
  if(Serial.available()>0) //seri porttan bilgi gelirse aktif olur.
  {
    seriport=Serial.readString(); //seriporttan gelen bilgiyi okuma.
  }
  if(seriport=="sol")
  {
    for(int i=2;i<6;i++)
    {
      digitalWrite(i,HIGH);
      delay(2);
      digitalWrite(i,LOW);
      if(i==6)
      {
        i=2;
      }
     
    }
  }else if(seriport=="sag")
  {
    for(int i=5;i>1;i--)
    {
      digitalWrite(i,HIGH);
      delay(2);
      digitalWrite(i,LOW);
      if(i==1)
      {
        i=5;
      }
     
    }
  } 
}
