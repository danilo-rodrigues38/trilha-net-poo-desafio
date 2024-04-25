using DesafioPOO.Models;

Console.Clear();
Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "987654", modelo: "Modelo 2", imei: "222222222", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine();