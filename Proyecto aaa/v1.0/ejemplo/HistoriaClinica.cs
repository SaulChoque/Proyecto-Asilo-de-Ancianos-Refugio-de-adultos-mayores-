using System;
using System.IO;


    public class HistoriaClinica
    {
        private int codigo;
        private string fechaIngreso, gradoEscolaridad, institucion, domicilio, problematica, diagnostico, tratamiento;
        private Anamnesis A = new Anamnesis();
        private EFisico EF = new EFisico();

        //constructor por defecto
        public HistoriaClinica() { 
            codigo = 1524;
            fechaIngreso = "12-10-2021";
            gradoEscolaridad = "Secundaria";
            institucion = "Max valdivia";
            domicilio = "Calle las dalias";
            problematica = "Abandono";
            A = new Anamnesis();
            EF = new EFisico();
            diagnostico = "Sufre leves afecciones en ojos, boca y presenta iras en los pulmones";
            tratamiento = "Derivacion a oftalmologo, requiere uso de lentes\nRequiere curacion en primer y segundo molar\nTratamiento urgente contra la neumonía presentada en los pulmones";
        }
        //leer
        public void leer()
        {
            Console.WriteLine();
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
            Console.WriteLine("\t\t\t   FILIACION");
            //Console.WriteLine("Nombres y apellidos: \tEdad: ");
            Console.WriteLine(/*"Fecha de Nacimiento: \t*/"Fecha y hora de ingreso: " + fechaIngreso);
            Console.WriteLine("Grado de escolaridad: " + gradoEscolaridad + "\tInstitución: " + institucion);
            Console.WriteLine("Domicilio: " + domicilio + "\tProblemática: " + problematica);
            A.mostrar();
            EF.mostrar();
            Console.WriteLine("\t\t\t   DIAGNOSTICO\n" + diagnostico);
            Console.WriteLine("\t\t\t   TRATAMIENTO\n" + tratamiento);
        }
        //Mostrar si el refugiado en edad escolar X presenta alguna alteracion Y en la vista
        public void alteracionOf() {
            Console.WriteLine();
            Console.Write("Ingrese grado escolar: ");
            string x = Console.ReadLine();
            Console.Write("Ingrese afección en la vista: ");
            string y = Console.ReadLine();
            if (gradoEscolaridad.ToLower() == x && EF.ExOjos == y)
                Console.WriteLine("El refugiado tiene " + y);
            else
                Console.WriteLine("El refugiado se encuentra sano de la vista");
        }
        //Verificar si el refugiado esta por x problema en el refugio
        public void problema() {
            Console.WriteLine();
            Console.Write("Ingrese la problemática: ");
            string x = Console.ReadLine();
            if (problematica.ToLower() == x)
                Console.WriteLine("El refugiuado si se encuentra albergado por ese problema");
            else
                Console.WriteLine("El refugiado se encuentra albergado por otros motivos");
        }
        //mostrar si el refugiado presenta alguna enfermedad X
        public void enfermedad() {
            Console.WriteLine();
            Console.Write("Ingrese la enfermedad: ");
            string x = Console.ReadLine();
            if (A.Enfermedades.ToLower() == x)
                Console.WriteLine("El refugiado si presenta esa enfermedad, necesita ser atentido");
            else
                Console.WriteLine("El refugiado no presenta la enfermedad mencionada");
        }
        //mostrar si el refugiado presenta iras o edas //nuemonia "iras", gastrointestinales "edas"
        public void infecciones() {
            Console.WriteLine();
            if (EF.ExPulmones.ToLower() == "iras"  && EF.ExAbdomen.ToLower() == "edas")
                Console.WriteLine("El refugiado presenta iras y edas");
            else if (EF.ExPulmones.ToLower() != "iras" && EF.ExAbdomen.ToLower() == "edas")
                Console.WriteLine("El refugiado presenta edas");
            else
                Console.WriteLine("El refugiado presenta iras");
        }
        //getters y setters
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public string GradoEscolaridad
        {
            get { return gradoEscolaridad; }
            set { gradoEscolaridad = value; }
        }
        public string Institucion
        {
            get { return institucion; }
            set { institucion = value; }
        }
        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }
        public string Problematica
        {
            get { return problematica; }
            set { problematica = value; }
        }
        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
        public string Tratamiento
        {
            get { return tratamiento; }
            set { tratamiento = value; }
        }
        internal Anamnesis A1
        {
            get { return A; }
            set { A = value; }
        }
        internal EFisico EF1
        {
            get { return EF; }
            set { EF = value; }
        }
    }

