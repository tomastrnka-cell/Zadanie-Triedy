namespace ConsoleApp11;

class Program
{
    static void Main(string[] args)
    {
        List<Kniha> kniznica = new List<Kniha>();

        Kniznica Kniznica_prva = new Kniznica();

        while (true)
        {
            Console.Write("Napis prikaz ");
            string prikaz = Console.ReadLine();

            if (prikaz == "exit")
            {
                Console.WriteLine("Asistent ukonceny");
                break;
            }
            else if (prikaz == "pridajknihu")
            {
                pridajknihu();
            }
            else if (prikaz == "meno_autora")
            {
                mnajdiautora();
            }
        }

        void mnajdiautora()
        {
            Console.Write("Zadaj meno autora: ");
            string hladanyAutor = Console.ReadLine();
            Console.WriteLine(" Knihy od autora " + hladanyAutor);
            foreach (Kniha hladanakniha in kniznica)
            {
                if (hladanakniha.MenoAutora == hladanyAutor)
                {
                    Console.WriteLine(hladanakniha.NazovKnihy);
                }
            }
        }

        void pridajknihu()
        {
            Kniha kniha = new Kniha();

            Console.Write("Zadaj nazov knihy: ");
            kniha.NazovKnihy = Console.ReadLine();

            Console.Write("Zadaj meno autora: ");
            kniha.MenoAutora = Console.ReadLine();

            Console.Write("Zadaj rok vydania: ");
            kniha.RokVydania = int.Parse(Console.ReadLine());

            Console.Write("Zadaj ci je kniha pozicana alebo nie (true, false): ");
            kniha.JePozicana = bool.Parse(Console.ReadLine());

            kniznica.Add(kniha);
        }
    }

    class Kniha
    {
        public string NazovKnihy;
        public string MenoAutora;
        public int RokVydania;
        public bool JePozicana;
    }

    class Kniznica
    {
        List<Kniha> kniznica = new List<Kniha>();

        public void pridajknihu()
        {
            Kniha kniha = new Kniha();

            Console.Write("Zadaj nazov knihy: ");
            kniha.NazovKnihy = Console.ReadLine();

            Console.Write("Zadaj meno autora: ");
            kniha.MenoAutora = Console.ReadLine();

            Console.Write("Zadaj rok vydania: ");
            kniha.RokVydania = int.Parse(Console.ReadLine());

            Console.Write("Zadaj ci je kniha pozicana alebo nie (true, false): ");
            kniha.JePozicana = bool.Parse(Console.ReadLine());

            kniznica.Add(kniha);
        }
    }
}