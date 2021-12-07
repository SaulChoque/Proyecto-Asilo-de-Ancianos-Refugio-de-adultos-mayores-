using System.IO;
using System;
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
    public class EFisico
    {
        private string frecuenciaC, frecuenciaR, presionArt, temperatura, exCabeza, exCara, exOjos, exOidos, exBoca, exCuello, exTorax, exCorazon, exPulmones, exAbdomen, exGenitourinario, exAno, exExtremidades, exNeurologico;
        private double peso, talla;

        //constructor por defecto
        public EFisico()
        {
            frecuenciaC = "80/min";
            frecuenciaR = "17/min";
            presionArt = "120/75";
            temperatura = "30";
            peso = 58.7;
            talla = 1.60;
            exCabeza = "normal";
            exCara = "normal";
            exOjos = "miopia";
            exOidos = "normal";
            exBoca = "presenta caries";
            exCuello = "normal";
            exTorax = "normal";
            exCorazon = "normal";
            exPulmones = "iras";
            exAbdomen = "normal";
            exGenitourinario = "normal";
            exAno = "normal";
            exExtremidades = "normal";
            exNeurologico = "normal";
        }
        //leer
        public void leer()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tEXAMEN FISICO GENERAL");
            Console.Write("\nFrecuencia cardiaca: ");
            frecuenciaC = Console.ReadLine();
            Console.Write("\nFrecuencia respiratoria: ");
            frecuenciaR = Console.ReadLine();
            Console.Write("\nPresion Arterial: ");
            presionArt = Console.ReadLine();
            Console.Write("\nTemperatura: ");
            temperatura = Console.ReadLine();
            Console.Write("\nPeso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("\nTalla: ");
            talla = double.Parse(Console.ReadLine());
            Console.WriteLine("\t\tEXAMEN FISICO SEGMENTARIO\n");
            Console.Write("\nCabeza: ");
            exCabeza = Console.ReadLine();
            Console.Write("\nCara: ");
            exCara = Console.ReadLine();
            Console.Write("\nOjos: ");
            exOjos = Console.ReadLine();
            Console.Write("\nOídos: ");
            exOidos = Console.ReadLine();
            Console.Write("\nBoca: ");
            exBoca = Console.ReadLine();
            Console.Write("\nCuello: ");
            exCuello = Console.ReadLine();
            Console.Write("\nTórax: ");
            exTorax = Console.ReadLine();
            Console.Write("\nCorazón: ");
            exCorazon = Console.ReadLine();
            Console.Write("\nPulmones: ");
            exPulmones = Console.ReadLine();
            Console.Write("\nAbdomen: ");
            exAbdomen = Console.ReadLine();
            Console.Write("\nGenitourinario: ");
            exGenitourinario = Console.ReadLine();
            Console.Write("\nAno: ");
            exAno = Console.ReadLine();
            Console.Write("\nExtremidades: ");
            exExtremidades = Console.ReadLine();
            Console.Write("\nNeurológico: ");
            exNeurologico = Console.ReadLine();
        }
        //mostrar
        public void mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t     EXAMEN FISICO GENERAL");
            Console.WriteLine("FC: " + FrecuenciaC + "\tFR: " + FrecuenciaR + "\tPº Art: " + presionArt + "\tTº: " + temperatura + "\tPeso: " + peso + "\tTalla: " + talla);
            Console.WriteLine("\n\t\t    EXAMEN FISICO SEGMENTARIO");
            Console.WriteLine("Cabeza: " + exCabeza);
            Console.WriteLine("Cara: " + exCara);
            Console.WriteLine("Ojos: " + exOjos);
            Console.WriteLine("Oídos: " + exOidos);
            Console.WriteLine("Boca: " + exBoca);
            Console.WriteLine("Cuello: " + exCuello);
            Console.WriteLine("Tórax: " + exTorax);
            Console.WriteLine("Corazón: " + exCorazon);
            Console.WriteLine("Pulmones: " + exPulmones);
            Console.WriteLine("Abdomen: " + exAbdomen);
            Console.WriteLine("Genitourinario: " + exGenitourinario);
            Console.WriteLine("Ano: " + exAno);
            Console.WriteLine("Extremidades: " + exExtremidades);
            Console.WriteLine("Neurológico: " + exNeurologico);
        }
        //getters y setters
        public double Peso { get { return peso; } set { peso = value; } }
        public double Talla { get { return talla; } set { talla = value; } }
        public string FrecuenciaR { get { return frecuenciaR; } set { frecuenciaR = value; } }
        public string PresionArt { get { return presionArt; } set { presionArt = value; } }
        public string Temperatura { get { return temperatura; } set { temperatura = value; } }
        public string FrecuenciaC { get { return frecuenciaC; } set { frecuenciaC = value; } }
        public string ExCabeza { get { return exCabeza; } set { exCabeza = value; } }
        public string ExCara { get { return exCara; } set { exCara = value; } }
        public string ExOjos { get { return exOjos; } set { exOjos = value; } }
        public string ExOidos { get { return exOidos; } set { exOidos = value; } }
        public string ExBoca { get { return exBoca; } set { exBoca = value; } }
        public string ExCuello { get { return exCuello; } set { exCuello = value; } }
        public string ExTorax { get { return exTorax; } set { exTorax = value; } }
        public string ExCorazon { get { return exCorazon; } set { exCorazon = value; } }
        public string ExPulmones { get { return exPulmones; } set { exPulmones = value; } }
        public string ExAbdomen { get { return exAbdomen; } set { exAbdomen = value; } }
        public string ExGenitourinario { get { return exGenitourinario; } set { exGenitourinario = value; } }
        public string ExAno { get { return exAno; } set { exAno = value; } }
        public string ExExtremidades { get { return exExtremidades; } set { exExtremidades = value; } }
        public string ExNeurologico { get { return exNeurologico; } set { exNeurologico = value; } }

        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(peso);
            escritor.Write(talla);
            escritor.Write(frecuenciaC);
            escritor.Write(frecuenciaR);
            escritor.Write(presionArt);
            escritor.Write(temperatura);
            escritor.Write(exCabeza);
            escritor.Write(exOjos);
            escritor.Write(exOidos);
            escritor.Write(exBoca);
            escritor.Write(exCuello);
            escritor.Write(exCorazon);
            escritor.Write(exPulmones);
            escritor.Write(exAbdomen);
            escritor.Write(exPulmones);
            escritor.Write(exAbdomen);
            escritor.Write(exGenitourinario);
            escritor.Write(exAno);
            escritor.Write(exExtremidades);
            escritor.Write(exNeurologico);

        }
        public void lector(BinaryReader lector)
        {
            this.peso = lector.ReadDouble();
            this.talla = lector.ReadDouble();
            this.frecuenciaC = lector.ReadString();
            this.frecuenciaR = lector.ReadString();
            this.presionArt = lector.ReadString();
            this.temperatura = lector.ReadString();
            this.exCabeza = lector.ReadString();
            this.exOjos = lector.ReadString();
            this.exOidos = lector.ReadString();
            this.exBoca = lector.ReadString();
            this.exCuello = lector.ReadString();
            this.exCorazon = lector.ReadString();
            this.exPulmones = lector.ReadString();
            this.exAbdomen = lector.ReadString();
            this.exGenitourinario = lector.ReadString();
            this.exAno = lector.ReadString();
            this.exExtremidades = lector.ReadString();
            this.exNeurologico = lector.ReadString();
        }
    }
}