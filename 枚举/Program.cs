namespace 枚举
{
        #region 枚举
        // //语法：枚举名 以E或E_开头，作为命名规范
        // enum E_自定义枚举名{
        //     自定义枚举项名字1,//枚举中的第一个默认值是0，也可以赋值，下面依次累加。
        //     自定义枚举项名字2,//1
        //     自定义枚举项名字3,//2
        // }

        #endregion

        #region 在哪里申明枚举
        //namespace语句块中
        //class语句块中
        //struct语句块中
        //枚举不能再函数语句块中声明
        enum E_MonsterType{
            Normal,
            Boss,
        }
        enum E_PlayerType{
            Main,
            Other,
        }
        #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region 枚举的用法
            //申明枚举变量
            //前面自定义的 变量名 = 默认值;
            // (这里的默认值的格式：自定义的枚举类型.枚举项)枚举类型
            E_MonsterType monsterType = E_MonsterType.Normal;
            E_PlayerType playerType  = E_PlayerType.Main;
            if(playerType == E_PlayerType.Main){
                Console.WriteLine("主角的逻辑");
            }
            else if(playerType == E_PlayerType.Other){
                Console.WriteLine("其他角色的逻辑");
            }

            //枚举很适合和switch配套使用
            //也可以贯穿，两种情况使用同一个逻辑
            switch (monsterType){
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物的逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("BOSS的逻辑");
                    break;
            }
            #endregion

            #region 枚举的类型转换
            //枚举转int——括号强转
            int i1 = (int)playerType;
            Console.WriteLine(i1);
            //int 转枚举——隐式转换
            playerType = 0;
            Console.WriteLine(playerType);
            
            //枚举转string——ToString()方法
            string s1 = playerType.ToString();
            Console.WriteLine(s1);
            //string 转枚举——Parse()方法 + 自定义枚举类型括号强转
            //语法：(自定义枚举类型)Enum.Parse(typeof(自定义枚举类型), "要转换的字符串");
            //注意要转换的字符串必须是枚举里有的常量
            playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Main");
            Console.WriteLine(playerType);

            #endregion


        }
    }
}

