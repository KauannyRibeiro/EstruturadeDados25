    int[] numeros = {10,20,180,30,60,50,110,100,70};
    int keyInt = 180;
    SentinelSearch(numeros, numeros.Length, keyInt);

    string[] nomes = {"Ana", "Bruno", "Carlos", "Diana"};
    string keystring = "Carlos";
    static void SentinelSearch<T>(T[] arr, int n, T key)
    {
        
        T last = arr[n - 1];
        arr[n - 1] = key;
        int i = 0;

        while (!EqualityComparer<T>.Default.Equals(arr[i], key))
        i++;
        arr[n - 1] = last;

        if (i < n - 1 || EqualityComparer<T>.Default.Equals(arr[n - 1], key)){
            Console.WriteLine($"{key} Esta presente no indice: {i} " );
        } else{
            Console.WriteLine("Elemento nao encontrado");}
    }