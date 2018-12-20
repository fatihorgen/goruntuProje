String gelencevap="";
int aktifpin;
void setup() {
 pinMode(2,OUTPUT);
 pinMode(3,OUTPUT);
 pinMode(4,OUTPUT);
 pinMode(5,OUTPUT);
 pinMode(6,OUTPUT);
 pinMode(7,OUTPUT);
 pinMode(8,OUTPUT);
 pinMode(9,OUTPUT);
 pinMode(10,OUTPUT);

Serial.begin(9600);
}

void loop() {
  
  if(Serial.available()>0)
  {
   gelencevap=Serial.readString();
  int yaziuzunlugu=gelencevap.length()+1;
  char karakterdizisi[yaziuzunlugu];
  gelencevap.toCharArray(karakterdizisi,yaziuzunlugu);
  aktifpin=atoi(karakterdizisi);
  digitalWrite(aktifpin,HIGH);
  for(int i=2;i<11;i++)
  {
    if(i!=aktifpin)
    {
      digitalWrite(i,LOW);
    }
  }
  Serial.print("proje1");
  }
}
