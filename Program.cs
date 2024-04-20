using DesafioPOO.Models;


Nokia nokia = new Nokia("98763-0912", "C20", "001970-01-010000-0", 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.RecusarLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.ExibirAplicativos();

Console.WriteLine("\n");

Iphone iphone = new Iphone("8888-8888", "14", "098292-02-120001-0", 32);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Waze");
iphone.ExibirAplicativos();