#region 1
static void PrintNum(int n0, int n1){
    if(n1 < n0){
        return;
    }
    Console.WriteLine(n1);
    // n1--;
    //这里要用前缀--n1，先减后用，不然会出现无限递归导致栈溢出
    PrintNum(n0, --n1);
}
#endregion

#region 2
static int Factorial(int n){
    if(n == 1) return n;
    return n * Factorial(n-1);
        // 5 * Fun2(4) = 5 * 4 * 3 * 2 * 1
        // 4 * Fun2(3) = 4 * 3 * 2 * 1
        // 3 * Fun2(2) = 3 * 2 * 1
        // 2 * Fun2(1) = 2 * 1
        // 1
}
#endregion

#region 3
static int SumOfFactorial(int n){
    if(n == 1) return Factorial(n);
    return Factorial(n) + SumOfFactorial(n-1);
}
#endregion

#region 4
static float getFinalLength(float length,int days){
    //从第0天开始，所以days要+1
    if(days+1 == 0) return length;
    //这里要用前缀--days，先减后用，不然会出现无限递归导致栈溢出
    return getFinalLength(length/2.0f,--days);
}
#endregion

#region 5
static bool PrintNum2(int n0, int n1){
    // if(n1 < n0){
    //     return;
    // }
    Console.WriteLine(n1);
    // n1--;
    //这里要用前缀--n1，先减后用，不然会出现无限递归导致栈溢出
    return n1 < n0 || PrintNum2(n0, --n1);
}
#endregion

PrintNum(0, 10);
Console.WriteLine("阶乘5= "+Factorial(5));
Console.WriteLine("!1 + ... + !10 = "+SumOfFactorial(10));
Console.WriteLine("100 的最终长度为: "+getFinalLength(100, 10));
PrintNum(0, 200);