using System;
namespace programone
{
    class Costumer : Person
    {
        // değişkenler 
        private double balance;
        
    // boş const
     public Costumer()
        {
            // boş const
        }
        // sadece değer içeren const 
        public Costumer(double balance)
        {
            this.balance = balance;
        }
        // Person + balance
        public Costumer(double balance, string name, string lastName, string motherName, string job, int age, int id,char gender) : base(name, lastName, motherName, job, age, id,gender)
        {
            this.balance = balance;
            
        }
        public double Balance { get; set; }
    }
}