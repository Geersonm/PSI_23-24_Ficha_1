using System;

namespace BolasColoridas
{
  class Program
  {
    static void Main(string[] args)
    {
      Cor a = new Cor(25, 37, 41);
      Cor b = new Cor(1, 3, 2);
      Cor c = new Cor(44, 6, 21);
      Cor d = new Cor(66, 11, 22);
      Cor e = new Cor(52, 73, 54);

      Bola ba = new Bola(9, a);
      Bola bb = new Bola(8, b);
      Bola bc = new Bola(7, c);
      Bola bd = new Bola(6, d);
      Bola be = new Bola(5, e);

      Console.WriteLine("A bola A foi atirada! ");
      ba.Atirar();
      Console.WriteLine("A bola B foi atirada! ");
      bb.Atirar();
      Console.WriteLine("A bola C foi atirada! ");
      bc.Atirar();
      Console.WriteLine("A bola D foi atirada! ");
      bd.Atirar();
      Console.WriteLine("A bola E foi atirada! ");
      be.Atirar();

      Console.WriteLine("");

      Console.WriteLine("A bola A foi rebentada!");
      ba.Rebentar();
      Console.WriteLine("A bola C foi rebentada!");
      bc.Rebentar();
      Console.WriteLine("A bola E foi rebentada!");
      be.Rebentar();
      Console.WriteLine("");


      Console.WriteLine("A bola A tem: ");
      Console.WriteLine($"Quantidade de vermelho: {a.GetRed()}");
      Console.WriteLine($"Quantidade de verde: {a.GetGreen()}");
      Console.WriteLine($"Quantidade de azul: {a.GetBlue()}");
      Console.WriteLine($"Raio: {ba.GetRaio()}");
      Console.WriteLine($"Quantidade de vezes que a bola A foi atirada: {ba.GetNVezes()}");
      Console.WriteLine("");
      Console.WriteLine("A bola B tem: ");
      Console.WriteLine($"Quantidade de vermelho: {b.GetRed()}");
      Console.WriteLine($"Quantidade de verde: {b.GetGreen()}");
      Console.WriteLine($"Quantidade de azul: {b.GetBlue()}");
      Console.WriteLine($"Raio: {bb.GetRaio()}");
      Console.WriteLine($"Quantidade de vezes que a bola A foi atirada: {bb.GetNVezes()}");
      Console.WriteLine("");
      Console.WriteLine("A bola C tem: ");
      Console.WriteLine($"Quantidade de vermelho: {c.GetRed()}");
      Console.WriteLine($"Quantidade de verde: {c.GetGreen()}");
      Console.WriteLine($"Quantidade de azul: {c.GetBlue()}");
      Console.WriteLine($"Raio: {bc.GetRaio()}");
      Console.WriteLine($"Quantidade de vezes que a bola A foi atirada: {bc.GetNVezes()}");
      Console.WriteLine("");
      Console.WriteLine("A bola D tem: ");
      Console.WriteLine($"Quantidade de vermelho: {d.GetRed()}");
      Console.WriteLine($"Quantidade de verde: {d.GetGreen()}");
      Console.WriteLine($"Quantidade de azul: {d.GetBlue()}");
      Console.WriteLine($"Raio: {bd.GetRaio()}");
      Console.WriteLine($"Quantidade de vezes que a bola A foi atirada: {bd.GetNVezes()}");
      Console.WriteLine("");
      Console.WriteLine("A bola E tem: ");
      Console.WriteLine($"Quantidade de vermelho: {e.GetRed()}");
      Console.WriteLine($"Quantidade de verde: {e.GetGreen()}");
      Console.WriteLine($"Quantidade de azul: {e.GetBlue()}");
      Console.WriteLine($"Raio: {be.GetRaio()}");
      Console.WriteLine($"Quantidade de vezes que a bola A foi atirada: {be.GetNVezes()}");


    }
  }
}
