using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe um número para calcular a tabuada:");
    int n = int.Parse(Console.ReadLine());

    for (int volta=0; volta<=10; volta++){
      int x = n * volta;

      Console.WriteLine("{0} x {1} = {2}", n, volta, x);
    }
  }
}