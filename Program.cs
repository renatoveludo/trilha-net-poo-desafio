using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
System.Console.WriteLine($"Numero: {nokia.Numero} - Modelo: {nokia.Modelo}... Instalado com sucesso");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
System.Console.WriteLine($"Numero: {iphone.Numero} - Modelo: {iphone.Modelo}... Instalado com sucesso");