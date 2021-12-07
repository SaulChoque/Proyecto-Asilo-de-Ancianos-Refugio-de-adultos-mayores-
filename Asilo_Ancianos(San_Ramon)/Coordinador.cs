using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asilo_Ancianos_San_Ramon_{

	[Serializable]
	public class Coordinador:Trabajador, PerTecnico
	{
		private int cinv;
		private Inventario []invent=new Inventario[30];

		public Coordinador():base(){}

		public Coordinador(string turn, double suel, string tipocon, string nom, string ape, string fech, string usu, string corr, string contr, string sex, int ed, int nci, int nroc) : base(turn, suel, tipocon, nom, ape, fech, usu, corr, contr, sex, ed, nci, nroc) { }


		/* 	public void mayorGastoAlimenticio(int a,int b){
				double cont=0;
				double cont2=0;;
				for(int i=1;i<=cinv;i++){
					if(invent[i].Anio == a){
						for(int j=1;j<=invent[i].NroItem;j++){
							cont=cont+invent[i].It[j].Total;
						}
					}else{
						if(invent[i].Anio == b){
							for(int j=1;j<=invent[i].NroItem;j++){
								cont2=cont2+invent[i].It[j].Total;
							}
						}
					}
				}
				if(cont > cont2){
					Console.WriteLine("el mayor es "+cont);
				}else{
					Console.WriteLine("el mayor es "+cont2);
				}
			} */
		public void leerCoordinador(){
			Console.WriteLine("\n ------ Lectura de Datos Coordinador ------");
			base.leer();
			do{
				Console.WriteLine();
				invent[cinv].leer();
				cinv=cinv+1;
				Console.Write("Desea seguir añadiendo inventario?(s/n) => ");
			}while(Console.ReadKey().KeyChar=='s');
		}
		public void mostrarCoordinador(){
			base.mostrar();
		}

		public void mostrarInventarioCoor(){
			for(int i=0;i<cinv;i++){
				invent[i].mostrar();
			}		
		}

		public void escribirCoordinador(BinaryWriter escritor){
			escritor.Write(this.cinv);
			for(int i=0;i<cinv;i++){
				invent[i].escribir(escritor);
			}
		}
		public void lectorCoordinador(BinaryReader lector){
			this.cinv = lector.ReadInt32();
			for(int i=0;i<cinv;i++){
				invent[i].lectura(lector);
			}
		}
			//GETTERS AND SETTERS
		public int Cinv {get {return cinv;}set{cinv=value;}}
		public Inventario[] Invent {get{return invent;}set{invent=value;}}
	}
}
