namespace 二维数组;

class Program
{
    static void Main(string[] args)
    {
        #region 二维数组的申明
        //申明但不初始化：
        //变量类型[,] 二维数组变量名
        int[,] arr1;
        //变量类型[,] 二维数组变量名 = new int[行数,列数];
        int[,] arr2 = new int[3, 3];
        //申明+初始化：
        //变量类型[,] 二维数组变量名 = new int[行数,列数] { {元素1,元素2,元素3...}, {元素1,元素2,元素3...},... };
        int[,] arr3 = new int[3, 3] {   { 1, 2, 3 },
                                        { 4, 5, 6 },
                                        { 7, 8, 9 }};

        //行列自动计算
        int[,] arr4 = new int[,] {   { 1, 2, 3 },
                                     { 4, 5, 6 },
                                     { 7, 8, 9 }};
        #endregion 

        #region 二维数组的使用
        //1.二维数组的长度
        int[,] array1 = new int[,]{ {1,2,3},
                                    {4,5,6},
                                    {7,8,9}};
        //二维数组名.GetLength(dimesion)，dimesion为0表示行，为1表示列
        //行
        Console.WriteLine(array1.GetLength(0));
        //列
        Console.WriteLine(array1.GetLength(1));

        //2.获取二维数组的元素
        //二维数组名[行,列]
        Console.WriteLine(array1[0, 0]);

        //3.修改二维数组的元素
        //二维数组名[行,列] = 元素值
        array1[0, 0] = 10;
        Console.WriteLine(array1[0, 0]);

        //4.遍历二维数组
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("**************");
        //5.增加数组元素
        int[,] array2 = new int[4,3];
        //先拷贝原数组元素
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                array2[i, j] = array1[i, j];
            }
        }
        array1 = array2;
        array1[3, 0] = 100;
        array1[3, 1] = 101;
        array1[3, 2] = 102;
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************");
        //6.删除数组元素
        //先拷贝原数组元素
        int[,] array3 = new int[2, 3];
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                array3[i, j] = array1[i, j];
            }
        }
        array1 = array3;
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        //7.查找数组元素
        for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                if(array1[i,j] == 6)
                {
                    Console.WriteLine("元素6的位置为：{0},{1}", i, j);
                }
            }
        }   
        #endregion

    }
}
