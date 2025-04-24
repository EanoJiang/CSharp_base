#region 1
static void BubbleSortUp(int[] arr){
    for(int n = 0; n < arr.Length; n++){
        bool isSwap = false;
        for(int i = 0; i < arr.Length - 1 - n; i++){
            //大于后面的就换位置，也就是大的放后面
            if(arr[i] > arr[i+1]){
                int temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
                isSwap = true;
            }
        }
        if(!isSwap) break;  
    }
}
static void BubbleSortDown(int[] arr){
    for(int n = 0; n < arr.Length; n++){
        bool isSwap = false;
        for(int i = 0; i < arr.Length - 1 - n; i++){
            //小于后面的就换位置，也就是小的放后面
            if(arr[i] < arr[i+1]){
                int temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
                isSwap = true;
            }
        }
        if(!isSwap) break;  
    }
}
int[] arr1 = new int[20];
Random r1 = new Random();
for(int i = 0; i < arr1.Length; i++){
    arr1[i] = r1.Next(0, 101);
}
Console.WriteLine("Before Sort:"+string.Join(",", arr1));
BubbleSortUp(arr1);
Console.WriteLine("After Sort Up:"+string.Join(",", arr1));
BubbleSortDown(arr1);
Console.WriteLine("After Sort Down:"+string.Join(",", arr1));
#endregion

#region 2
static void BubbleSort_UpOrDown(int[] arr,bool isUp){
    for(int n = 0; n < arr.Length; n++){
        bool isSwap = false;
        for(int i = 0; i < arr.Length - 1 - n; i++){
            if(isUp){
                //大于后面的就换位置，也就是大的放后面
                if(arr[i] > arr[i+1]){
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    isSwap = true;
                }
            }
            else{
                //小于后面的就换位置，也就是小的放后面
                if(arr[i] < arr[i+1]){
                    int temp = arr[i];
                    arr[i] = arr[i+1];
                    arr[i+1] = temp;
                    isSwap = true;
                }
            } 
        }
        if(!isSwap) break; 
    }
}
int[] arr2 = new int[20];
Random r2 = new Random();
for(int i = 0; i < arr2.Length; i++){
    arr2[i] = r2.Next(0, 101);
}
BubbleSort_UpOrDown(arr2,true);
Console.WriteLine("After Sort Up:"+string.Join(",", arr2));
BubbleSort_UpOrDown(arr2,false);
Console.WriteLine("After Sort Down:"+string.Join(",", arr2));
#endregion
