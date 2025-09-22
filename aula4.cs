using System;

class Program
{
  static void Main(string[] args)
  {
	 string primeiroNome = ("         Universo        ");
	 string segundoNome = ("  do Codigo  ");
	  
	 primeiroNome = primeiroNome.Trim();
	
	 Console.WriteLine($"Ola {primeiroNome} {segundoNome.Trim()}");
  }
}
