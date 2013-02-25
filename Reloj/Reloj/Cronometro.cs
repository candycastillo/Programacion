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


		 
				int minutos=0, segundos=0, horas=0, msegundos=0;  
				

				for(horas=0; horas<=23; horas++){
					for(minutos=0; minutos<=59; minutos++){ 
						for(segundos=0; segundos<=59; segundos++){
							for(msegundos=0;msegundos<=59;msegundos++){

						      Console.Clear();


							Console.WriteLine(horas+":"+minutos+":"+segundos+":"+msegundos); 
							Thread.Sleep(11);


						  
						
							}}}} 
	
	
	
	}
	}

}