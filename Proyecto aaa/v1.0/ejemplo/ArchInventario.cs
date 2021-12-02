using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

	public class ArchInventario
	{
		private string nombre;
		
		public ArchInventario(string n)
		{
			nombre=n;
		}
		
		public void crear(){
			if(System.IO.File.Exists(nombre)){
				Console.WriteLine("Realmente quiere borrar el archivo. s/n");
				if(Console.ReadKey().KeyChar == 's'){
					System.IO.File.Delete(nombre);
				}
			}else{
				Console.WriteLine("El archivo no existe.");
			}
		}
		public void adicionar(){
			Stream arch = File.Open(nombre,FileMode.Append);
			BinaryWriter escribe = new BinaryWriter(arch);
			Inventario inv=new Inventario();
			try{
				do{
					inv.leer();
					inv.escribir(escribe);
					Console.Write("Desea continuar añadiendo Alimentos? s/n => ");
				}while(Console.ReadKey().KeyChar == 's');
			}
			catch(Exception){
				Console.WriteLine("Fallo en adicionar el objeto !!!");
			}
			finally{
				arch.Close();
			}
		}
		public void listar(){
			Stream arch = File.Open(nombre,FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			Inventario inv = new Inventario();
			try{
				while(true){
					inv.lectura(lee);
					inv.mostrar();
				}
			}
			catch(Exception){
				Console.WriteLine("Fin de archivo ...");
			}
			finally{
				arch.Close();
			}
		}
		//*********************	VERIFICA EL PRODUCTO DE MAYOR CANT EN EL AÑO X *******************************
		//****************************************************************************************************
		public void verificaProdAnio(int x){
			Stream arch = File.Open(nombre,FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			Inventario inv = new Inventario();
			Console.WriteLine("===============================================");
			try{
				while(true){
					
					inv.lectura(lee);
					inv.mayorCant(x);
				}
			}
			catch(Exception){
				Console.WriteLine("===============================================");
				Console.WriteLine("Fin de archivo ...");
			}
			finally{
				arch.Close();
			}
		}
		//******************** COMPARA AÑO X Y AÑO Y, Y MUESTRA EN QUE AÑO SE GASTO MAS EN ALIMENTOS ************************
		public void comparaAnioXY(int x,int y){
			Stream arch = File.Open(nombre,FileMode.OpenOrCreate);
			BinaryReader lee = new BinaryReader(arch);
			Inventario inv = new Inventario();
			Coordinador cor=new Coordinador();
			Console.WriteLine("===============================================");
			try{
				while(true){
					inv.lectura(lee);
					if(inv.Tipo.CompareTo("alimenticio")==0){
						inv.mayorPresAlimenticio(x,y);
					}
				}
			}
			catch(Exception){
				Console.WriteLine("===============================================");
				Console.WriteLine("Fin de archivo ...");
			}
			finally{
				arch.Close();
			}
		}
	}
