// 选择排序
//升序, 中间商:maxIndex,目标位置:arr[arr.Length - 1 - n]
static void SelectionSort(int[] arr){
    //n轮
    for(int n = 0; n < arr.Length - 1; n++){
        int maxIndex = 0;
        //用中间商找出每轮的最优元素maxIndex
        //只需要从1到arr.Length - n - 1遍历
        // 不需要和第0个比较(因为中间商就是索引0)，不需要和末尾的元素比较,因为arr[arr.Length - 1 - n]后面的元素在前面n轮已经排好序了
        for(int i = 1; i < arr.Length - n; i++){
            //更新中间商的索引为较大值的索引
            if(arr[i] > arr[maxIndex]){
                maxIndex = i;
            }
        }
        //交换极值和目标位置(末尾)的元素
        //交换条件：中间商不是目标位置
        if(maxIndex!= arr.Length - 1 - n){
            int tmp = arr[arr.Length - 1 - n];
            arr[arr.Length - 1 - n] = arr[maxIndex];
            arr[maxIndex] = tmp;
        }     
    }
}

int[] arr = {5, 3, 8, 6, 2, 7, 1, 4};
SelectionSort(arr);
Console.WriteLine(string.Join(" ", arr));