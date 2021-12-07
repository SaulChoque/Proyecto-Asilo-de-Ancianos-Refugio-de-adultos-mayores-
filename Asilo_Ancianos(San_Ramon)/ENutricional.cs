using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    public class ENutricional
    {
        private String fechaEvaluacion;
        private double peso;
        private double talla;
        //Constructor
        public ENutricional()
        {
            this.fechaEvaluacion = "26/11/2021";
            this.peso = 50.5;
            this.talla = 160;
        }
        //Getters Setters
        public string FechaEvaluacion { get { return fechaEvaluacion;} set{ fechaEvaluacion = value;} }
        public double Peso { get { return peso;} set { peso = value;} }
        public double Talla { get { return talla;} set {talla = value;} }
        //Leer Mostrar
        public void leer()
        {
            Console.WriteLine("LEER-EVALUACION NUTRICIONAL");
            Console.Write("Ingrese fecha de evaluacion: ");
            this.fechaEvaluacion = Console.ReadLine();
            Console.Write("Ingrese peso [kg]: ");
            this.peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese talla [cm]: ");
            this.talla = double.Parse(Console.ReadLine());
        }
        public void mostrar()
        {
            Console.WriteLine("\t\t\tEVALUACION NUTRICIONAL");
            Console.WriteLine("Fecha de evaluacion: " + this.fechaEvaluacion);
            Console.WriteLine("Peso: " + this.peso);
            Console.WriteLine("Talla: " + this.talla);
        }
        public void valoracionNutricional(){
            
        }
        //LECTURA ESCRITURA
        public void escritor(BinaryWriter escritor)
        {
            escritor.Write(this.FechaEvaluacion);
            escritor.Write(this.Peso);
            escritor.Write(this.Talla);
        }
        public void lectura(BinaryReader lector)
        {
            this.fechaEvaluacion = lector.ReadString();
            this.peso = lector.ReadDouble();
            this.talla = lector.ReadDouble();
        }
    }
}
