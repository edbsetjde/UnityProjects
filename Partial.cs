//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0512Csharp
//{
//    partial class MyClass // partial 분할클래스. 클래스가 너무 길면 가독성이 떨어지니 여러파일로 나누어서 구현하기위해 사용
//    {
//        public void Methoad_A()
//        {
//            Console.WriteLine("Methoad_A");
//        }
//        public void Methoad_B()
//        {
//            Console.WriteLine("Methoad_B");
//        }
//    }
//    partial class MyClass
//    {
//        public void Methoad_C()
//        {
//            Console.WriteLine("Methoad_C");
//        }
//        public void Methoad_D()
//        {
//            Console.WriteLine("Methoad_D");
//        }
//    }



//    internal class Partial
//    {
//        static void Main(string[] args)
//        {
//            MyClass myClass = new MyClass();
//            myClass.Methoad_A();
//            myClass.Methoad_B(); 
//            myClass.Methoad_C();
//            myClass.Methoad_D();
//            Console.ReadLine();

//        }
//    }
//}
