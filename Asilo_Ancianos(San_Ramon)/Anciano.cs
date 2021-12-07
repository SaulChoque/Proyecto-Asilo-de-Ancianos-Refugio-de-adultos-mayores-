using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asilo_Ancianos_San_Ramon_{
    [Serializable]
    public class Anciano:Persona
    {
        private bool familia;
        public Anciano():base()
        {
            this.familia=false;
            this.usuario = string.Empty;
            this.contraseña = string.Empty;
            this.correo = string.Empty;
        }

        public Anciano(bool fam,string nom, string ape, string fech, string usu, string corr,string contr, string sex, int ed, int nci, int nroc) : base(nom, ape, fech, usu, corr, contr, sex, ed, nci, nroc)
        {
            this.familia = fam;
            this.familia = false;
            this.usuario = string.Empty;
            this.contraseña = string.Empty;
            this.correo = string.Empty;
        }
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
}

