using System;
namespace programone{
    class Person
    {
    // değişkenler
        public String name = string.Empty;
        public String lastName = string.Empty;
        private String motherName = string.Empty;
        public String job = string.Empty;
        public int age;
        private int id;
        public char gender  ; // erkek için m bayan için f
    // constructors
        public Person(){
            // parametresiz constructor 
        }
        // full const 
        public Person(String name, String lastName, String motherName, String job,int age, int id, char gender){
            this.name = name;
            this.lastName = lastName;
            this.motherName = motherName; 
            this.job = job;
            this.age = age;
            this.id = id;
            this.gender = gender; 
            System.Console.WriteLine("Hoşgeldiniz " + name + " "+ lastName);
        }
     // propertys 
        public int Id { get; set; }
        public String MotherName { get; set; } = string.Empty;
 
       
    }
}