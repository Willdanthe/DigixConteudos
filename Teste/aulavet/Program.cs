int[] vetor = new int[10];
    Random r = new Random();
    int max = int.MinValue;
    int min = int.MaxValue;

    for (int i = 0; i < vetor.Length; i++)
    {
        vetor[i] = r.Next(1,100);
    }

    Console.WriteLine(string.Join(" ",vetor)); //Printa os valore sem usar for

    // for (int i = 0; i < vetor.Length; i++)
    // {
    //     if (vetor[i] > max){
    //         max = vetor[i];
    //     }
    //     if (vetor[i] < min){
    //         min = vetor[i];
    //     }
    // }
    Console.WriteLine($"O maior número é {vetor.Max()} e o menor é {vetor.Min()}");
