using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

	public class TrabSocial:Trabajador, PerTecnico
	{
		private int cantTaller;
		private Taller []t=new Taller[10];
		
		public TrabSocial():base()
		{
			for(int i=1;i<=t.Length-1;i++){
				t[i]=new Taller();
			}
		}
		public void leer(){
			Console.WriteLine("\n INGRESE DATOS TRABAJO SOCIAL");
			base.leer();
			Console.WriteLine("Cantidad de Talleres: ");
			cantTaller=int.Parse(Console.ReadLine());
			for(int i=1;i<=cantTaller;i++){
				Console.Write(i+".-");
				t[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine("TRABAJO SOCIAL: ");
			base.mostrar();
			Console.WriteLine(cantTaller);
			for(int i=1;i<=cantTaller;i++){
				t[i].mostrar();
			}
		}
		public void escribir(BinaryWriter escritor){
			escritor.Write(this.cantTaller);
			for(int i=1;i<=cantTaller;i++){
				t[i].escribir(escritor);
			}
		}
		public void lectura(BinaryReader lector){
			this.cantTaller = lector.ReadInt32();
			for(int i=1;i<=cantTaller;i++){
				t[i].lectura(lector);
			}
		}
		//GETTERS AND SETTERS
		public int CantTaller {
			get { return cantTaller; }
			set { cantTaller = value; }
		}

		public Taller[] T {
			get { return t; }
			set { t = value; }
		}
	}

