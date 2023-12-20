using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("12346");
nokia.modelo = "modelo 1";
nokia.imei = "imei1";
nokia.memoria = 64;
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");

Iphone iphone = new Iphone("7890");
iphone.modelo = "modelo2";
iphone.imei = "imei2";
iphone.memoria = 256;
iphone.Ligar();
iphone.InstalarAplicativo("Bumble");

