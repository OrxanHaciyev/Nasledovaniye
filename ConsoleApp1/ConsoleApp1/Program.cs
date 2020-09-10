using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill num = new Bill(500, 456546546, "07,08,1996");
            num.PrintSumm();
            num.PrintData();
            FiziLico num1 = new FiziLico(500,24242424,"05,03,2010","depozit");
            num1.PrintData();
            num1.Procent();
            num1.PrintSumm();
        }
       
    }

    public class Bill
    {

        protected int Summ { get; set; }
        protected int Billnumber { get; set; }
        protected string Data { get; set; }
        public Bill()
        {

        }
        public Bill(int summ, int billnumber, string data)
        {
            this.Summ = summ; this.Billnumber = billnumber; this.Data = data;
        }
        
        public void PrintSumm()
        {
            Console.WriteLine($"сумма на счету {Summ}");
        }
        public void PrintData()
        {
            Console.WriteLine($"дата создания счета {Data}");
        }
    }
        public class FiziLico : Bill
        {
            string Vid { get; set; }
            public FiziLico()
            {

            }
            public FiziLico(int summ, int billnumber, string data, string vid) : base(summ, billnumber, data)
            {
                
            }
            public void Procent()
            {
                Summ =Summ+ 100;//начисляет+100$
            }
            public void Snatiye()
            {
                Summ = Summ+ 100;//снимает деньги
            }
        }
        public class YurLico : Bill
        {
             public YurLico(int summ, int billnumber, string data, string vid) : base(summ, billnumber, data)
             {

             }
              public  void Procent()
              {
                 Summ = Summ + 100;//начисляет+100$
              }
        }
        

        
    

}
