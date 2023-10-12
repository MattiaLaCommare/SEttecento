namespace SEttecento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci peso e distanza del pacco");
            double Peso= Convert.ToDouble(Console.ReadLine());
            double Distanza= Convert.ToDouble(Console.ReadLine());
            double Costo;
            Console.WriteLine("Specifica se è urgente o no (si/no)");
            string urgente= Console.ReadLine();
            urgente = urgente.ToLower();
            if (urgente == "si")
            {
                if (Distanza < 100)
                {
                    Costo = Peso * 1.5;
                    Console.WriteLine("Pagerai " + Costo + " euro");
                }
                if (Distanza > 100 && Distanza < 500)
                {
                    Costo = Peso * 2;
                    Console.WriteLine("Pagerai " + Costo + " euro");
                }
                if (Distanza > 500)
                {
                    Costo = Peso * 3;
                    Console.WriteLine("Pagerai " + Costo + " euro");
                }
            }
            else if (urgente == "no")
            {
                if (Distanza < 100)
                {
                    Costo = Peso * 1.0;
                    Console.WriteLine("Pagerai " + Costo + " euro");
                }
                if (Distanza > 100 && Distanza < 500)
                {
                    Costo = Peso * 1.5;
                    Console.WriteLine("Pagerai " + Costo + " euro");
                }
                if (Distanza > 500)
                {
                    Costo = Peso * 2;
                    Console.WriteLine("Pagerai " + Costo + " euro");
                }
            }
        }
    }
}