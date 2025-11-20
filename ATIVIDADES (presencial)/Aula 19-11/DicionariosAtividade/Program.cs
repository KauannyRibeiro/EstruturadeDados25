/* Uma empresa de entrega e logistica precisa gerenciar os codigps das etiquetas de entrega para
cada pacote de produto em seu respectivo codigo de barras. Observe que a chave é o codigo de
rastreio e o valor é o codigo de barras da encomenda. 

Escreva um produto que armazene em um dicionario uma quantidade x de informações referentes ao rastreio e ao pacote. 
Permitindo ao usuario inseri-las em tempo de execução. Tome cuidado para que o sistema informe quando houverem 
lançamentos repetidos e nao ocasionar erros inesperados. Em seguida, forneça um recurso para que o usuario possa 
procurar tanto por codigo de rastreio quanto por codigo da encomenda e de um retorno amigavel e informativo ao usuario.
*/
using System;
using System.Collections.Generic;

 Dictionary<string, string> products =
    new Dictionary<string, string>
 {
    { "123", "A1" },
    { "456", "B9" },
    { "789", "C8" }
 };

 Console.WriteLine("Digite o codigo de rastreio da encomenda:");
string trackingCode = Console.ReadLine();

Console.WriteLine("Digite o codigo de barras da encomenda:");
string barcodeCode = Console.ReadLine();

 try
 {
    products.Add(trackingCode, barcodeCode);
 }
 catch 
 {
    Console.WriteLine("Esse codigo de barras ja existe no sistema.");
 }

Console.WriteLine("Insira o codigo de rastreio da encomenda que deseja rastrear:");
string trackingSearch = Console.ReadLine();

if(products.TryGetValue(trackingSearch, out string barcodeSearch)){
    Console.WriteLine($" O codigo de barras da encomenda eh: {barcodeSearch}.");
}
else
{
    Console.WriteLine("A encomenda nao esta cadastrada no sistema.");
}

 Console.WriteLine();
 Console.Write("Por favor, insira o codigo de barras da encomenda que deseja rastrear: ");
 string barcode = Console.ReadLine();
 if (products.TryGetValue(barcode, out string location))
 {
    Console.WriteLine($" {location}.");
 }
 else
 {
    Console.WriteLine("A encomenda nao esta cadastrada no sistema.");
 }