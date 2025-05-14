//namespace _0512Csharp
//{
//    #region readonly
//    //class Configuration
//    //{
//    //    private readonly int min;
//    //    private readonly int max;
//    //    public Configuration(int min, int max)
//    //    {
//    //        this.min = min;
//    //        this.max = max;
//    //    }
//    //    public void ChangeMax(int newMax) 
//    //    {
//    //        //max = newMax; 오류. readonly는 생성자에서만 초기화 가능 이후 상수라 다시 값을 변경할수 없다
//    //    }

//    //}
//    #endregion

//    //중첩 클래스

//    class Configuration
//    {
//        List<itemValue> listConfig = new List<itemValue>();
//        public void SetConfigtion(string item, string value)
//        {
//            itemValue iv = new itemValue();
//            iv.SetValue(this, item, value);
//        }
//        public string GetConfigtion(string item)
//        {
//            foreach (itemValue iv in listConfig)
//            {
//                if (iv.GetItem() == item)
//                {
//                    return iv.GetValue();
//                }
//            }
//            return "";
//        }

//        class itemValue //private로 선언했기에 Configuration 클래스 밖에서는 보이지 않는다.
//        {
//            private string item;
//            private string value;
//            public void SetValue(Configuration config, string item, string value)
//            {
//                this.item = item;
//                this.value = value;
//                bool found = false;
//                for (int i = 0; i < config.listConfig.Count; i++)
//                {
//                    config.listConfig[i] = this;
//                    found = true;
//                    break;
//                }
//                if (found == false)
//                {
//                    config.listConfig.Add(this);
//                }
//            }
//            public string GetItem()
//            {
//                return item;
//            }
//            public string GetValue()
//            {
//                return value;
//            }
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Configuration config = new Configuration();
//            config.SetConfigtion("Version", "V 5.0");
//            Console.WriteLine(config.GetConfigtion("Version"));
//            config.SetConfigtion("Size", "655,324 kb");
//            Console.WriteLine(config.GetConfigtion("Version"));
//            Console.WriteLine(config.GetConfigtion("Size"));

//            config.SetConfigtion("Version", "v 5.0.1");
//            Console.WriteLine(config.GetConfigtion("Version"));

//            config.SetConfigtion("Size", "755,524 kb");
//            Console.WriteLine(config.GetConfigtion("Size"));
//        }
//    }
//}
