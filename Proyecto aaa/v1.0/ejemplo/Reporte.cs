using System;
using System.Collections.Generic;
using System.Text;

    public class Reporte
    {
        Refugiado refugiado;
        Medico medico;
        HistoriaClinica H;
        private String fechaIngreso;
        private String defensoria;
        private String problematica;
        private String derivacion;
        private int tiempoPermanencia; //Se contabiliza en dias
                                       //cada dia que pasa se tiene que incrementar en uno
                                       //y al momento de eliminar un refugiado se tiene que ir con
                                       //el registro de cuantos dias estuvo en el refugio

        //Constructor
        public Reporte()
        {
            refugiado = new Refugiado();
            medico = new Medico();
            H = new HistoriaClinica();
            this.fechaIngreso = "25/11/2021";
            this.defensoria = "Especializada Hogares";
            this.problematica = "Abandono De Hogar";
            this.derivacion = "Linea 156";
            this.tiempoPermanencia = 0;
        }
        //Getters Setters
        public Medico Medico { get => medico; set => medico = value; }
        public HistoriaClinica H1 { get => H; set => H = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Defensoria { get => defensoria; set => defensoria = value; }
        public string Problematica { get => problematica; set => problematica = value; }
        public string Derivacion { get => derivacion; set => derivacion = value; }
        public int TiempoPermanencia { get => tiempoPermanencia; set => tiempoPermanencia = value; }
        internal Refugiado Refugiado { get => refugiado; set => refugiado = value; }
        //Leer Mostrar
        public void leer()
        {
            Console.WriteLine("LEER-REPORTE");
            //Datos del refugiado
            Console.Write("Ingrese fecha de ingreso: ");
            this.fechaIngreso = Console.ReadLine();
            Console.Write("Ingrese defensoria: ");
            this.defensoria = Console.ReadLine();
            refugiado.leer();
            Console.Write("Ingrese problematica: ");
            this.problematica = Console.ReadLine();
            Console.Write("Ingrese derivacion: ");
            this.derivacion = Console.ReadLine();
            //Tiempo de permanencia
            this.tiempoPermanencia = 0;
            //Datos del medico que tomo el registro
            Console.WriteLine("\nMedico que tomo el registro: ");
            medico.leer();
        }
        public void mostrar()
        {
            Console.WriteLine("MOSTRAR-REPORTE");
            Console.WriteLine("Fecha de ingreso: " + this.fechaIngreso);
            Console.WriteLine("Defensoria: " + this.fechaIngreso);
            refugiado.mostrar();
            Console.WriteLine("Problematica: " + this.problematica);
            Console.WriteLine("Derivacion: " + this.derivacion);
            //Ojo con el tiempo de permanencia, debe tener otro metodo y cuando pidan mostrar
            //se utiliza ese metodo tambien
            Console.WriteLine("\nMedico que tomo el registro: ");
            medico.mostrar();
        }
    }
