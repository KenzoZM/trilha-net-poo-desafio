using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("smartphone nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 01", imei: "11111", memorio: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("------------------------------------");

System.Console.WriteLine("smartphone iphone");
Smartphone iphone = new Iphone(numero: "3554", modelo: "Iphone 11", imei: "33333", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");