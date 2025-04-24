//冒泡排序
static int[] BubbleSort(int[] arr){
    // 数组几个数就需要进行n轮冒泡
    for(int n=0;n<arr.Length;n++){
        //每轮冒泡
        // 数组长度减去第n轮，因为每轮冒泡都会将最大的数冒泡到最后面，所以不需要再比较后面的数
        for(int i=0;i<arr.Length-1 - n;i++){
            if(arr[i]>arr[i+1]){
                arr[i] = arr[i] + arr[i+1];
                arr[i+1] = arr[i] - arr[i+1];
                arr[i] = arr[i] - arr[i+1];
            }
        }
    }
    return arr;
}

//优化后的冒泡排序
static int[] BubbleSort2(int[] arr){
    // 数组几个数就需要进行n轮冒泡
    for(int n=0;n<arr.Length;n++){
        //每轮冒泡开始前，标志位isSwap置为false
        bool isSwap = false;
        //每轮冒泡
        // 数组长度减去第n轮，因为每轮冒泡都会将最大的数冒泡到最后面，所以不需要再比较后面的数
        for(int i=0;i<arr.Length-1 - n;i++){
            if(arr[i]>arr[i+1]){
                int tmp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = tmp;
                //每次交换后，isSwap置为true
                isSwap = true;
            }
        }
        //如果本轮没有发生交换，说明已经排序好了，即刻退出循环
        if(!isSwap)break;
    }
    return arr;
}

int[] arr = { 3, 5, 8, 6, 2, 7, 1, 4};
BubbleSort(arr);
Console.WriteLine(string.Join(",", arr));

int[] arr2 = { 3, 5, 8, 6, 2, 7, 1, 4};
BubbleSort2(arr2);
Console.WriteLine(string.Join(",", arr2));