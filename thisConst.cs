// this keyword'ünün constructorlar arası geçiş için kullanılması
using System; 
namespace Program1{
    class Program{
        static void Main(string[]args){
        MyClass m1 = new MyClass(10,"on"); // 2 . constructor çalışrı 

        }
    }
     class MyClass{

        public MyClass(int a)
        {
            System.Console.WriteLine("1. constructor değeri =  "+a);
        }
        public MyClass(int a,String b) :this(a)
        {
          // this keyword'ü sayesinde 1. constructor tetiklenir 
            System.Console.WriteLine("2. constructor değeri = "+ a +" okunuşu =" + b);

        }
    }
    
}
