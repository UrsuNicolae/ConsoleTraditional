using System.Collections;
using System.Diagnostics.Contracts;

namespace ConsoleAppTraditional.Class
{
    public class Curs
    {
        public string Name { get; set; }
        public int Durata { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"Nume: {Name}" +
                $"Data: {Data}" +
                $"Durata: {Durata}";
        }
    }
    public static class CursManagement
    {
        static ArrayList cursuri = new ArrayList();
        static Hashtable sali = new Hashtable();
        static SortedList programSapatamanal = new SortedList();
        static Stack istoricModificari = new Stack();
        static Queue cursuriUrmatoare = new Queue();

        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("[1] Adauga Curs");
                Console.WriteLine("[2] Afiseaza programul saptamanl");
                Console.WriteLine("[3] Verzi urmatorul curs");
                Console.WriteLine("[4] Sterge curs");
                Console.WriteLine("[5] Afiseaza istoricul modificarilor");
                Console.WriteLine("[0] Iesire");
                var option = Console.ReadKey().KeyChar;
                switch (option)
                {
                    case '1':
                        AdaugaCurs();
                        break;
                    case '2':
                        AfiseazaProgramulSaptamanal();
                        break;
                    case '3':
                        VeziUrmatorulCurs();
                        break;
                    case '4':
                        StergeCurs();
                        break;
                    case '5':
                        AfiseazaIstoricul();
                        break;
                    case '0':
                    default:
                        return;
                }
            }
        }

        private static void AdaugaCurs()
        {
            Console.WriteLine("Curs name:");
            var name = Console.ReadLine();
            if (cursuri.Cast<Curs>().Any(c => c.Name == name))
            {
                Console.WriteLine("Cursul exista deja!");
                return;
            }

            Console.WriteLine("Durata cursului in minute");
            var durata = int.Parse(Console.ReadLine());

            Console.WriteLine("Data cursului");
            var data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Sala");
            var sala = Console.ReadLine();
            if (sali.Contains(sala))
            {
                Console.WriteLine("Sala este deja rezervata");
                return;
            }
            var curs = new Curs
            {
                Name = name,
                Durata = durata,
                Data = data
            };

            cursuri.Add(curs);
            sali.Add(name, sala);
            cursuriUrmatoare.Enqueue(curs);
            var zi = data.ToString("dddd");
            if (!programSapatamanal.ContainsKey(zi))
            {
                programSapatamanal.Add(zi, new ArrayList());
            }
            ((ArrayList)programSapatamanal[zi]).Add(name);

            istoricModificari.Push($"Adaugat: {name} - {DateTime.Now}");
            Console.WriteLine("Cursul a fost adaugat cu success!");
        }

        private static void AfiseazaProgramulSaptamanal()
        {
            if(programSapatamanal.Count == 0)
            {
                Console.WriteLine("Programul saptamanl este gol");
                return;
            }

            foreach(DictionaryEntry zi in programSapatamanal)
            {
                Console.WriteLine($"\nZiua: {zi.Key}");
                foreach(string curs in (ArrayList)zi.Value)
                {
                    Console.WriteLine($" - {curs}");
                }
            }
        }

        private static void VeziUrmatorulCurs()
        {
            if (cursuriUrmatoare.Count == 0)
            {
                Console.WriteLine("Nu exista cursuri de afisat");
                return;
            }

            var urmatorul = (Curs)cursuriUrmatoare.Peek();
            Console.WriteLine($"\n Urmatorul curs:");
            Console.WriteLine(urmatorul);
            Console.WriteLine($"Sala: {sali[urmatorul.Name]}");
        }

        public static void StergeCurs()
        {
            Console.WriteLine("Nume Curs");
            string nume = Console.ReadLine();
            var curs = cursuri.Cast<Curs>().FirstOrDefault(c => c.Name == nume);
            if(curs == null)
            {
                Console.WriteLine("Cursul nu exista");
                return;
            }
            cursuri.Remove(curs);
            sali.Remove(nume);

            foreach(DictionaryEntry zi in programSapatamanal)
            {
                var listaCursuri = (ArrayList)zi.Value;
                if (listaCursuri.Contains(nume))
                {
                    listaCursuri.Remove(nume);
                    break;
                }
            }
            var coadaNoua = new Queue();
            while(cursuriUrmatoare.Count > 0)
            {
                var cursDinCoada = (Curs)cursuriUrmatoare.Dequeue();
                if(cursDinCoada.Name != nume)
                {
                    coadaNoua.Enqueue(cursDinCoada);
                }
            }
            cursuriUrmatoare = coadaNoua;
            istoricModificari.Push($"Sters: {nume} - {DateTime.Now}");
            Console.WriteLine("Cursul a fost sters cu success");
        }

        public static void AfiseazaIstoricul()
        {
            if(istoricModificari.Count == 0)
            {
                Console.WriteLine("Nu exista modificari inregistrate");
                return;
            }

            Console.WriteLine("\n Istoric modificari");
            foreach(var modificare in istoricModificari)
            {
                Console.WriteLine(modificare);
            }
        }
    }
}
