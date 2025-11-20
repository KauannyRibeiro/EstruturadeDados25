using System.Collections; using System.Collections.Generic;

Hashtable ht = new Hashtable()
{
    { "Nanda1", "123"},
    { "Nanda2", "456"}
};

ht["Nanda"] = "789";
ht.Add("Teste", "1606");

//verificar se existem pares chave valor na tabela hash

if (ht.Count > 0)
{
    //percorrer para armazenados
    foreach (DictionaryEntry entry in ht)
    {
        Console.WriteLine($"Chave:{entry.Key}, valor: {entry.Value}");
    }
}
    else
    {
        Console.WriteLine("Tabela hast vazia");
    }
try
{
    ht.Add("Nanda", "0709");
}
catch (ArgumentException ex2)
{
    Console.WriteLine("Não é possivel aicionar chaves iguais");
}
catch (Exception ex)
{
    Console.WriteLine("Erro desconhecido");
}
finally
{
    Console.WriteLine("Operação finalizada");
}

Console.WriteLine("Informe a chave: ");
string key = Console.ReadLine();
Console.WriteLine("Informe o valor: ");
string value = Console.ReadLine();

try
{
    ht.Add(key, value);
    Console.WriteLine("Par chave-valor acionado!");
}
catch
{
    Console.WriteLine("Ops! Chave já existente.");
}
//Busca na tabela Hash
Console.Write("Que cê quer caralho? ");
string search = Console.ReadLine();

if (ht.Contains(search))
{
    Console.WriteLine($"Ta ai essa merda: {search}, {ht[search]}");
}


