using System;
using System.Threading;
namespace Reloj
{
	public class Cronometro
	{
		public Cronometro ()
		{
		}
	



		public string obtenFormatoDobleCero(int numero){
			string numeroConFormato = "";
			if(numero < 10){
				numeroConFormato = "0";
			}
			
			numeroConFormato += numero;
			return numeroConFormato;
		}


		public void iniciarCronometro(){

		int minutos=0, segundos=0, horas=0, msegundos=0;  
				

				for(horas=0; horas<24; horas++){
					for(minutos=0; minutos<60; minutos++){ 
						for(segundos=0; segundos<60; segundos++){
							for(msegundos=0;msegundos<60;msegundos++){

						     
							Console.Clear();

							Console.WriteLine(obtenFormatoDobleCero(horas)+":"+obtenFormatoDobleCero(minutos)+":"+obtenFormatoDobleCero(segundos)+":"+obtenFormatoDobleCero(msegundos) ); 
							Thread.Sleep(11);


					
						
						
						
						}}}} 
	
}
	}

}