using System;
    class Anamnesis
    {
        private int nroCirugias, nroInternaciones;
        private string enfermedades, alergias, medicamentos, menarca, fum;
        private char consumoDrogas, fuma, consumoBebidas, anticoncepcion, relacionesSexuales;

        //constructor por defecto
        public Anamnesis() {
            nroCirugias = 2;
            nroInternaciones = 2;
            enfermedades = "ninguna";
            alergias = "mani";
            fuma = 'n';
            consumoBebidas = 'n';
            consumoDrogas = 'n';
            medicamentos = "ninguno";
            menarca = "no aplica";
            fum = "no aplica";
            relacionesSexuales = 'n';
            anticoncepcion = 'n';
        }
        //leer
        public void leer()
        {
            Console.WriteLine();
            Console.Write("Cirugías: ");
            nroCirugias = int.Parse(Console.ReadLine());
            Console.Write("Internaciones: ");
            nroInternaciones = int.Parse(Console.ReadLine());
            Console.Write("Enfermedades: ");
            enfermedades = Console.ReadLine();
            Console.Write("Alergias: ");
            alergias = Console.ReadLine();
            Console.Write("Fuma: ");
            fuma = char.Parse(Console.ReadLine());
            Console.Write("Bebidas Alcohólicas: ");
            consumoBebidas = char.Parse(Console.ReadLine());
            Console.Write("Drogas: ");
            consumoDrogas = char.Parse(Console.ReadLine());
            Console.Write("Medicamentos: ");
            medicamentos = Console.ReadLine();
            Console.Write("Menarca: ");
            menarca = Console.ReadLine();
            Console.Write("FUM: ");
            fum = Console.ReadLine();
            Console.Write("Relaciones sexuales: ");
            relacionesSexuales = char.Parse(Console.ReadLine());
            Console.Write("Anticoncepción: ");
            anticoncepcion = char.Parse(Console.ReadLine());
        }
        //mostrar
        public void mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t\t   ANAMNESIS");
            Console.WriteLine("APP. Cirugías: " + nroCirugias + "\tInternaciones: " + nroInternaciones + "\tEnfermedades: " + enfermedades + "\tAlergias: " + alergias);
            Console.WriteLine("APNP. Fuma: " + fuma + "\tBebidas alcohólicas: " + consumoBebidas + "\tDrogas: " + consumoDrogas + "\tMedicamnetos: " + medicamentos);
            Console.WriteLine("Menarca: " + menarca + "\t\t\tFUM: " + fum);
            Console.WriteLine("Relaciones sexuales: " + relacionesSexuales + "\tAnticoncepción: " + anticoncepcion);
        }
        //getters y setters
        public string Menarca
        {
            get { return menarca; }
            set { menarca = value; }
        }
        public string Fum
        {
            get { return fum; }
            set { fum = value; }
        }
        public char Anticoncepcion
        {
            get { return anticoncepcion; }
            set { anticoncepcion = value; }
        }
        public char ConsumoBebidas
        {
            get { return consumoBebidas; }
            set { consumoBebidas = value; }
        }
        public char Fuma
        {
            get { return fuma; }
            set { fuma = value; }
        }
        public int NroInternaciones
        {
            get { return nroInternaciones; }
            set { nroInternaciones = value; }
        }
        public int NroCirugias
        {
            get { return nroCirugias; }
            set { nroCirugias = value; }
        }
        public string Enfermedades
        {
            get { return enfermedades; }
            set { enfermedades = value; }
        }
        public string Alergias
        {
            get { return alergias; }
            set { alergias = value; }
        }
        public string Medicamentos
        {
            get { return medicamentos; }
            set { medicamentos = value; }
        }
        public char ConsumoDrogas
        {
            get { return consumoDrogas; }
            set { consumoDrogas = value; }
        }
        public char RelacionesSexuales
        {
            get { return relacionesSexuales; }
            set { relacionesSexuales = value; }
        }
    }

