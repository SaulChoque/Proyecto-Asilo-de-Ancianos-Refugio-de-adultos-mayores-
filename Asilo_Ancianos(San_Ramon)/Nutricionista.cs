using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    public class Nutricionista : Trabajador, PerSalud
    {

        MenuAlimentos[] MS = new MenuAlimentos[7];
        private String fechaInicio, fechaFin;
        //Constructor


        public MenuAlimentos[] MenuAlimentos{ get{ return MS; }set{ MS = value; } }
        public Nutricionista() : base(){}

        public Nutricionista(string turn, double suel, string tipocon, string nom, string ape, string fech, string usu, string corr, string contr, string sex, int ed, int nci, int nroc) : base(turn, suel, tipocon, nom, ape, fech, usu, corr, contr, sex, ed, nci, nroc) { }

        //Getters Setters
        //public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        //public string FechaFin { get => fechaFin; set => fechaFin = value; }

        //Leer Mostrar
        public void leerNutricionista()
        {
            base.leer();
        }
        public void mostrarNutricionista()
        {
            Console.WriteLine("MOSTRAR-NUTRICIONISTA");
            base.leer();
        }

        //INTERROGANTE
        public void leerMenuSemanal()
        {
            Console.WriteLine("Ingrese fecha de inicio (dd/mm/aaaa): ");
            this.fechaInicio = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de final (dd/mm/aaaa): ");
            this.fechaFin = Console.ReadLine();
            Console.WriteLine("LEER-MENU SEMANAL");
            for (int i = 1; i < MS.Length - 1; i++)
            {
                MS[i].leer();
            }
        }
        public void mostrarMenuSemanal()
        {
            Console.WriteLine(".:MENU SEMANAL:.");
            Console.WriteLine("Fecha de inicio: " + this.fechaInicio);
            Console.WriteLine("Fecha de fin: " + this.fechaFin);
            for (int i = 1; i <= MS.Length - 1; i++)
            {
                MS[i].mostrar();
            }
        }

        public void addMenu(int i, MenuAlimentos a)
        {
            MS[i] = a;
        }
        public bool verificarFecha(String fecha) 
        {
            if (fecha.Equals(fechaInicio)) 
            {
                return true;
            }
            return false;
        }
        public void mostrarMenuFechaDia(String fecha, String dia) 
        {
            if (fecha.Equals(fechaInicio))
            {
                for (int i = 0; i <MS.Length - 1; i++)
                {
                    if (MS[i].Dia.ToUpper().Equals(dia)){
                        Console.WriteLine(".:MENU SEMANAL DE DIA Y FECHA ESPECIFICO:.");
                        Console.WriteLine("Fecha de inicio: " + this.fechaInicio);
                        Console.WriteLine("Fecha de fin: " + this.fechaFin);
                        MS[i].mostrar();
                    }
                }
            }
        }
        //LECTURA ESCRITURA
        public void escribirNutricionista(BinaryWriter escritor)
        {
            base.escribirTrabajador(escritor);
            escritor.Write(this.fechaInicio);
            escritor.Write(this.fechaFin);
            for (int i = 0; i < MS.Length - 1; i++)
            {
                MS[i].escribir(escritor);
            }
        }
        public void lectorNutricionista(BinaryReader lector)
        {
            base.lectorTrabajador(lector);
            fechaInicio = lector.ReadString();
            fechaFin = lector.ReadString();
            for (int i = 0; i < MS.Length - 1; i++)
            {
                MS[i].lectura(lector);
            }
        }
    }
}
