using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


	public class Producto
	{
		private string nombreI,unidadMedida;
		private int cantidad;
		private double precioUnitario,total;
		
		public Producto()
		{
			nombreI="Arturo";
			unidadMedida="Boliviano";
			cantidad=2;
			precioUnitario=6.95;
		}
		public Producto(string a,string b,int c,double d)
		{
			nombreI=a;
			unidadMedida=b;
			cantidad=c;
			precioUnitario=d;
		}
		public void leer(){
			Console.WriteLine("INGRESE DATOS ITEM");
			Console.WriteLine("Nombre: ");
			nombreI=Console.ReadLine();
			Console.WriteLine("Unidad de Medida: ");
			unidadMedida=Console.ReadLine();
			Console.WriteLine("Cantidad: ");
			cantidad=int.Parse(Console.ReadLine());
			Console.WriteLine("Precio Unitario: ");
			precioUnitario=double.Parse(Console.ReadLine());
			
		}
		public void mostrar(){
			for(int i=1;i<=cantidad;i++){
				total=total+precioUnitario;
			}
			Console.WriteLine("ITEM: |Nombre="+nombreI+" |Tipo="+unidadMedida+" |Cant="+cantidad+" |p/u="+precioUnitario+" |TOTAL=Bs."+total);
			
		}
		//********************** PRECIO TOTAL**************************
		//*************************************************************
		public void precioTotal(){
			double total=0;
			for(int i=1;i<=cantidad;i++){
				total=total+precioUnitario;
			}
			Console.WriteLine("Precio total es: "+total);
		}
		
		public void escribir(BinaryWriter escritor){
			escritor.Write(this.nombreI);
			escritor.Write(this.unidadMedida);
			escritor.Write(this.cantidad);
			escritor.Write(this.precioUnitario);
			escritor.Write(this.total);
		}
		public void lectura(BinaryReader lector){
			this.nombreI = lector.ReadString();
			this.unidadMedida = lector.ReadString();
			this.cantidad = lector.ReadInt32();
			this.precioUnitario = lector.ReadDouble();
			//this.total = lector.ReadInt64();
		}
		//GETTERS AND SETTERS
		public string NombreI {
			get { return nombreI; }
			set { nombreI = value; }
		}

		public string UnidadMedida {
			get { return unidadMedida; }
			set { unidadMedida = value; }
		}

		public int Cantidad {
			get { return cantidad; }
			set { cantidad = value; }
		}

		public double PrecioUnitario {
			get { return precioUnitario; }
			set { precioUnitario = value; }
		}
		public double Total {
			get { return total; }
			set { total = value; }
		}
	}

