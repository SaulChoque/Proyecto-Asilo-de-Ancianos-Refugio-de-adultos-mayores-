using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Coordinador:Trabajador, PerTecnico
	{
		private int cantInventario;
		private Inventario []invent=new Inventario[30];
		
		public Coordinador():base()
		{
			for(int i=1;i<=invent.Length-1;i++){
				invent[i]=new Inventario();
			}
		}
		//****************mayor gasto *********************
		public void mayorGastoAlimenticio(int a,int b){
			double cont=0;
			double cont2=0;;
			for(int i=1;i<=cantInventario;i++){
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
		}
		public void leer(){
			Console.WriteLine("\n INGRESE DATOS COORDINADOR");
			base.leer();
			Console.WriteLine("Cantidad de Inventario: ");
			cantInventario=int.Parse(Console.ReadLine());
			for(int i=1;i<=cantInventario;i++){
				Console.Write(i+".-");
				invent[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine("COORDINADOR");
			base.mostrar();
			Console.WriteLine(cantInventario);
			for(int i=1;i<=cantInventario;i++){
				invent[i].mostrar();
			}
		}
		public void escribir(BinaryWriter escritor){
			escritor.Write(this.cantInventario);
			for(int i=1;i<=cantInventario;i++){
				invent[i].escribir(escritor);
			}
		}
		public void lectura(BinaryReader lector){
			this.cantInventario = lector.ReadInt32();
			for(int i=1;i<=cantInventario;i++){
				invent[i].lectura(lector);
			}
		}
		//GETTERS AND SETTERS
	public int CantInventario {
		get { return cantInventario; }
		set { cantInventario = value; }
	}

	public Inventario[] Invent {
		get { return invent; }
		set { invent = value; }
	}
}

