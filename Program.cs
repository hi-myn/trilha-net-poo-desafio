using DesafioPOO.Models;

Console.WriteLine("Testanto celular Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine($"Informações do Nokia : numero ({nokia.Numero}), modelo ({nokia.Modelo}), IMEI ({nokia.Imei}), memoria ({nokia.Memoria})");

Console.WriteLine("\n");

Console.WriteLine("Testanto celular Iphone");
Smartphone iphone = new Iphone(numero: "789101", modelo: "Modelo 2", imei: "222222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
Console.WriteLine($"Informações do Iphone : numero ({iphone.Numero}), modelo ({iphone.Modelo}), IMEI ({iphone.Imei}), memoria ({iphone.Memoria})");
