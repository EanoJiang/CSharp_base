namespace 交错数组;

class Program
{
    static void Main(string[] args)
    {
        #region 交错数组的申明
        //只申明
        //变量类型[][] 交错数组名;
        int[][] arr1;

        //申明+初始化
        //变量类型[][] 交错数组名 = new int[行数][];
        int[][] arr2 = new int[3][];
        //变量类型[][] 交错数组名 = new int[行数][] { 一维数组1, 一维数组2, 一维数组3 };
        //注意：{一维数组的数据类型要和交错数组的类型一致}
        int[][] arr3 = new int[3][] {   new int[] { 1, 2 }, 
                                        new int[] { 3, 4}, 
                                        new int[] { 5 } };
        //变量类型[][] 交错数组名 = new int[][] { 一维数组1, 一维数组2, 一维数组3 };
        int[][] arr4 = new int[][] {    new int[] { 1, 2 }, 
                                        new int[] { 3, 4}, 
                                        new int[] { 5 } };
        
        //最常用：
        //变量类型[][] 交错数组名 = { 一维数组1, 一维数组2, 一维数组3 };
        int[][] arr5 = {new int[] {1, 2, 3},
                        new int[] {4, 5},
                        new int[] {6, 7, 8, 9}};
        #endregion
    
        #region 交错数组的使用
        int[][] array1 = {  new int[] {1, 2, 3},
                            new int[] {4, 5}    };
        //1.数组的长度
        //行
        //交错数组名.Length
        //交错数组名.GetLength(0)
        Console.WriteLine(array1.Length);
        Console.WriteLine(array1.GetLength(0));
        //列
        //交错数组名[行].Length
        //其实就是找到交错数组中的某个一维数组的长度
        Console.WriteLine(array1[0].Length);
        Console.WriteLine(array1[1].Length);

        //2.获取交错数组的元素
        //交错数组名[行][列]
        Console.WriteLine(array1[0][0]);

        //3.修改交错数组的元素
        //交错数组名[行][列] = 值;
        array1[0][0] = 10;
        Console.WriteLine(array1[0][0]);

        //4.遍历交错数组
        //和二维数组一样，只不过是遍历每一个一维数组
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array1[i].Length; j++)
            {
                Console.Write(array1[i][j] + " ");
            }
            Console.WriteLine();
        }

        //5.增加交错数组的元素
        //6.删除交错数组的元素
        //7.查找交错数组的元素
        //***都和二维数组一样***
        #endregion
    }

}
