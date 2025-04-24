static void Fun(int n0 = 1,int n1 = 10){
    if(n1 < n0)return;
    Console.WriteLine(n1);
    n1--;
    Fun(n0,n1);
}
Fun(1,10);
