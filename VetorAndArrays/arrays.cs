
static void main(Args[]){
  //Declaração do Array
  //<tipo>[] <nomeDaVariavel> = new <tipo>[tamanhoDoArray]
  // String[] nomes = new String[];
  // int[] age = new int[];
  // double[] age = new double[];
  // char[] age = new char[];

  int[] array = new int[4];
  int a = array.Length;
  Console.WriteLine(a);


  int[] array2 = new int[3];
  int b = array2.Length;

  for (int i = 0; i < length; i++)
  {
      array2[i] = i;
      Console.WriteLine(array2[i]);
  }

//Testar com 15 e 17
  int c = Convert.ToInt32(Console.In.ReadLine());
  int[] vetor = new int[b];

  //vetor.Length
  for (int i = 0; i < 15; i++)
  {
    //Independente do valor de i, vai sempre multiplicar até o tamanho do array
      vetor[i] = i * 2;
      //vetor[i] = i + i;
      Console.WriteLine( vetor[i]);
  }

  int[] list = new int[20];
  for (int i = 0; i < list.length; i++)
    {
      list[i] = 0;
    }

    for (int i = 0; i < list.length - 1; i++)
    {
        if(list[i] == 0){
  list[i + 1] = i;
        }
    }

    Console.WriteLine( list[i]);
  }