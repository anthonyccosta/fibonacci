int penultimo = -1, ultimo = 1, atual;

        Console.Write("Digite a posição desejada: ");
        int posicao = int.Parse(Console.ReadLine());

        //if (posicao < 1)
        //{
        //    Console.WriteLine("Erro: Posição deve ser maior que zero.");
        //}

        //Console.Write("sequência fibonacci até a posição " + posicao + ": ");
        //int primeiro = 0;
        //int ultimo = 1;


        for (int i = 0; i < posicao; i++)
        {
            atual = penultimo + ultimo;
            Console.WriteLine(atual);
            penultimo = ultimo;
            ultimo = atual;
        }

//for (int i = 0; i < posicao; i++)
{
    //switch (i)
    //{
    //    case 0:
    //        Console.Write(primeiro);
    //        break;
    //    case 1:
    //        Console.Write(ultimo);
    //        break;
    //    default:
    //        int proximoValor = primeiro + ultimo;
    //        Console.Write(proximoValor);
    //        primeiro = ultimo;
    //        ultimo = proximoValor;
    //        break;
    //}

    
}