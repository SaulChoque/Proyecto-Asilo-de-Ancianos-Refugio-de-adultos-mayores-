using System;

    class EFisico
    {
        private string frecuenciaC, frecuenciaR, presionArt, temperatura, exCabeza, exCara, exOjos, exOidos, exBoca, exCuello, exTorax, exCorazon, exPulmones, exAbdomen, exGenitourinario, exAno, exExtremidades, exNeurologico;
        private double peso, talla;

        //constructor por defecto
        public EFisico() {
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
            Console.Write("Frecuencia cardiaca: ");
            frecuenciaC = Console.ReadLine();
            Console.Write("Frecuencia respiratoria: ");
            frecuenciaR = Console.ReadLine();
            Console.Write("Presion Arterial: ");
            presionArt = Console.ReadLine();
            Console.Write("Temperatura: ");
            temperatura = Console.ReadLine();
            Console.Write("Peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Talla: ");
            talla = double.Parse(Console.ReadLine());
            Console.WriteLine("\t\tEXAMEN FISICO SEGMENTARIO");
            Console.Write("Cabeza: ");
            exCabeza = Console.ReadLine();
            Console.Write("Cara: ");
            exCara = Console.ReadLine();
            Console.Write("Ojos: ");
            exOjos = Console.ReadLine();
            Console.Write("Oídos: ");
            exOidos = Console.ReadLine();
            Console.Write("Boca: ");
            exBoca = Console.ReadLine();
            Console.Write("Cuello: ");
            exCuello = Console.ReadLine();
            Console.Write("Tórax: ");
            exTorax = Console.ReadLine();
            Console.Write("Corazón: ");
            exCorazon = Console.ReadLine();
            Console.Write("Pulmones: ");
            exPulmones = Console.ReadLine();
            Console.Write("Abdomen: ");
            exAbdomen = Console.ReadLine();
            Console.Write("Genitourinario: ");
            exGenitourinario = Console.ReadLine();
            Console.Write("Ano: ");
            exAno = Console.ReadLine();
            Console.Write("Extremidades: ");
            exExtremidades = Console.ReadLine();
            Console.Write("Neurológico: ");
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
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public double Talla
        {
            get { return talla; }
            set { talla = value; }
        }
        public string FrecuenciaR
        {
            get { return frecuenciaR; }
            set { frecuenciaR = value; }
        }
        public string PresionArt
        {
            get { return presionArt; }
            set { presionArt = value; }
        }
        public string Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        public string FrecuenciaC
        {
            get { return frecuenciaC; }
            set { frecuenciaC = value; }
        }
        public string ExCabeza
        {
            get { return exCabeza; }
            set { exCabeza = value; }
        }
        public string ExCara
        {
            get { return exCara; }
            set { exCara = value; }
        }
        public string ExOjos
        {
            get { return exOjos; }
            set { exOjos = value; }
        }
        public string ExOidos
        {
            get { return exOidos; }
            set { exOidos = value; }
        }
        public string ExBoca
        {
            get { return exBoca; }
            set { exBoca = value; }
        }
        public string ExCuello
        {
            get { return exCuello; }
            set { exCuello = value; }
        }
        public string ExTorax
        {
            get { return exTorax; }
            set { exTorax = value; }
        }
        public string ExCorazon
        {
            get { return exCorazon; }
            set { exCorazon = value; }
        }
        public string ExPulmones
        {
            get { return exPulmones; }
            set { exPulmones = value; }
        }
        public string ExAbdomen
        {
            get { return exAbdomen; }
            set { exAbdomen = value; }
        }
        public string ExGenitourinario
        {
            get { return exGenitourinario; }
            set { exGenitourinario = value; }
        }
        public string ExAno
        {
            get { return exAno; }
            set { exAno = value; }
        }
        public string ExExtremidades
        {
            get { return exExtremidades; }
            set { exExtremidades = value; }
        }
        public string ExNeurologico
        {
            get { return exNeurologico; }
            set { exNeurologico = value; }
        }
    }
