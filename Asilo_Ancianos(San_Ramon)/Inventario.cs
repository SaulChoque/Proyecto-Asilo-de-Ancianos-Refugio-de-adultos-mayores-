
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

namespace Asilo_Ancianos_San_Ramon_
{
	[Serializable]
	public class Inventario
	{
		private int anio;
		private string tipo;
		private int nroItem;
		private Producto[] prod = new Producto[100];

		public Inventario() { this.nroItem = 0; }

		//******************** MAYOR CANTIDAD DE PRODUCTOS ***************************
		//***************************************************************
		public void mayorCant(int x)
		{
			int may = 0;
			int aux = 0;
			if (anio == x && tipo.CompareTo("limpieza") == 0)
			{
				for (int i = 1; i <= nroItem; i++)
				{
					if (prod[i].Cantidad > may)
					{
						may = prod[i].Cantidad;
						aux = i;
					}
				}
				Console.WriteLine("El producto es: " + prod[aux].Nombre + " con: " + prod[aux].Cantidad);
			}
		}
		//******************** MAYOR PRESUPUESTO DE INSUMOS ALIMENTICIOS ***************************
		//******************************************************************************************
		public void mayorPresAlimenticio(int x, int y)
		{
			double sumaA = 0;
			double sumaB = 0;
			if (anio == x)
			{
				for (int i = 1; i <= nroItem; i++)
				{
					sumaA = sumaA + prod[i].Total;
				}
			}
			if (anio == y)
			{
				for (int i = 1; i <= nroItem; i++)
				{
					sumaB = sumaB + prod[i].Total;
				}
			}
			if (sumaA > sumaB)
			{
				Console.WriteLine("En el año " + x + " se gasto un total de: Bs." + sumaA);
			}
			else
			{
				Console.WriteLine("En el año " + y + " se gasto un total de: Bs." + sumaB);
			}
		}
		//LEER Y MOSTRAR
		public void leer()
		{
			Console.WriteLine("------ Lectura de Datos Inventario ------");
			Console.Write("Tipo Inventario => ");
			tipo = Console.ReadLine();
			Console.WriteLine();
			do
			{
				prod[nroItem].leer();
				nroItem = nroItem + 1;
				Console.WriteLine("Desea continuar añadiendo Reportes?. s/n: ");
			} while (Console.ReadKey().KeyChar == 's');
		}
		public void mostrar()
		{
			Console.WriteLine("------ Datos Inventario ------");
			Console.WriteLine("Tipo de inventario => ");
			for (int i = 0; i < nroItem; i++)
			{
				prod[i].mostrar();
			}
		}
		public void escribir(BinaryWriter escritor)
		{
			escritor.Write(this.tipo);
			escritor.Write(this.nroItem);
			for (int i = 0; i < nroItem; i++)
			{
				prod[i].escribir(escritor);
			}
		}
		public void lectura(BinaryReader lector)
		{
			this.tipo = lector.ReadString();
			this.nroItem = lector.ReadInt32();
			for (int i = 0; i < nroItem; i++)
			{
				prod[i].lectura(lector);
			}
		}


		//GETTERS AND SETTERS
		public string Tipo { get { return tipo; } set { tipo = value; } }
		public int NroItem { get { return nroItem; } set { nroItem = value; } }
		public Producto[] Prod { get { return prod; } set { prod = value; } }
	}
}