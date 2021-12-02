using System;
using System.IO;
public class Psicologo : Medico,PerSalud
{
	private string especialidad;
	
	public Psicologo() : base(){especialidad="";}
	public Psicologo(string r, string q, string a, int b, string c, string n, string s, string f, int e, int d): base(q,a,b,c,n,s,f,e,d){this.especialidad=r;}


	public void leerPsicologo(){
			Console.WriteLine("---- Ingrese los datos del psicologo ----");
			base.leer();
			especialidad= Leer.Cadena();
			}
	public void mostrarPsicologo(){
			base.mostrar();
			Console.Write("\t"+especialidad);
		}
	public void escribirPsicologo(BinaryWriter escritor){
        base.escribirMedico(escritor);
		escritor.Write(especialidad);

	}
	public void lectorPsicologo(BinaryReader lector){
		base.lectorMedico(lector);
        especialidad=lector.ReadString();
	}
}
