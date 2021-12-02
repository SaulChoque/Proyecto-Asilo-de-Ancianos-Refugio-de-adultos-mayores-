using System;
public class Cuidador: Trabajador, PerTecnico
{
    private string especialidad;

    public Cuidador(): base(){}

    public string Especialidad{get{return especialidad;}set{especialidad=value;}}
    
    public void leer(){
        Console.WriteLine("\nLECTURA DATOS CUIDADOR");
        this.especialidad=Leer.Cadena();
        base.leer();
    }
    public void mostrar(){
        Console.WriteLine("\nDATOS PEDAGOGO");
        Console.WriteLine("Especialidad: "+especialidad);
        base.mostrar();
    }
}
