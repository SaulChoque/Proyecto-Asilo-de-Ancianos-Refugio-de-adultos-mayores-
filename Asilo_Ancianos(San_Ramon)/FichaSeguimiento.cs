using System;
using System.Collections.Generic;
using System.IO;
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
    public class FichaSeguimiento
    {
        private Anciano anciano;
        private Cuidador cuidador;
        private string fecha;
        List<(string, string, string)> areasAprendizajeL;
        private string[] areasAprendizaje = new string[30];
        private int nr;

        public FichaSeguimiento() { }
        public Anciano Anciano { get { return anciano; } set { anciano = value; } }
        public Cuidador Cuidador { get { return cuidador; } set { cuidador = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }

        public void mostrarFicha()
        {
            Console.WriteLine("\n------ Ficha Seguimiento ------");
            Console.WriteLine("Datos Refugiado: ");
            anciano.mostrarAnciano();
            Console.WriteLine("Datos pedagogo: ");
            anciano.mostrarAnciano();
            Console.WriteLine("Fecha: " + fecha);
            Console.WriteLine("--Areas aprendizaje");
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine(areasAprendizaje[i]);
            }

        }

        public void leerFicha()
        {
            this.anciano.leer();
            this.cuidador.leer();
            Console.Write("Inserte Fecha => ");
            this.fecha = Leer.Cadena();
            do
            {
                string s1, s2, s3;
                Console.Write("\nInserte hora atencion 1 => ");
                s1 = Leer.Cadena();
                Console.WriteLine("\nInserte Area aprendizaje 2 => ");
                s2 = Leer.Cadena();
                Console.WriteLine("\nInserte Area aprendizaje 3 => ");
                s3 = Leer.Cadena();
                areasAprendizajeL.Add((s1 + "//", s2 + "//", s3));
                Console.WriteLine("Desea continuar añadiendo Areas?. s/n: ");
            } while (Console.ReadKey().KeyChar == 's');
            foreach (var lir in areasAprendizajeL)
            {
                areasAprendizaje[nr] = lir.ToString();
                nr = nr + 1;
            }
        }
        public void escribirFicha(BinaryWriter escritor)
        {
            anciano.escribirAnciano(escritor);
            cuidador.escribirCuidador(escritor);
            escritor.Write(fecha);
            escritor.Write(nr);
            for (int i = 0; i < nr; i++)
            {
                escritor.Write(areasAprendizaje[i]);
            }
        }
        public void lectorFicha(BinaryReader lector)
        {
            anciano.lectorAnciano(lector);
            cuidador.lectorCuidador(lector);
            fecha = lector.ReadString();
            nr = lector.ReadInt32();
            for (int i = 0; i < nr; i++)
            {
                areasAprendizaje[i] = lector.ReadString();
            }
        }
    }
}