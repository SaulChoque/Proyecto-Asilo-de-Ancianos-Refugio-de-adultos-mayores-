using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


	public class Taller
	{
		private string nomTaller;
		private int cantPar;
		private Refugiado []r=new Refugiado[15];
		
		
		public Taller()
		{
			for(int i=1;i<=r.Length-1;i++){
				r[i]=new Refugiado();
			}
		}
		public void leer(){
			Console.WriteLine("INGRESE DATOS TALLER");
			Console.WriteLine("Nombre Taller: ");
			nomTaller=Console.ReadLine();
			Console.WriteLine("Cantidad de Participantes: ");
			cantPar=int.Parse(Console.ReadLine());
			for(int i=1;i<=cantPar;i++){
				Console.Write(i+".-");
				r[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine("TALLER: |"+nomTaller+" |"+cantPar);
			for(int i=1;i<=cantPar;i++){
				r[i].mostrar();
			}
		}
		//*********************CAMBIA NOMBRE TALLER ****************************
		public void cambiaNomTaller(){
			Console.WriteLine("Ingrese Nuevo nombre Taller: ");
			string x=Console.ReadLine();
			nomTaller=x;
		}
		//********************* AGREGA PARTICIPANTE *****************************
		public void agregaParTaller(){
			Console.WriteLine("*** AGREGA NUEVO PARTICIPANTE ***");
			cantPar++;
			r[cantPar].leer();
		}
		//********************** ELIMINA PARTICIPANTES DE EDAD X **************************
		public void eliminaParTallerEdadX(){
			Console.WriteLine("*** ELIMINA PARTICIPANTE ***");
			Console.WriteLine("Ingres edad a eliminar:");
			int x=int.Parse(Console.ReadLine());
			for(int i=1;i<=cantPar;i++){
				if(r[i].Edad == x){
					cantPar--;
					for(int j=i;j<=cantPar;j++){
						r[j]=r[j+1];	
					}
				}
			}
		}
		public void escribir(BinaryWriter escritor){
			escritor.Write(this.nomTaller);
			escritor.Write(this.cantPar);
			for(int i=1;i<=cantPar;i++){
				r[i].escribir(escritor);
			}
		}
		public void lectura(BinaryReader lector){
			this.nomTaller = lector.ReadString();
			this.cantPar = lector.ReadInt32();
			for(int i=1;i<=cantPar;i++){
				r[i].lectura(lector);
			}
		}
		//GETTERES AND SETTERS
		public string NomTaller {
			get { return nomTaller; }
			set { nomTaller = value; }
		}

		public int CantPar {
			get { return cantPar; }
			set { cantPar = value; }
		}

		public Refugiado[] R {
			get { return r; }
			set { r = value; }
		}
	}
