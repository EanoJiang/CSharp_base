namespace 函数重载习题;

public class Program{  
    #region 1
    static int Max(int a, int b){
        return a > b? a : b;
    }
    static double Max(double a, double b){
        return a > b? a : b;
    }
    #endregion
    #region 2
    static int Max(params int[] numbers){
        int max = numbers[0];
        for(int i = 0; i < numbers.Length; i++){
            max = (numbers[i] > max)? numbers[i] : max;
        }
        return max;
    }
    static double Max(params double[] numbers){
        double max = numbers[0];
        for(int i = 0; i < numbers.Length; i++){
            max = (numbers[i] > max)? numbers[i] : max;
        }
        return max;
    }
    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine(Max(1, 2));
        Console.WriteLine(Max(1.0, 2.0));

        Console.WriteLine(Max(1, 2, 3, 4, 5));
        Console.WriteLine(Max(1.0, 2.0, 3.0, 4.0, 5.0));
    }

}
