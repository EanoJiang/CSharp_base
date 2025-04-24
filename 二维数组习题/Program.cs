// See https://aka.ms/new-console-template for more information
#region 1
// int[,] arr1 = new int[100, 100];
// int count = 1;
// Console.WriteLine("1到10000的二维数组：");
// for (int i = 0; i < arr1.GetLength(0); i++){
//     for (int j = 0; j < arr1.GetLength(1); j++){
//         arr1[i, j] = count;
//         count++;
//         Console.Write(arr1[i, j] + " ");
//     }
//     Console.WriteLine();
// }
#endregion

#region 2
// int[,] arr2 = new int[4, 4];
// Random r = new Random();
// Console.WriteLine("随机生成的4x4二维数组：");
// for (int i = 0; i < arr2.GetLength(0); i++){
//     for (int j = 0; j < arr2.GetLength(1); j++){
//         arr2[i, j] = r.Next(1, 101);
//         Console.Write(arr2[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("将数组的右上角区域清零：");
// for (int i = 0; i < arr2.GetLength(0); i++){
//     for (int j = 0; j < arr2.GetLength(1); j++){
//         if(i < arr2.GetLength(0) / 2 && j >= arr2.GetLength(1) / 2){
//             arr2[i, j] = 0;
//         }
//         Console.Write(arr2[i, j] + " ");
//     }
//     Console.WriteLine();
// }
#endregion

#region 3
// int[,] arr3 = new int[3, 3];
// Random r = new Random();
// Console.WriteLine("随机生成的3x3二维数组：");
// for (int i = 0; i < arr3.GetLength(0); i++){
//     for (int j = 0; j < arr3.GetLength(1); j++){
//         arr3[i, j] = r.Next(1, 11);
//         Console.Write(arr3[i, j] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("对角线:");
// int sum = 0;
// for (int i = 0; i < arr3.GetLength(0); i++){
//     for (int j = 0; j < arr3.GetLength(1); j++){
//         if(i == j || i+j == 3-1){
//             sum += arr3[i, j];
//             Console.Write(arr3[i, j] + " ");
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("对角线的和为：" + sum);

#endregion

#region 4
// int[,] arr4 = new int[5, 5];
// Random r = new Random();
// //记录最大值的位置
// int maxRow = 0, maxCol = 0;
// Console.WriteLine("随机生成的5x5二维数组：");
// for (int i = 0; i < arr4.GetLength(0); i++){
//     for (int j = 0; j < arr4.GetLength(1); j++){
//         arr4[i, j] = r.Next(1, 11);
//         Console.Write(arr4[i, j] + " ");
//         if(arr4[maxRow, maxCol] < arr4[i, j]){
//             maxRow = i;
//             maxCol = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("最大值{0}的位置：({1},{2})" , arr4[maxRow, maxCol], maxRow, maxCol);

// Console.WriteLine("****所有最大值元素{0}的位置****");
// for(int i = 0; i < arr4.GetLength(0); i++){
//     for(int j = 0; j < arr4.GetLength(1); j++){
//         if(arr4[i,j] == arr4[maxRow, maxCol]){
//         Console.WriteLine("最大值{0}的位置：({1},{2})" , arr4[maxRow, maxCol], i, j);
//         }
//     }
// }

#endregion

#region 5
// int[,] arr5 = new int[5, 5] {   { 0,0,0,0,0},
//                                 { 0,0,0,0,0},
//                                 { 0,0,1,1,0},
//                                 { 0,0,0,0,0},
//                                 { 0,0,0,0,0}};

// void transArray(int[,] arr){
//     //用来记录行和列是否有1的真值数组
//     bool[] boolRow = new bool[arr.GetLength(0)];
//     bool[] boolCol = new bool[arr.GetLength(1)];
//     //标记行和列
//     for(int i = 0; i < arr.GetLength(0); i++){
//         for(int j = 0; j < arr.GetLength(1); j++){
//             if(arr[i,j] == 1){
//                 boolRow[i] = true;
//                 boolCol[j] = true;
//             }
//         }
//     }
//     //转置
//     for(int i = 0; i < arr.GetLength(0); i++){
//         for(int j = 0; j < arr.GetLength(1); j++){
//             if(boolRow[i] == true || boolCol[j] == true){
//                 arr[i,j] = 1;
//             }
//         }
//     }
// }
// transArray(arr5);
// Console.WriteLine("转置后的数组：");
// for (int i = 0; i < arr5.GetLength(0); i++){
//     for (int j = 0; j < arr5.GetLength(1); j++){
//         Console.Write(arr5[i, j] + " ");
//     }
//     Console.WriteLine();
// }

#endregion
