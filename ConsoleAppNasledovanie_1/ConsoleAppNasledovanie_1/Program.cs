using System;

namespace ConsoleAppNasledovanie_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Axmedov F.", 2, 0519);
            st1.Print();
            Aspirant asp1 = new Aspirant("Haciyev O.",3, 456, "тема десертации");
            asp1.Print();
            Aspirant asp2 = new Aspirant(st1.Lastname,st1.Kurs,st1.Zacetka,"тема десертации");
            asp2.Print();

        }
    }
    public class Student
    {
        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private int kurs;
        public int Kurs
        {
            get { return kurs; }
            set { kurs = value; }

        }
        private int zacetka;
        public int Zacetka
        {
            get { return zacetka; }
            set { zacetka = value; }
        }
        public Student()
        {

        }
        public Student(string lastname, int kurs, int zacetka)
        {
            this.Lastname = lastname; this.Kurs = kurs; this.Zacetka = zacetka;
        }
        public void Print()
        {
            Console.WriteLine($"студент {Lastname} на {Kurs} курсе номер зачетной книжки {Zacetka}");
        }
    }
    public class Aspirant : Student
    {
        private string tema;
        public Aspirant()
        {

        }
        public Aspirant(string lastname, int kurs, int zacetka,string tema) : base(lastname, kurs, zacetka)
        {
            this.Tema = tema;
        }
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        public new void Print()
        {
            
            base.Print();
            Console.WriteLine($"тема десертации : {Tema} ");
        }

    }
    

    
}
