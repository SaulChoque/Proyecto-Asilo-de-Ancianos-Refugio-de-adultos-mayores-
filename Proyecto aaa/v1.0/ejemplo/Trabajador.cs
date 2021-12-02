using System;
using System.IO;
public class Trabajador: Persona
{
	private	double sueldo;
	private	string turno;
	private string tipoContratacion;
			
	public Trabajador(): base()
	{
		turno="mañana";
		sueldo=2164;
		tipoContratacion="contrato";
	}
	public Trabajador(string a, int b, string c, string n, string s, string f, int e, int d): base(n,s,f,e,d)
	{
		turno=a;
		sueldo=b;
		tipoContratacion=c;
	}
	public void leerTrabajador(){
		Console.WriteLine("------ Lectura de Datos Trabajador ------");
		base.leer();
		Console.Write("Ingrese el turno: ");
		this.turno= Leer.Cadena();
		Console.Write("Ingrese el sueldo: ");
		this.sueldo=Leer.Integer();
		Console.Write("Ingrese el tipo de contratatacion: ");
		this.tipoContratacion=Leer.Cadena();
	}
	public void mostrarTrabajador(){
		base.mostrar();
		Console.Write("\t"+turno+"\tBs."+sueldo+"\t"+tipoContratacion);
	}
	public void escribirTrabajador(BinaryWriter escritor){
        base.escribirPersona(escritor);
		escritor.Write(turno);
		escritor.Write(sueldo);
		escritor.Write(tipoContratacion);
	}
	public void lectorTrabajador(BinaryReader lector){
		base.lectorPersona(lector);
        turno=lector.ReadString();
		sueldo=lector.ReadInt32();
		tipoContratacion=lector.ReadString();
	}		
}

