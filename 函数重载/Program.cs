namespace 函数重载;

class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }
    //参数的数量不同
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    //参数的类型不同
    static double Sum(double a, double b)
    {
        return a + b;
    }
    //参数的顺序不同(其实也是类型不同)
    static float Sum(float a, int b){
        return a + b;
    }

    //参数用ref out 修饰
    //out传入的参数必须要在函数内部赋值
    static int Sum(ref int a,out int b)
    {
        b = 1;
        return a + b;
    }

    //参数是可变参数
    static int Sum(params int[] nums)
    {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    
    static void Main(string[] args)
    {
        Sum(1, 2);
        Sum(1, 2, 3);
        Sum(1.0, 2.0);
        Sum(1.0f, 2);
        int a = 1;
        int b;
        Sum(ref a, out b);
    }
}
