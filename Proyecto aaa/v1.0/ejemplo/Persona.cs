using System;
using System.IO;
public class Persona
{
	protected
		string nombre, fechaNac;
		string sexo;
		int edad;
		int ci;

	
	public Persona()
	{
		nombre ="";
		sexo="Masculino";
		fechaNac="";
		edad=0;
		ci=0;
	}


	public Persona(string a, string b, string c, int d, int e)
	{
		nombre =a;
		sexo=b;
		fechaNac=c;
		edad=d;
		ci=e;
	}

	public string Nombre{get{return nombre;}set{nombre=value;}}
	public string Sexo{get{return sexo;}set{sexo=value;}}
	public string FechaNac{get{return fechaNac;}set{fechaNac=value;}}
	public int Edad{get{return edad;}set{edad=value;}}
	public int Ci{get{return ci;}set{ci=value;}}

	public void leer(){
		Console.WriteLine("------ Lectura de Datos personales ------");
		Console.Write("Ingrese el nombre: ");
		this.nombre=Leer.Cadena();
		Console.Write("Ingrese el sexo (f/m)=> ");
		switch( Console.ReadKey().KeyChar ) {
                    case 'f':
                        this.sexo="Femenino";
                        break;
                    case 'm':
						this.sexo="Masculino";
                        break;
                    default:
						this.sexo="Masculino";
                        break;
                }
		Console.Write("Ingrese la fecha de nacimiento (DD/MM/AAAA): ");
		this.fechaNac=Leer.Cadena();
		Console.Write("Ingrese la edad: ");
		this.edad=Leer.Integer();
		Console.Write("Ingrese el numero de carnet: ");
		this.ci=Leer.Integer();
	}
	public void mostrar(){
		Console.Write("\n"+nombre+"\t\t\t"+edad+" "+fechaNac+" "+sexo+"\t"+ci);
	}

	public void escribirPersona(BinaryWriter escritor){
        escritor.Write(nombre);
		escritor.Write(sexo);
		escritor.Write(fechaNac);
		escritor.Write(edad);
		escritor.Write(ci);
	}
	public void lectorPersona(BinaryReader lector){
        nombre=lector.ReadString();
		sexo=lector.ReadString();
		fechaNac=lector.ReadString();
		edad=lector.ReadInt32();
		ci=lector.ReadInt32();
	}
}