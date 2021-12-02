using System;
using System.IO;
public class Medico: Trabajador, PerSalud
{
    private string especialidad;
    public Medico():base(){this.especialidad=" ";}

    public Medico(string q, string a, int b, string c, string n, string s, string f, int e, int d): base(a,b,c,n,s,f,e,d){this.especialidad=q;}
    public void leerMedico(){
        Console.WriteLine("\n------ Lectura de Datos Medico ------: ");
        base.leerTrabajador();

    }
    public void mostrarMedico(){
        base.mostrarTrabajador();
    }
	public void escribirMedico(BinaryWriter escritor){
        base.escribirTrabajador(escritor);
	}
	public void lectorMedico(BinaryReader lector){
		base.lectorTrabajador(lector);
	}		    
        
}
