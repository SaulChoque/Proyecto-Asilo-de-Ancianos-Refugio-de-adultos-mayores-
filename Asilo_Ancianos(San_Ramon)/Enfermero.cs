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

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    public class Enfermero : Trabajador, PerSalud
    {        
        public Enfermero():base(){}
        //nombre, apellido, fechaNac, usuario, correo;sexo;edad, ci, nroCel;sueldo;turno;tipoContratacion;
        public Enfermero(string turn, double suel, string tipocon, string nom, string ape, string fech, string usu, string corr, string contr, string sex, int ed, int nci, int nroc) : base(turn, suel, tipocon, nom, ape, fech, usu, corr, contr, sex, ed, nci, nroc) { }


        public void leerEnfermero(){
            Console.WriteLine("\n------ Lectura de Datos Enfermero ------: ");
            base.leerTrabajador();
        }
        public void mostrarEnfermero(){
            Console.WriteLine("\nDATOS ENFERMERO: ");
            base.mostrar();
        }
        public void escribirEnfermero(BinaryWriter escritor){
            base.escribirTrabajador(escritor);
        }
        public void lectorEnfermero(BinaryReader lector){
            base.lectorTrabajador(lector);
        }		
    }
}
