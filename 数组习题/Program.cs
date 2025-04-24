// See https://aka.ms/new-console-template for more information

// #region 1
// int[] arr1 = new int[100];
// for(int i = 0; i < arr1.Length; i++){
//     arr1[i] = i;
// }
// Console.WriteLine(string.Join(",", arr1));
// #endregion

// #region 2
// int[] arr2 = new int[100];
// for(int i = 0; i < arr2.Length; i++){
//     arr2[i] = arr1[i] * 2;
// }
// Console.WriteLine(string.Join(",", arr2));
// #endregion

// #region 3
// Random r1 = new Random();
// int[] arr3 = new int[10];
// for(int i = 0; i < arr3.Length; i++){
//     arr3[i] = r1.Next(0, 101);
// }
// Console.WriteLine(string.Join(",", arr3));
// #endregion

// #region 4
// Random r = new Random();
// int[] arr = new int[10];
// for(int i = 0; i < arr.Length; i++){
//     arr[i] = r.Next(0, 101);
// }
// Console.WriteLine("原数组："+string.Join(",", arr));
// //MAX MIN
// int max = arr[0];
// int min = arr[0];
// int sum = 0;
// for(int i = 0; i < arr.Length - 1; i++){
//     max = (max >= arr[i])? max : arr[i];
//     min = (min <= arr[i])? min : arr[i];
//     sum += arr[i];
// }
// Console.WriteLine("最大值："+max);
// Console.WriteLine("最小值："+min);
// Console.WriteLine("和："+sum);
// double avg = (double)sum / arr.Length;
// Console.WriteLine("平均值："+avg);
// #endregion

// #region 5
// Random r2 = new Random();
// int[] arr4 = new int[10];
// for(int i = 0; i < arr4.Length; i++){
//     arr4[i] = r2.Next(0, 101);
// }
// Console.WriteLine("原数组："+string.Join(",", arr4));
// for(int i = 0; i < arr4.Length /2; i++){
//     arr4[i] = arr4[i] + arr4[arr4.Length-1-i];
//     arr4[arr4.Length-1-i] = arr4[i] - arr4[arr4.Length-1-i];
//     arr4[i] = arr4[i] - arr4[arr4.Length-1-i];
// }
// Console.WriteLine("反转后："+string.Join(",", arr4));
// #endregion

// #region 6
// Random r3 = new Random();
// int[] arr5 = new int[10];
// for(int i = 0; i < arr5.Length; i++){
//     arr5[i] = r3.Next(-100, 101);
// }
// Console.WriteLine("原数组："+string.Join(",", arr5));
// for(int i = 0; i < arr5.Length; i++){
//     if(arr5[i]>0) arr5[i]++;
//     else if(arr5[i]<0) arr5[i]--;
// }
// Console.WriteLine("变化后："+string.Join(",", arr5));
// #endregion

// #region 7
// int[] arr6 = new int[10];
// //输入
// try{
//     for(int i = 0; i < arr6.Length; i++){
//         Console.Write("请输入第{0}个元素：", i+1);
//         arr6[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// catch{
//     Console.WriteLine("输入有误，程序退出");
// }

// Console.WriteLine("原数组："+string.Join(",", arr6));
// //MAX MIN
// int max = arr6[0];
// int min = arr6[0];
// int sum = 0;
// for(int i = 0; i < arr6.Length - 1; i++){
//     max = (max >= arr6[i])? max : arr6[i];
//     min = (min <= arr6[i])? min : arr6[i];
//     sum += arr6[i];
// }
// Console.WriteLine("最大值："+max);
// Console.WriteLine("最小值："+min);
// Console.WriteLine("平均值："+(double)sum / arr6.Length);

// #endregion

// #region 8
string[] arr7 = new string[25];
for(int i = 0; i < arr7.Length; i++){
    arr7[i] = (i%2 == 0)? "■": "□";
}
for(int i = 0; i < arr7.Length; i++){
    Console.Write(arr7[i]);
    if((i+1)%5 == 0 && i!= 0){
        Console.WriteLine();
    }

}
// #endregion
