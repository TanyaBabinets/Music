using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 6.3
//Создать базовый класс «Музыкальный инструмент» и производные классы «Скрипка», «Тромбон», «.Укулеле»,
//«Виолончель». С помощью конструктора установить имя каждого музыкального инструмента и его характеристики.
//Реализуйте для каждого из классов методы:
//■■ Sound — издает звук музыкального инструмента (пишем текстом в консоль);
//■■ Show — отображает название музыкального инструмента;
//■■Desc — отображает описание музыкального инструмента;
//■■History — отображает историю создания музыкального инструмента.
namespace Music
{ 
       abstract class Instrument
        {
           protected string name;
        protected string descript;
            public Instrument() { }
            public Instrument(string n,string d)
            {
                name= n;
                descript= d;
            }
        abstract public void Sound(); 
    abstract public void Show();

        abstract public void Desc();

        abstract public void History();

        };

        class Violin:Instrument
        {
            public Violin(string n, string d)
            {
                name = n;
                descript = d;
            }
        ////   gde get set
        public override  void Sound() 
            {
                Console.WriteLine("Makes beautiful sound");
            }
        public override void Show() 
            {
                Console.WriteLine($"Инструмент {name} это {descript}" );
            }

        public override void Desc() {
                Console.WriteLine($"Инструмент {name} относится к группе струнно-смычковых инструметов.");
            }

        public override void History() {
                Console.WriteLine("Изобретена в 1545 году");
            }

        };
        class Violoncello : Instrument
        {
           
            public Violoncello(string n, string d)
            {
                name = n;
                descript = d;
            }

        public override void Sound()
            {
                Console.WriteLine("Makes beautiful sound");
            }
        public override void Show()
            {
                Console.WriteLine($"Инструмент {name} это {descript}");
            }

        public override void Desc()
            {
                Console.WriteLine($"Инструмент {name} относится к группе струнно-смычковых инструметов.");
            }

        public override void History()
            {
                Console.WriteLine("Изобретена в XVI веке");
            }


        };
        class Ukulele : Instrument
        {
            
            public Ukulele(string n, string d)
            {
                name = n;
                descript = d;
            }

        public override void Sound()
            {
                Console.WriteLine("Makes beautiful sound");
            }
        public override void Show()
            {
                Console.WriteLine($"Инструмент {name} это {descript}");
            }

        public override void Desc()
            {
                Console.WriteLine($"Инструмент {name} это гавайская четырёхструнная разновидность гитары.");
            }

        public override void History()
            {
                Console.WriteLine("Изобретена в XIХ веке");
            }

        };
        class Trombon : Instrument      
        {
            public Trombon(string n, string d)
            {
                name = n;
                descript = d;
            }

        public override void Sound()
            {
                Console.WriteLine("Makes beautiful sound");
            }
        public override void Show()
            {
                Console.WriteLine($"Инструмент {name} это {descript}");
            }
        public override void Desc()
            {
                Console.WriteLine($"Инструмент {name} относится к группе духовых инструметов.");
            }
        public override void History()
            {
                Console.WriteLine("Изобретена в XV веке");
            }

        };
    class Program
    {
        static void Main(string[] args)
        {
            Violin v=new Violin("Violin", "made by Stradivary");
            v.Show();
            v.Sound();
            v.Desc();
            v.History();
            Console.WriteLine();
            Violoncello vi = new Violoncello("Violoncello", "stringed instrument");
            v.Show();
            v.Sound();
            v.Desc();
            v.History();
            Console.WriteLine();
            Ukulele u = new Ukulele("Ukulele", "type of Hawaian guitar");
            u.Show();
            u.Sound();
            u.Desc();
            u.History();
            Console.WriteLine();
            Trombon t = new Trombon("Trombon", "horn instrument");
            t.Show();
            t.Sound();
            t.Desc();
            t.History();

        }
    }
}
