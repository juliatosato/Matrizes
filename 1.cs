using System;

class Program 
{
  public static void Main (string[] args) 
  {
    string [] fileira = new string [8];

    for (int i = 0; i <= 7; i++)
    {
      Console.WriteLine("Digite o nome do aluno: ");
      fileira[i] = Console.ReadLine();
      Console.WriteLine ($"O nome do aluno é {fileira[i]} ");
    }

  }
}