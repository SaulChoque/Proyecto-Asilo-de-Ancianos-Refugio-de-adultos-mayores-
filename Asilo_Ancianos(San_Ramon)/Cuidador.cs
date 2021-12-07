using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    public class Cuidador: Trabajador, PerTecnico
    {
        private string tipo;

        public Cuidador(): base(){}
        public Cuidador(string tip,string turn, double suel, string tipocon, string nom, string ape, string fech, string usu, string corr, string contr, string sex, int ed, int nci, int nroc) : base(turn, suel, tipocon, nom, ape, fech, usu, corr, contr, sex, ed, nci, nroc) 
        {
            this.tipo = tip;
        }

        public string Tipo{get{return tipo;}set{tipo=value;}}
        
        public void leerCuidador(){
            Console.WriteLine("\n------ Lectura de Datos Cuidador ------");
            Console.WriteLine("Inserte la especialidad del Cuidador: ");
            this.tipo=Leer.Cadena();
            base.leer();
        }
        public void mostrarCuidador(){
            base.mostrar();
            Console.Write("\t"+tipo);
        }
        public void escribirCuidador(BinaryWriter escritor){
            base.escribirTrabajador(escritor);
            escritor.Write(this.tipo);
        }
        public void lectorCuidador(BinaryReader lector){
            base.lectorTrabajador(lector);
            this.tipo=lector.ReadString();
        }	
    }
}