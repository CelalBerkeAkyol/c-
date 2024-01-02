using System; 
namespace Program1{
    class Program{
        static void Main(string[]args){
        MyClass m1 = new MyClass(); 
        MyClass m2 = new MyClass();
        }
    }
     class MyClass{

        public MyClass()
        {
            // her nesne çağrıldığında oluşur 
            System.Console.WriteLine("Constructor oluşturuldu");
        }
        static MyClass() 
        {
            // sadece 1 kere oluşur ve constructordan önce oluşur 
            System.Console.WriteLine("Static constructor oluşturuldu");
            
        }
    }
    
}
// beklenen çıkt :
// Static constructor oluşturuldu
// Constructor oluşturuldu
// Constructor oluşturuldu
