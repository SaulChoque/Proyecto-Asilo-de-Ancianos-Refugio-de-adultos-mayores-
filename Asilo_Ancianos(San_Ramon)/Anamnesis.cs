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
    public class Anamnesis
    {
        private int nroCirugias, nroInternaciones;
        private int ne, na, nm;
        private string[] enfermedades, alergias, medicamentos;
        private bool consumoDrogas, fuma, consumoBebidas, relacionesSexuales;

        //constructor por defecto
        public Anamnesis()
        {
            nroCirugias = 2;
            nroInternaciones = 2;
            enfermedades = new string[10];
            alergias = new string[10];
            fuma = false;
            consumoBebidas = false;
            consumoDrogas = false;
            medicamentos = new string[10];
            relacionesSexuales = false;
            ne = 0; na = 0; nm = 0;
        }
        //leer
        public void leer()
        {
            Console.WriteLine();
            Console.Write("\nNumero de Cirugías => ");
            nroCirugias = Leer.Integer();
            Console.Write("\nNumero de Internaciones: ");
            nroInternaciones = Leer.Integer();
            Console.Write("\nEnfermedades: ");
            try
            {
                do
                {
                    Console.Write("\ninserte enfermerdad=> ");
                    enfermedades[ne] = Leer.Cadena();
                    ne++;
                    Console.WriteLine("Desea continuar añadiendo Enfermedades?. s/n: ");
                } while (Console.ReadKey().KeyChar == 's');
            }
            catch (Exception) { Console.WriteLine("Lista de Enfermedades llena!"); }

            Console.Write("\nAlergias: ");
            try
            {
                do
                {
                    Console.Write("\ninserte alergia=> ");
                    alergias[na] = Leer.Cadena();
                    na++;
                    Console.WriteLine("Desea continuar añadiendo Alergias?. s/n: ");
                } while (Console.ReadKey().KeyChar == 's');
            }
            catch (Exception) { Console.WriteLine("Lista de Alergias llena!"); }

            Console.Write("\nMedicamentos: ");
            try
            {
                do
                {
                    Console.Write("\ninserte medicamento=> ");
                    medicamentos[nm] = Leer.Cadena();
                    nm++;
                    Console.WriteLine("Desea continuar añadiendo Medicamentos?. s/n: ");
                } while (Console.ReadKey().KeyChar == 's');
            }
            catch (Exception) { Console.WriteLine("Lista de Medicamentos llena!"); }
            Console.Write("\nFuma(s/n): ");
            fuma = Leer.Bool();
            Console.Write("\nBebidas Alcohólicas(s/n): ");
            consumoBebidas = Leer.Bool();
            Console.Write("\nDrogas(s/n): ");
            consumoDrogas = Leer.Bool();
            Console.Write("\nRelaciones sexuales(s/n): ");
            relacionesSexuales = Leer.Bool();
        }
        //mostrar
        public void mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t   ANAMNESIS");
            Console.WriteLine("APP. Cirugías: " + nroCirugias + "\tInternaciones: " + nroInternaciones + "\tEnfermedades: " + enfermedades + "\tAlergias: " + alergias);
            Console.WriteLine("APNP. Fuma: " + fuma + "\tBebidas alcohólicas: " + consumoBebidas + "\tDrogas: " + consumoDrogas + "\tMedicamnetos: " + medicamentos);
            Console.WriteLine("Relaciones sexuales: " + relacionesSexuales);
        }
        //getters y setters

        public bool ConsumoBebidas { get { return consumoBebidas; } set { consumoBebidas = value; } }
        public bool Fuma { get { return fuma; } set { fuma = value; } }
        public int NroInternaciones { get { return nroInternaciones; } set { nroInternaciones = value; } }
        public int NroCirugias { get { return nroCirugias; } set { nroCirugias = value; } }
        public int NroEnfermedades { get { return ne; } set { ne = value; } }
        public string[] Enfermedades { get { return enfermedades; } set { enfermedades = value; } }
        public string[] Alergias { get { return alergias; } set { alergias = value; } }
        public string[] Medicamentos { get { return medicamentos; } set { medicamentos = value; } }
        public bool ConsumoDrogas { get { return consumoDrogas; } set { consumoDrogas = value; } }
        public bool RelacionesSexuales { get { return relacionesSexuales; } set { relacionesSexuales = value; } }


        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(nroCirugias);
            escritor.Write(nroInternaciones);
            escritor.Write(ne);
            escritor.Write(na);
            escritor.Write(nm);
            escritor.Write(consumoDrogas);
            escritor.Write(fuma);
            escritor.Write(consumoBebidas);
            escritor.Write(relacionesSexuales);
            for (int i = 0; i < ne; i++) { escritor.Write(enfermedades[i]); }
            for (int i = 0; i < na; i++) { escritor.Write(alergias[i]); }
            for (int i = 0; i < nm; i++) { escritor.Write(medicamentos[i]); }
        }
        public void lector(BinaryReader lector)
        {
            nroCirugias = lector.ReadInt32();
            nroInternaciones = lector.ReadInt32();
            ne = lector.ReadInt32();
            na = lector.ReadInt32();
            nm = lector.ReadInt32();
            consumoDrogas = lector.ReadBoolean();
            fuma = lector.ReadBoolean();
            consumoBebidas = lector.ReadBoolean();
            relacionesSexuales = lector.ReadBoolean();
            for (int i = 0; i < ne; i++) { enfermedades[i] = lector.ReadString(); }
            for (int i = 0; i < na; i++) { alergias[i] = lector.ReadString(); }
            for (int i = 0; i < nm; i++) { medicamentos[i] = lector.ReadString(); }
        }
    }
}
