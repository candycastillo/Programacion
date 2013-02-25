using System;

namespace Reloj
{
	class MainClass
	{
		public void menu(){
		Console.WriteLine ("Elija la opcion:");
			Console.WriteLine ("1) Reloj");
			Console.WriteLine ("2) Cronometro");
		
			int opcion = int.Parse(Console.ReadLine());
		
			if (opcion == 1) {  
				Reloj2 clock = new Reloj2(); 
				clock.iniciarTiempo(); 
			}  

		else { Cronometro inicio = new Cronometro();  
				inicio.iniciarCronometro();                                    }	
	}

		public static void Main (string[] args)
		{

			MainClass metodo = new MainClass (); 
			metodo.menu ();

			}
	}
}
