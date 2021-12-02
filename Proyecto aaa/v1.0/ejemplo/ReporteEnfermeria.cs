using System;
using System.Collections.Generic;
using System.IO;
public class ReporteEnfermeria
{
    private Anciano anciano;
    private Enfermero enfermero;
    private string fecha;
    List<(string, string, string)> reporte;
    private string hora;
    private string procedimiento;    
    private string descripcionSintomas;

    //constructor por defecto
    public ReporteEnfermeria(){
        this.anciano=new Anciano();
        this.enfermero=new Enfermero();
        this.fecha="28/11/2020";
        this.hora="20:00";
        this.procedimiento= "Administracion de ibuprofeno";
        this.descripcionSintomas= "Fiebre y malestares gastricos por parte del paciente";
        this.reporte=new List<(string, string, string)>();
    }
        public Anciano Anciano{get{return anciano;}set{anciano=value;}}
        public Enfermero Enfermero{get{return enfermero;}set{enfermero=value;}}    
        public string Fecha{get{return fecha;}set{fecha=value;}}
        public string Hora{get{return hora;}set{hora=value;}}
        public string Procedimiento{get{return procedimiento;}set{procedimiento=value;}}
        public string DescripcionSintomas{get{return descripcionSintomas;}set{descripcionSintomas=value;}} 

        public void leer(){
            Console.WriteLine("\n-----------Lectura reporte Enfermeria-----------");
            Console.WriteLine("Inserte datos refugiado");
            anciano.leerAnciano();
            Console.WriteLine("Inserte datos enfermer@");
            enfermero.leerEnfermero();
            Console.Write("Inserte Fecha => ");
            this.fecha=Leer.Cadena();
            do{
                Console.Write("\nInserte Hora => ");
                this.hora=Leer.Cadena();
                Console.WriteLine("\nEscriba el procedimiento");
                this.procedimiento=Leer.Cadena();
                Console.WriteLine("\nDescriba los sintomas");
                this.descripcionSintomas=Leer.Cadena();
                reporte.Add((hora,procedimiento,descripcionSintomas));
                Console.WriteLine("Desea continuar añadiendo Reportes?. s/n: ");
		    }while(Console.ReadKey().KeyChar=='s');

        }
        public void mostrar(){
            Console.WriteLine("Nombre paciente"+"\tNombre enfermero(a)"+"\tfecha");
            Console.WriteLine(anciano.Nombre+"\t"+enfermero.Nombre+"\t"+fecha+"\t");
            Console.WriteLine("Hora"+"\tProcedimiento"+"\tSintomas");
            foreach (var lir in reporte)
            {
                Console.WriteLine(lir);
            }
        }     
	public void escribirReporteEnfermeria(BinaryWriter escritor){
        anciano.escribirAnciano(escritor);
        enfermero.escribirEnfermero(escritor);
        foreach (var idr in reporte)
        {
            escritor.Write(idr.ToString());
            
        }
	}
	public void lectorReporteEnfermeria(BinaryReader lector){
        anciano.lectorAnciano(lector);
        enfermero.lectorEnfermero(lector);
        foreach (var idr in reporte)
        {
            string jijijija=idr.ToString();
            jijijija=lector.ReadString();
        }
	}	  
}
