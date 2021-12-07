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
    public class Medico:Trabajador, PerSalud
        {
            private String especialidad;
            //CONSTRUCTORES
            public Medico() : base() {}
            public Medico(string esp, string turn, double suel, string tipocon, string nom, string ape, string fech, string usu, string corr, string contr, string sex, int ed, int nci, int nroc) : base(turn, suel, tipocon, nom, ape, fech, usu, corr, contr, sex, ed, nci, nroc)
            {
                this.especialidad = esp;
            }

            //Getters Setters
            public string Especialidad { get { return especialidad; } set { especialidad = value; } }
            //Leer mostrar
            public void leerMedico() 
            {
                Console.WriteLine("LEER-DOCTOR");
                base.leer();
                Console.WriteLine("Ingrese especialidad: ");
                this.especialidad = Console.ReadLine();
            }
            public void mostrarMedico()
            {
                base.mostrar();
                Console.WriteLine("Especialidad: "+this.especialidad);
            }
            //lectura escritura
            public void escribirMedico(BinaryWriter escritor){
                base.escribirTrabajador(escritor);
            }
            public void lectorMedico(BinaryReader lector){
                base.lectorTrabajador(lector);
            }		    
            
    }
}
