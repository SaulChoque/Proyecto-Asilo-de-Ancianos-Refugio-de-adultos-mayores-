using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Asilo_Ancianos_San_Ramon_
{
    [Serializable]
    class HistoriaClinica
    {
        private int codigo;
        private string fechaIngreso, gradoEscolaridad, institucion, domicilio, problematica, diagnostico, tratamiento;
        private Anamnesis A = new Anamnesis();
        private EFisico EF = new EFisico();

        //constructor por defecto
        public HistoriaClinica(){
            A = new Anamnesis();
            EF = new EFisico();
        }
        //leer
        public void leer()
        {
            Console.WriteLine("\nLEER-HISTORIACLINICA");
            Console.Write("Código: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Fecha y hora de ingreso: ");
            fechaIngreso = Console.ReadLine();
            Console.Write("Grado de escolaridad: ");
            gradoEscolaridad = Console.ReadLine();
            Console.Write("Institución: ");
            institucion = Console.ReadLine();
            Console.Write("Domicilio: ");
            domicilio = Console.ReadLine();
            Console.Write("Problemática: ");
            problematica = Console.ReadLine();
            A.leer();
            EF.leer();
            Console.Write("Diagnóstico: ");
            diagnostico = Console.ReadLine();
            Console.Write("Tratamiento: ");
            tratamiento = Console.ReadLine();
        }

        //mostrar
        public void mostrar()
        {
            Console.WriteLine("\t\t\tHISTORIA CLINICA");
            Console.WriteLine("\t\t\t\t\t\tCódigo: " + codigo);
            Console.WriteLine("\t\t\t   .:::FILIACION:::.");
            //Console.WriteLine("Nombres y apellidos: \tEdad: ");
            Console.WriteLine(/*"Fecha de Nacimiento: \t*/"Fecha y hora de ingreso: " + fechaIngreso);
            Console.WriteLine("Grado de escolaridad: " + gradoEscolaridad + "\tInstitución: " + institucion);
            Console.WriteLine("Domicilio: " + domicilio + "\tProblemática: " + problematica);
            A.mostrar();
            EF.mostrar();
            Console.WriteLine("\t\t\t   .:::DIAGNOSTICO:::.\n" + diagnostico);
            Console.WriteLine("\t\t\t   .:::TRATAMIENTO:::.\n" + tratamiento);
        }
        //*******************INTERROGANTES****************************
        //Mostrar si el refugiado con ci C en edad escolar X presenta alguna alteracion Y en la vista
        public void alteracionOf(){
            Console.Write("Ingrese grado escolar: ");
            string x = Console.ReadLine();
            Console.Write("Ingrese afección en la vista: ");
            string y = Console.ReadLine();
            if (gradoEscolaridad.ToLower() == x.ToLower() && EF.ExOjos.ToLower() == y.ToLower())
                Console.WriteLine("El refugiado tiene " + y);
            else
                Console.WriteLine("El refugiado se encuentra bien de la vista");
        }
        //Verificar si el refugiado con ci C esta por x problema en el refugio
        public void problema(){
            Console.Write("Ingrese la problemática: ");
            string x = Console.ReadLine();
            if (problematica.ToLower() == x.ToLower())
                Console.WriteLine("El refugiado se encuentra albergado por ese motivo");
            else
                Console.WriteLine("El refugiado se encuentra albergado por otros motivos");
        }
        //mostrar si el refugiado con ci C presenta alguna enfermedad X
        public void enfermedad(){
            Console.Write("Ingrese la enfermedad: ");
            string x = Console.ReadLine();
            for (int i=0; i<A.NroEnfermedades; i++) 
            {
                if (A.Enfermedades[i].ToLower() == x.ToLower())
                    Console.WriteLine("El refugiado presenta esa enfermedad, necesita ser atentido");
                else
                    Console.WriteLine("El refugiado no presenta la enfermedad mencionada");
            }

            
        }
        //mostrar los nombres de los refugiados que presentan iras o edas //nuemonia "iras", gastrointestinales "edas"
        public bool infecciones(){
            if ((EF.ExPulmones.ToLower() == "iras" || EF.ExPulmones.ToLower() == "infeccion") && (EF.ExAbdomen.ToLower() == "edas" || EF.ExAbdomen.ToLower() == "infeccion"))
                return true;
            else if (EF.ExAbdomen.ToLower() == "infeccion" && EF.ExAbdomen.ToLower() == "edas")
                return true;
            else if (EF.ExPulmones.ToLower() == "iras" && EF.ExPulmones.ToLower() == "infeccion")
                return true;
            else
                return false;
        }
        //Mostrar el número de ingresos que se registraron la fecha ‘X’
        public bool registros(string x)
        {
            if (fechaIngreso == x)
                return true;
            return false;
        }
        //getters y setters
        public int Codigo{get { return codigo; }set { codigo = value; }}
        public string FechaIngreso{get { return fechaIngreso; }set { fechaIngreso = value; }}
        public string GradoEscolaridad{get { return gradoEscolaridad; }set { gradoEscolaridad = value; }}
        public string Institucion{get { return institucion; }set { institucion = value; }}
        public string Domicilio{get { return domicilio; }set { domicilio = value; }}
        public string Problematica{get { return problematica; }set { problematica = value; }}
        public string Diagnostico{get { return diagnostico; }set { diagnostico = value; }}
        public string Tratamiento{get { return tratamiento; }set { tratamiento = value; }}
        public Anamnesis A1{get { return A; }set { A = value; }}
        public EFisico EF1{get { return EF; }set { EF = value; }}

        //lector
        public void lector(BinaryReader lector)
        {
            this.fechaIngreso = lector.ReadString();
            this.gradoEscolaridad = lector.ReadString();
            this.institucion = lector.ReadString();
            this.domicilio = lector.ReadString();
            this.problematica = lector.ReadString();
            A.lector(lector);
            EF.lector(lector);
            this.diagnostico = lector.ReadString();
            this.tratamiento = lector.ReadString();

        }
        //escritor
        public void escribir(BinaryWriter escritor)
        {
            escritor.Write(this.FechaIngreso);
            escritor.Write(this.GradoEscolaridad);
            escritor.Write(this.Institucion);
            escritor.Write(this.Domicilio);
            escritor.Write(this.Problematica);
            A.escribir(escritor);
            EF.escribir(escritor);
            escritor.Write(this.Diagnostico);
            escritor.Write(this.Tratamiento);
        }
    }
}
