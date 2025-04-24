namespace 函数;

class Program
{
    //有参有返回值的函数
    static int[] sum_avg(int a, int b)
    {
        int sum = a + b;
        int avg = sum / 2;
        // int[] result = { sum, avg };
        return new int[] { sum, avg };
    }

    //关于return
    static void Say(string str){
        //void也是可以写return的，return后面的语句不会执行
        if(str == "Fuck") return;
        Console.WriteLine(str);
    }
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int[] result = sum_avg(a, b);
        Console.WriteLine("The sum is: " + result[0]);
        Console.WriteLine("The average is: " + result[1]);

    }
}
