using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    public class MenuAlimentos
    {
        private String dia;
        private String desayuno;
        private String merienda;
        private String sopa;
        private String almuerzo;
        private String postre;
        private String te;
        private String cena;
        //Constructor
        public MenuAlimentos()
        {
            this.dia = "Lunes";
            this.desayuno = "Cocoa con pan";
            this.merienda = "Pudin";
            this.sopa = "Quinua";
            this.almuerzo = "Revuelto de carne";
            this.postre = "Gelatina";
            this.te = "Cafe con pan";
            this.cena = "Majadito";
        }

        //Getters Setters
        public string Dia { get { return dia; } set { dia = value; } }
        public string Desayuno { get { return desayuno;} set { desayuno = value;} }
        public string Merienda { get { return merienda;} set { merienda = value;} }
        public string Almuerzo { get { return almuerzo;} set { almuerzo = value; }}
        public string Postre { get { return postre;} set { postre = value;} }
        public string Te { get { return te;} set { te = value;} }
        public string Cena { get { return cena;} set { cena = value;} }
        public string Sopa { get { return sopa;} set { sopa = value;} }

        //Leer Mostrar
        public void leer() 
        {
            Console.WriteLine("---------------------------");
            Console.Write("Ingrese dia: ");
            this.dia = Console.ReadLine();
            Console.Write("Ingrese desayuno: ");
            this.desayuno = Console.ReadLine();
            Console.Write("Ingrese merienda: ");
            this.merienda = Console.ReadLine();
            Console.Write("Ingrese sopa: ");
            this.sopa = Console.ReadLine();
            Console.Write("Ingrese almuerzo: ");
            this.almuerzo = Console.ReadLine();
            Console.Write("Ingrese postre: ");
            this.postre = Console.ReadLine();
            Console.Write("Ingrese te: ");
            this.te = Console.ReadLine();
            Console.Write("Ingrese cena: ");
            this.cena = Console.ReadLine();
            Console.WriteLine("---------------------------");
        }
        public void mostrar() 
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Dia: " + this.dia);
            Console.WriteLine("Desayuno: " + this.desayuno);
            Console.WriteLine("Merienda: " + this.merienda);
            Console.WriteLine("Sopa: " + this.sopa);
            Console.WriteLine("Almuerzo: " + this.almuerzo);
            Console.WriteLine("Postre: " + this.postre);
            //Console.WriteLine("Te: " + this.te);
            Console.WriteLine("Cena: " + this.cena);
            Console.WriteLine("-----------------------------------");
        }
        //LECTURA ESCRITURA
        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.Dia);
            escritor.Write(this.Desayuno);
            escritor.Write(this.Merienda);
            escritor.Write(this.Sopa);
            escritor.Write(this.Almuerzo);
            escritor.Write(this.Postre);
            escritor.Write(this.Te);
            escritor.Write(this.Cena);
        }
        public void lectura(BinaryReader lector)
        {
            this.dia = lector.ReadString();
            this.desayuno = lector.ReadString();
            this.merienda = lector.ReadString();
            this.sopa = lector.ReadString();
            this.almuerzo = lector.ReadString();
            this.postre = lector.ReadString();
            this.te = lector.ReadString();
            this.cena = lector.ReadString();
        }

    }
}
