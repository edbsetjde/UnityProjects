//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////확장 매서드 : 부모클래스를 물려받아 자식클래스를 만든 뒤 여기에 매소드나 필드를 추가하는것이 아니라 기존의 클래스에 메소드를 추가하는방법

//namespace _0512Csharp
//{
//    //확장 메서드 사용법. 
//    public static class InterExtension
//    {
//        public static int Square(this int myInt)
//        {
//            return myInt * myInt;
//        }
//        public static int Power(this int myInt, int exponent)
//        {
//            int result = myInt;
//            for (int i = 1; i < exponent; i++)
//            {
                
//                result *= myInt;
                
//            }
//            return result;
//        }




//        internal class ExtensionMethod
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine($"3^2: {3.Square()}");
//                Console.WriteLine($"3^4: {3.Power(4)}");
//                Console.WriteLine($"2^10: {2.Power(10)}");
//            }
//        }
//    }
//}
