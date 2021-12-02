using System;
using System.IO;


public class Anciano:Persona
{
    private bool familia;
    public Anciano():base(){this.familia=false;}

	public Anciano(bool a, string n, string s, string f, int e, int d): base(n,s,f,e,d){this.familia=a;}

    public bool Familia{get{return familia;}set{familia=value;}}
    //Leer Mostrar
    public void leerAnciano() 
    {
        Console.WriteLine("------ Lectura de Datos Anciano ------");
        base.leer();
        		Console.Write("El adulto mayor tiene familia? (s/n)=> ");
		switch( Console.ReadKey().KeyChar ) {
                    case 's':
                        this.familia=true;
                        break;
                    case 'n':
						this.familia=false;
                        break;
                    default:
						this.familia=false;
                        break;
                }
    }
    public void mostrarAnciano() 
    {
        base.mostrar();
        Console.Write("\t"+familia);
    }
    
	public void escribirAnciano(BinaryWriter escritor){
        base.escribirPersona(escritor);
		escritor.Write(familia);
	}
	public void lectorAnciano(BinaryReader lector){
		base.lectorPersona(lector);
        familia=lector.ReadBoolean();
	}		
}

