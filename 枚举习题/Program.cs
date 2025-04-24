namespace 枚举习题;

class Program
{
    /// <summary>
    /// 状态
    /// </summary>
    enum E_StateOnlineType{
        Offline,
        Online,
        Busy,
        Invisible,
    }

    /// <summary>
    /// 咖啡类型
    /// </summary>
    enum E_CoffeeType{
        /// <summary>
        /// 中杯
        M,
        /// <summary>
        /// 大杯
        /// </summary>
        L,
        /// <summary>
        /// 特大杯
        /// </summary>
        XL,
    }

    static void Main(string[] args)
    {
        #region 题目1 用户状态
        try
        {
            Console.WriteLine("请输入状态(0-3):");
            E_StateOnlineType state = (E_StateOnlineType)Enum.Parse(typeof(E_StateOnlineType), Console.ReadLine());
            Console.WriteLine(state);
        }
        catch{
            Console.WriteLine("输入错误,请输入0-3的数字!");
        }
        #endregion
        
        #region 题目2 coffee
        try{
            Console.WriteLine("请输入咖啡类型(M/L/XL):");
            E_CoffeeType coffeeType = (E_CoffeeType)Enum.Parse(typeof(E_CoffeeType), Console.ReadLine());
            switch(coffeeType){
                case E_CoffeeType.M:
                    Console.WriteLine("中杯咖啡");
                    break;
                case E_CoffeeType.L:
                    Console.WriteLine("大杯咖啡");
                    break;
                case E_CoffeeType.XL:
                    Console.WriteLine("特大杯咖啡");
                    break;
                default:
                    Console.WriteLine("输入错误!");
                    break;
            }
        }
        catch{
            Console.WriteLine("输入错误,请输入M/L/XL!");
        }
        
        #endregion
    
        #region 题目3 基本属性
        
        #endregion
    }
}
