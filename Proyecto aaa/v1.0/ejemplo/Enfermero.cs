using System;
using System.IO;
public class Enfermero : Trabajador, PerSalud
{        
    public Enfermero():base(){}
    public Enfermero(string a, int b, string c, string n, string s, string f, int e, int d): base(a,b,c,n,s,f,e,d){}


    public void leerEnfermero(){
        Console.WriteLine("\n------ Lectura de Datos Enfermero ------: ");
        base.leerTrabajador();
    }
    public void mostrarEnfermero(){
        base.mostrarTrabajador();
    }
	public void escribirEnfermero(BinaryWriter escritor){
        base.escribirTrabajador(escritor);
	}
	public void lectorEnfermero(BinaryReader lector){
		base.lectorTrabajador(lector);
	}		
}
