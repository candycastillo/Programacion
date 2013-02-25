using System;
using System.Threading;
namespace Reloj
{
	public class Reloj2
	{
		private int horas; 

		private int minutos; 
		private int segundos; 


		public Reloj2 ()
		{
		
			this.horas=0; 
			this.minutos=0; 
		      this.segundos=0; 
	}
	


		public void iniciarTiempo(){
		
			this.iniciarReloj ();
			this.procesoReloj (); 
		
		
		}



		public void iniciarReloj(){

			this.horas = DateTime.Now.Hour;  
			this.minutos = DateTime.Now.Minute;  
			this.segundos = DateTime.Now.Second;  


	}
	
	public string obtenFormatoDobleCero(int numero){
			string numeroConFormato = "";
			if(numero < 10){
				numeroConFormato = "0";
			}
			
			numeroConFormato += numero;
			return numeroConFormato;
		}

		public void procesoReloj(){




			while(true){
			for(this.horas=this.horas; this.horas<=23;this.horas++ ){
					for(this.minutos=this.minutos;this.minutos<=59; this.minutos++){
						for(this.segundos=this.segundos;this.segundos<=59;this.segundos++){
							Console.Clear();
							Console.WriteLine(this.obtenFormatoDobleCero(horas)+":"+this.obtenFormatoDobleCero(minutos)+":"+this.obtenFormatoDobleCero(segundos)); 
							Thread.Sleep(1000);
							 

						
						} this.segundos=0;}this.minutos=0;}   this.nuevoDia();       }
		
		
		
		
		
		
		
		
		
		} 



	private void nuevoDia(){

			this.horas=0; 
			this.minutos=0; 
			this.segundos=0;



			}
	
	
	
	
	}
}

