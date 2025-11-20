/* Os dicionarios funcionam da mesma forma que as tabelas hash. No entanto de uma maneira mais
sofisticada. É possível definir que tipo de dado será utilizado para armazenar tanto a Chave
quanto o Valor.
Diferentemente da tabela Hash que utiliza-se apenas de string.
*/

Dictionary<string, int> dic0 = new Dictionary<string, int>();

Dictionary<string, int> dic = new Dictionary<string, int>
{
    {"Chave1", 100},
    {"Chave1", 200},
};

// Podemos add informando diretamente a chave
dic["Chave3"] = 300;
dic.Add("Chave4", 400);

// Para procurar
if (dic.ContainsKey("Chave4"))
{
    Console.WriteLine($"Encontrado chave 4, {dic["Chave4"]}");
}

/* Uma empresa de entrega e logistica precisa gerenciar os codigps das etiquetas de entrega para
cada pacote de produto em seu respectivo codigo de barras. Observe que a chave é o codigo de
rastreio e o valor é o codigo de barras da encomenda. 
Escreva um produto que armazene em um dicionario uma quantidade x de informações referentes ao rastreio e ao pacote. 
Permitindo ao usuario inseri-las em tempo de execução. Tome cuidado para que o sistema informe quando houverem 
lançamentos repetidos e nao ocasionar erros inesperados. Em seguida, forneça um recurso para que o usuario possa 
procurar tanto por codigo de rastreioquanto por codigo da encomenda e de um retonro amigavel e informativo ao usuario.
*/

