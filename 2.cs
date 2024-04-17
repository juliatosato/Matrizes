using System;

class Program 
{
  public static void Main (string[] args)
  {
   string [] alunos = new string [10]; //colchetes diz que é vetor e 10 diz o tamanho do vetor
   string menu = ""; //começa com vazio pois vamos juntar o vazio com outro dado que vou inserir
   int op = 0; //aqui deve ser colocado o número da oção de sair 
   int x, y; 


    menu = menu + "1. Entrar dados\n"; //\n é pra pular linha
    menu = menu + "2. Ordenar dados\n";
    menu = menu + "3. Pesquisar dados\n";
    menu = menu + "4. Mostrar dados\n";
    menu = menu + "0. Sair\n";
// aqui, todos os menus vão se juntando uns aos outros conforme o código vai "rodando"
    do
    {
      Console.WriteLine(menu);
      op = int.Parse(Console.ReadLine());

      switch(op)
      {
      case 1: for (int i = 0; i < 10; i++)
                  {
                    Console.WriteLine("Digite o nome: ");
                    alunos [i] = Console.ReadLine();
                  }
        break;
      case 2: for (x = 0; x < 9; x++)
                  {
                    for (y = x + 1; y < 10; y++)
                    {
                      if (alunos [x].CompareTo(alunos[y]) > 0)
                      {
                        string aux = alunos[x];
                        alunos[x] = alunos[y];
                        alunos[y] = aux;
                      }

                    }
                  }
        break;
      case 3:
        string pesquisa;
        int pos = 0; 
        bool achou = false;
        Console.WriteLine("Quem você quer pesquisar? ");
        pesquisa = Console.ReadLine();

        while (!achou && pos < 10)
        {
          if (alunos [pos] == pesquisa)
          {
            achou = true;
          }
          pos = pos + 1;

        }
        if (achou)
        {
          Console.WriteLine($"Nome encontrado na posição {pos}");
        }
        else
        {
          Console.WriteLine("Nome não encontrado");
        }
        break;
      case 4: for (int i = 0; i < 10; i++)
                  {
                    Console.WriteLine($"O nome é {alunos[i]}");
                  }
        break;
      case 0: op = 0;
        break;
      default: Console.WriteLine("Opção Inválida");
        break;
      }


    } while(op != 0);//enquanto op for diferente de 0, ele continua rodando o DO

  }
}