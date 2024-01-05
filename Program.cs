using DesafioPOO.Models;

Console.WriteLine("------ Iphone ------");
Iphone iphone = new(numero: "+552148599657", modelo: "Iphone 14 pro-max", imei: "1255548", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("------ Nokia ------");
Nokia nokia = new(numero: "+551125684732", modelo: "Nokia 110 dual chip", imei: "9304821", memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("Uber");