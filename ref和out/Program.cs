namespace ref和out;

class Program
{
    // #region 为什么要学习ref和out？
    // //正常来说，我们在调用函数的时候，传递的是值，函数内部修改这个值，并不会影响到外部的变量。
    // //只有当传入参数是引用类型且引用类型没有被重新赋值时，才会影响到外部的变量。
    // static void ChangeValue(int value){
    //     value = 1;
    // }
    // static void ChangeArrValue(int[] arr){
    //     arr[0] = 1;
    // }
    // static void ChangeArr(int[] arr){
    //     arr = new int[]{1};
    // }
    // #endregion

    #region ref和out的使用
    //ref
    static void ChangeValueRef(ref int value){
        value = 1;
    }
    static void ChangeArrRef(ref int[] arr){
        arr = new int[]{1};
    }
    static void ChangeValueRef2(ref int value){
        // value = 1;
    }

    //out
    static void ChangeValueOut(out int value){
        value = 2;
    }
    static void ChangeArrOut(out int[] arr){
        arr = new int[]{2};
    }
    // 报错，因为out修饰的传入变量必须在函数内部赋值，ref不需要
    // static void ChangeValueOut2(out int value){
    //     // value = 2;
    // }

    #endregion
    

    static void Main(string[] args)
    {
        // int value = 0;
        // //传入函数的只是这个变量，没有返回，所以值不变
        // ChangeValue(value);
        // Console.WriteLine("正常传入参数,值不变: "+value); // Output: 0

        // ChangeValueRef(ref value);
        // Console.WriteLine("加了ref关键字,值变了: "+value); // Output: 1
        // ChangeValueOut(out value);
        // Console.WriteLine("加了out关键字,值变了: "+value); // Output: 2

        // int[] arr1 = new int[1];
        // //传入函数的是arr的地址，arr和arr1都指向arr1的地址，所以值会变
        // ChangeArrValue(arr1);
        // Console.WriteLine(arr1[0]); // Output: 1
        

        // int[] arr2 = new int[1];
        // //因为函数ChangeArr中arr新开辟了一个地址，与传入的数组的地址不再有关联，所以值不变
        // ChangeArr(arr2);
        // Console.WriteLine("正常传入参数,值不变: "+arr2[0]); // Output: 0
        // ChangeArrRef(ref arr2);
        // Console.WriteLine("加了ref关键字,值变了: "+arr2[0]); // Output: 1
        // ChangeArrOut(out arr2);
        // Console.WriteLine("加了out关键字,值变了: "+arr2[0]); // Output: 2
        #region ref和out的区别
        //ref修饰的传入变量必须初始化，out不需要
        //out修饰的传入变量必须在函数内部赋值，ref不需要
        int value;
        // ChangeValueRef(ref value);   报错
        ChangeValueOut(out value);

        //其实总的来看，
        // ref传入的变量必须初始化，所以在函数内部就可以不赋值
        // out传入的变量可以不初始化，所以在函数内部必须赋值
        
        #endregion
    }
}
