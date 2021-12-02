
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


	public class Inventario
	{
		private string tipo;
		private int anio;
		private int nroItem;
		private Item []it=new Item[100];
		
		public Inventario()
		{
			for(int i=1;i<=it.Length-1;i++){
				it[i]=new Item();
			}
		}
		
		//******************** MAYOR CANTIDAD DE PRODUCTOS ***************************
		//***************************************************************
		public void mayorCant(int x){
			int may=0;
			int aux=0;
			if(anio == x && tipo.CompareTo("limpieza")==0){
				for(int i=1;i<=nroItem;i++){
					if(it[i].Cantidad > may){
						may=it[i].Cantidad;
						aux=i;
					}
				}
				Console.WriteLine("El producto es: "+it[aux].NombreI+" con: "+it[aux].Cantidad);
			}
		}
		//******************** MAYOR PRESUPUESTO DE INSUMOS ALIMENTICIOS ***************************
		//******************************************************************************************
		public void mayorPresAlimenticio(int x,int y){
			double sumaA=0;
			double sumaB=0;
			if(anio == x){
				for(int i=1;i<=nroItem;i++){
					sumaA=sumaA+it[i].Total;
				}
			}
			if(anio == y){
				for(int i=1;i<=nroItem;i++){
					sumaB=sumaB+it[i].Total;
				}
			}
			if(sumaA > sumaB){
				Console.WriteLine("En el año "+x+" se gasto un total de: Bs."+sumaA);
			}else{
				Console.WriteLine("En el año "+y+" se gasto un total de: Bs."+sumaB);
			}
		}
		//LEER Y MOSTRAR
		public void leer(){
			Console.WriteLine(" INGRESE DATOS INVENTARIO");
			Console.WriteLine("Tipo Inventario: ");
			tipo=Console.ReadLine();
			Console.WriteLine("Ingrese Año");
			anio=int.Parse(Console.ReadLine());
			Console.WriteLine("Cant de Items: ");
			nroItem=int.Parse(Console.ReadLine());
			for(int i=1;i<=nroItem;i++){
				Console.Write(i+".-");
				it[i].leer();
			}
		}
		public void mostrar(){
			Console.WriteLine("---INVENTARIO---");
			Console.WriteLine(tipo+" |AÑO:"+anio+" |"+nroItem);
			for(int i=1;i<=nroItem;i++){
				Console.Write(i+".-");
				it[i].mostrar();
			}
		}
		public void escribir(BinaryWriter escritor){
			escritor.Write(this.tipo);
			escritor.Write(this.anio);
			escritor.Write(this.nroItem);
			for(int i=1;i<=nroItem;i++){
				it[i].escribir(escritor);
			}
		}
		public void lectura(BinaryReader lector){
			this.tipo = lector.ReadString();
			this.anio = lector.ReadInt32();
			this.nroItem = lector.ReadInt32();
			for(int i=1;i<=nroItem;i++){
				it[i].lectura(lector);
			}
		}
		//GETTERS AND SETTERS
		public string Tipo {
			get { return tipo; }
			set { tipo = value; }
		}
		
		public int Anio {
			get { return anio; }
			set { anio = value; }
		}

		public int NroItem {
			get { return nroItem; }
			set { nroItem = value; }
		}

		public Item[] It {
			get { return it; }
			set { it = value; }
		}
	}
