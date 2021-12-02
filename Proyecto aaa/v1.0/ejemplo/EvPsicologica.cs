using System;
using System.IO;
public class EvPsicologica
{
	private
		Anciano anciano;
		Psicologo psicologo;
		string fecha, problema, desarrollo, indicadorPsico;
		
	public 
		EvPsicologica()
		{
			anciano = new Anciano();
			psicologo = new Psicologo();
			fecha="";
			problema="";
			desarrollo="";
			indicadorPsico="";
		}
		EvPsicologica(Anciano r, Psicologo p, string f, string pr, string d,string i)
		{
			anciano = r;
			psicologo = p;
			fecha=f;
			problema=pr;
			desarrollo=d;
			indicadorPsico=i;
		}

		void leer(){
			Console.WriteLine("------------ Lectura Datos Evaluacion Psicologica ----------");
			anciano.leerAnciano();
			psicologo.leerPsicologo();
			Console.WriteLine("Ingrese la fecha: ");
			fecha = Leer.Cadena();
			Console.WriteLine("Ingrese la problematica: ");
			problema = Leer.Cadena();
			Console.WriteLine("Ingrese el desarrollo: ");
			desarrollo = Leer.Cadena();
			Console.WriteLine("Ingrese el/los indicadores psicologicos observados: ");
			indicadorPsico = Leer.Cadena();
		}
		void mostrar(){
			Console.WriteLine("+++++++++++ FICHA DE SEGUIMIENTO PSICOLOGICO +++++++++++");
			Console.WriteLine("Nombre y Apellido: "+anciano.Nombre);
			Console.WriteLine("Edad: "+anciano.Edad+".......... Fecha: "+this.fecha);
			Console.WriteLine("Problematica: "+this.problema);
			Console.WriteLine("----- Desarrollo --------");
			Console.WriteLine(this.desarrollo);
			Console.WriteLine("----- Indicadores Psicologicos --------");
			Console.WriteLine(this.indicadorPsico);
		}
	public void escribirEvPsicologica(BinaryWriter escritor){
        anciano.escribirAnciano(escritor);
		psicologo.escribirPsicologo(escritor);
		escritor.Write(fecha);
		escritor.Write(desarrollo);
		escritor.Write(problema);
		escritor.Write(indicadorPsico);
	}
	public void lectorEvPsicologica(BinaryReader lector){
		anciano.lectorAnciano(lector);
		psicologo.lectorPsicologo(lector);
        fecha=lector.ReadString();
		desarrollo=lector.ReadString();
		problema=lector.ReadString();
		indicadorPsico=lector.ReadString();

	}		
}

