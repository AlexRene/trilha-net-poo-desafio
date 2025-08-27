using DesafioPOO.Models;

Console.WriteLine("=== Sistema de Celulares ===\n");

// Realizando os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("(11) 99999-1111", "Nokia G20", "123456789", 64);
Iphone iphone = new Iphone("(11) 88888-2222", "iPhone 13", "987654321", 128);

// Testando Nokia
Console.WriteLine("=== NOKIA ===");
Console.WriteLine($"Número: {nokia.Numero}");
Console.WriteLine($"Modelo: {nokia.Modelo}");
Console.WriteLine($"IMEI: {nokia.Imei}");
Console.WriteLine($"Memória: {nokia.Memoria}GB");
Console.WriteLine();

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Instagram");
Console.WriteLine();

// Testando iPhone
Console.WriteLine("=== IPHONE ===");
Console.WriteLine($"Número: {iphone.Numero}");
Console.WriteLine($"Modelo: {iphone.Modelo}");
Console.WriteLine($"IMEI: {iphone.Imei}");
Console.WriteLine($"Memória: {iphone.Memoria}GB");
Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok");
iphone.InstalarAplicativo("Spotify");

Console.WriteLine("\n=== Fim dos testes ===");