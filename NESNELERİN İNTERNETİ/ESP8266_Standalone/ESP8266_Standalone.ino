
#define BLYNK_PRINT Serial

#define BLYNK_TEMPLATE_ID "TMPL6I3ZUy1qG"
#define BLYNK_TEMPLATE_NAME "İKİNCİ UYGULAMA HAFTA4"
#define BLYNK_AUTH_TOKEN "7CJitg1wN2Q0OYhlSh2CH86YJNQy6ld1"
#include <ESP8266WiFi.h>
#include <BlynkSimpleEsp8266.h>
char auth [] = "7CJitg1wN2Q0OYhlSh2CH86YJNQy6ld1"; // Blynk uygulaması tarafından, mailinize gelen token key
char ssid [] = "Mustafa İphone'u"; // Bağlantı yapacağınız Wi‐Fi adı
char pass [] = "1234567890"; // Wi‐Fi şifreniz
// Sanal pin oluşturma
BLYNK_WRITE(V0) {
digitalWrite(D0, param.asInt());
}


void setup()
{
Serial.begin(9600);
pinMode(D0,OUTPUT);
Blynk.begin(auth, ssid, pass, "blynk.cloud",80);
}
void loop()
{
Blynk.run();
}