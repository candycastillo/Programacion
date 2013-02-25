using System;
using System.Threading;
namespace Reloj
{
	public class Cronometro
	{
		public Cronometro ()
		{
		}
	
		public void iniciarCronometro(){


		 
				double minutos=0, segundos=0, horas=0, msegundos=0;  
				

				for(horas=0; horas<24; horas++){
					for(minutos=0; minutos<60; minutos++){ 
						for(segundos=0; segundos<60; segundos++){
							for(msegundos=0;msegundos<60;msegundos++){

						      Console.Clear();


							Console.WriteLine(horas+":"+minutos+":"+segundos+":"+msegundos); 
							Thread.Sleep(11);


					}}}} 
	
}
	}

}