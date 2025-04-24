namespace 函数习题;

class Program
{
    #region 1
    static int Max(int a, int b){
        return (a > b)? a : b;
    }
    #endregion

    #region 2
    static float[] Circle(float r){
        //1
        // float area  = 3.14f * r * r;
        // float perimeter = 2 * 3.14f * r;
        // float[] result = {area, perimeter};
        // return result;
        //2
        return new float[] { 3.14f * r * r, 2 * 3.14f * r };
    }
    #endregion

    #region 3
    static int[] CalculateArr(int[] arr){
        if( arr.Length == 0 )
        {
            Console.WriteLine("数组不能为空");
            return new int[0];
        }
        int sum = 0, max = arr[0], min = arr[0], average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
            max = (max >= arr[i]) ? max : arr[i];
            min = (min <= arr[i]) ? min : arr[i];
        }
        average = sum / arr.Length;
        int[] result = { sum, max, min, average };
        return result;
    }
    #endregion

    #region 4
    static bool IsPrime(int num){
        for(int i = 2; i <= num; i++){
            if(num%i == 0) return false;
        }
        return true;
    }
    #endregion

    #region 5
    static bool IsLeapYear(int year){
        if(year%4 == 0 && year%100!= 0 || year%400 == 0) return true;
        //默认返回false
        return false;
    }
    #endregion


    static void Main(string[] args)
    {
        int[] arr1 = new int[2];
        int[] result = CalculateArr(arr1);
        Console.WriteLine("sum:{0}, max:{1}, min:{2}, average:{3}", result[0], result[1], result[2], result[3]);
    }
}
