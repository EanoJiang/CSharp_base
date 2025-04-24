#region 变长参数   
//修饰参数关键字 params 
//params后面必须是数组,所以只能是同一类型的可变参数
//参数最多只能出现一个params关键字,且一定是最后一组参数
static int Sum(params int[] numbers){
    int sum = 0;
    for(int i = 0; i < numbers.Length; i++){
        sum += numbers[i];
    }
    return sum;
}
#endregion

#region 参数默认值(可选参数)
//每个参数都可以有一个默认值
//混用的时候，可选参数要写在必选参数后面
static void Say(string str = "Hello"){
    Console.WriteLine(str);
}
static void Say2(string str, string name = "World"){
    Console.WriteLine(str + " " + name);
}

#endregion
Console.WriteLine(Sum(1, 2, 3, 4, 5)); // 15
//不传入参数时,默认使用参数默认值
Say(); // Hello
//传入参数时,使用传入的参数值
Say("World"); // World
Say2("Hello"); // Hello World
