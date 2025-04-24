namespace 数组;

class Program
{
    static void Main(string[] args)
    {
        #region 数组声明
        //只声明数组名，不初始化
        //变量类型[] 数组名;
        int[] arr1;
        //声明并初始化数组的长度，元素默认值是0
        //变量类型[] 数组名 = new 变量类型[数组长度];
        int[] arr2 = new int[5];
        //声明并初始化数组的长度和元素值
        //变量类型[] 数组名 = new 变量类型[数组长度] {元素值1, 元素值2, 元素值3...};
        int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
        //声明并初始化数组的元素值，数组长度自动计算
        //变量类型[] 数组名 = new 变量类型[] {元素值1, 元素值2, 元素值3...};
        int[] arr4 = new int[] { 1, 2, 3, 4};
        //声明并初始化数组——最简单的方法
        int[] arr5 = { 1, 2, 3, 4, 5 };

        bool[] arr6 = new bool[] { true, false, true, false };

        #endregion
        
        #region 数组使用
        int[] arr = { 1, 2, 3, 4, 5 };
        //1. 获取数组长度
        //数组名.Length
        Console.WriteLine("数组长度：" + arr.Length);
        //2. 获取数组元素
        //数组名[索引]
        //注意不要越界
        Console.WriteLine("数组第一个元素：" + arr[0]);
        //3. 修改数组元素
        //数组名[索引] = 新值;
        arr[0] = 10;
        Console.WriteLine("修改后的数组第一个元素：" + arr[0]);
        //4. 遍历数组
        for(int i = 0; i < arr.Length; i++){
            Console.WriteLine("数组第" + i + "个元素：" + arr[i]);
        }
        //5. 增加数组元素(先拷贝数组)
        int[] array2 = new int[6];
        for(int i = 0; i < arr.Length; i++){
            array2[i] = arr[i];
        }
        arr = array2;
        arr[5] = 6;
        Console.WriteLine("增加后的数组：" + string.Join(",", arr));
        //6. 删除数组元素(先拷贝数组)
        int[] array3 = new int[4];
        for(int i = 0; i < 4; i++){
            array3[i] = arr[i];
        }
        arr = array3;
        Console.WriteLine("删除后的数组：" + string.Join(",", arr));
        //7. 查找数组元素
        int elem = 3;
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] == elem){
                Console.WriteLine("元素" + elem + "在数组的索引为：" + i);
                break;
            }
        }
        #endregion
    
    }
}
