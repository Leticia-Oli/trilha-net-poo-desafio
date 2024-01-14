using System.ComponentModel;
using DesafioPOO.Models;

// Testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia (numero: "9222222", modelo: "modelo 1", imei: "030303030", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone (numero: "9555555", modelo: "GH1529", imei: "0505050505", memoria: 120);
iphone.Ligar();
iphone.InstalarAplicativo("Instragam");

Console.WriteLine("\n");