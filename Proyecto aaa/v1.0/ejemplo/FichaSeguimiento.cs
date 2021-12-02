using System;
public class FichaSeguimiento
{
    private Refugiado refugiado;
    private Pedagogo pedagogo;
    private string fecha;
    private string[,,] areasAprendizaje;

    public FichaSeguimiento(){
        this.refugiado=new Refugiado();
        this.pedagogo=new Pedagogo();
        this.fecha="28/11/2021";
        this.areasAprendizaje=new string[,,]{ { { "matematicas", "lenguaje", "historia" }, { "dibujo", "cocina", "danza" } },
                                 { { "futbol", "baloncesto", "voleyball" }, { "teatro", "musica", "pintura" } } };
    }
    public Refugiado Refugiado{get{return refugiado;}set{refugiado=value;}}
    public Pedagogo Pedagogo{get{return pedagogo;}set{pedagogo=value;}}    
    public string Fecha{get{return fecha;}set{fecha=value;}}
    public string[,,] AreasAprendizaje{get{return areasAprendizaje;}set{areasAprendizaje=value;}}

    public void mostrar(){
        Console.WriteLine("\nFICHA SEGUIMIENTO");
        Console.WriteLine("Datos refugiado: ");
        refugiado.mostrar();
        Console.WriteLine("Datos pedagogo: ");
        pedagogo.mostrar();
        Console.WriteLine("Fecha: "+fecha);
        Console.WriteLine("Areas de aprendizaje");
        for (int i=0; i < 3; i++)
        {
            for (int j=0; j<3; j++)
            {
                for (int k=0; k<3; k++)
                {
                    Console.WriteLine(" -"+areasAprendizaje[i,j,k]); 
                    
                }
            }
        }
    }

    public void leer(){
        Console.WriteLine("\nDATOS FICHA SEGUIMIENTO");
        Console.WriteLine("Datos refugiado: ");
        refugiado.leer();
        Console.WriteLine("Datos pedagogo: ");
        pedagogo.leer();
        Console.Write("Inserte Fecha: ");
        this.fecha=Leer.Cadena();
        Console.WriteLine("Inserte areas de aprendizaje:");
        for (int i=0; i < 3; i++)
        {
            for (int j=0; j<3; j++)
            {
                for (int k=0; k<3; k++)
                {
                    this.areasAprendizaje[i,j,k]=Leer.Cadena();  
                }
            }
        }
    }

        
}
