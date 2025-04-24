static void SelectionSort(int[] arr,bool isUp){
    for(int n = 0; n < arr.Length - 1; n++){
        int bestIndex = 0;
        for(int i = 1; i < arr.Length - n; i++){
            if(isUp){
                if(arr[i] > arr[bestIndex]){
                    bestIndex = i;
                }
            }else{
                if(arr[i] < arr[bestIndex]){
                    bestIndex = i;
                }
            }
        }
        if(bestIndex!=arr.Length-n-1){
            int temp = arr[arr.Length-n-1];
            arr[arr.Length-n-1] = arr[bestIndex];
            arr[bestIndex] = temp;
        }
    }
}

int[] arr = new int[20];
Random r = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 101);
}
Console.WriteLine("Before Sort:"+string.Join(",",arr));
SelectionSort(arr,true);
Console.WriteLine("After Sort Up:"+string.Join(",",arr));
SelectionSort(arr,false);
Console.WriteLine("After Sort Down:"+string.Join(",",arr));

