#region 1
static int[] Calculate(params int[] numbers){
    if(numbers.Length == 0){
        Console.WriteLine("No numbers were provided.");
        return new int[0];
    }
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        sum += numbers[i];
    }
    int average = sum / numbers.Length;
    return new int[] {sum, average};
}
#endregion

#region 2
static int[] Sum_Odd_Even(params int[] numbers){
    if(numbers.Length == 0){
        Console.WriteLine("No numbers were provided.");
        return new int[0];
    }
    int sum_odd = 0;
    int sum_even = 0;
    for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] % 2 == 0){
            sum_even += numbers[i];
        }
        else{
            sum_odd += numbers[i];
        }
    }
    return new int[] {sum_odd, sum_even};
}
#endregion

int[] result = Calculate(1, 2, 3, 4, 5);
Console.WriteLine("Sum: " + result[0]);
Console.WriteLine("Average: " + result[1]);

int[] result2 = Sum_Odd_Even(1, 2, 3, 4, 5);
Console.WriteLine("Sum of odd numbers: " + result2[0]);
Console.WriteLine("Sum of even numbers: " + result2[1]);