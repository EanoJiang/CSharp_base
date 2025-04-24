namespace 值类型和引用类型;

class Program
{
    static void Main(string[] args)
    {
        //值类型
        int a = 1;
        //引用类型
        int[] arr = new int[] {1,2,3,4 };

        //赋值给另一个变量
        int b = a;
        int[] arr2 = arr;
        Console.WriteLine("a={0},b={1}\narr[0]={2},arr2[0]={3}",a,b,arr[0],arr2[0]);
        
        //修改新的变量
        b = 2;
        arr2[0] = 99;
        Console.WriteLine("a={0},b={1}\narr[0]={2},arr2[0]={3}",a,b,arr[0],arr2[0]);

        #region string——特殊的引用类型
        string str1 = "123";
        string str2 = str1;//这一步两个变量指向的地址相同

        str2 = "456";//str2重新赋值，地址改变
        Console.WriteLine("str1={0},str2={1}",str1,str2);
        #endregion

        #region 习题
        int[] arr3 = new int[]{1};
        int[] arr4 = arr3;
        int[] arr5 = arr3;
        arr4[0] = 99;//arr4修改单个元素，地址不变
        arr5 = new int[5];//arr5重新赋值，地址改变，指向新的堆内存
        Console.WriteLine("arr3[0]={0},arr4[0]={1},arr5[0]={2}",arr3[0],arr4[0],arr5[0]);
        #endregion
    }
}
