namespace 结构体;

class Program
{
    #region 语法
    // struct 结构体名{
    //     //1. 变量
    //     int 变量名;
    //     //2. 构造函数
    //     结构体名(int 变量名){
    //         this.变量名 = 变量名;
    //     }
    //     //3. 方法
    //     void 方法名(){
    //         //...
    //     }
    // }
    #endregion

    #region 示例
    struct Student{
        //1. 变量
        //结构体申明的变量 不能直接在结构体里面初始化
        //变量类型任意，包括结构体类型，但是只能是其他结构体类型，不能是自身结构体类型
        public int age;
        public bool sex; //true表示男性，false表示女性
        public string name;
        public Teacher teacher1;
        // Student student1;     //错误，不能是自身结构体类型

        //2. 构造函数
        //用于在外部初始化结构体变量
        public Student(int age, bool sex, string name, Teacher teacher1){
            this.age = age;
            this.sex = sex;
            this.name = name;
            this.teacher1 = teacher1;
        }
        //3. 方法
        //用来表现这个数据结构的行为，在结构体中不需要加static关键字
        //函数中可以直接使用结构体申明的变量
        public void Speak(){
            Console.WriteLine("Hi, my name is {0}, I am {1} years old.", name, age);
        }
    }
    struct Teacher{

    }
    #endregion

    static void Main(string[] args)
    {
        #region 结构体的使用
        Student s1;
        s1.age = 20;
        s1.sex = true;
        s1.name = "Tom";
        s1.Speak();

        //用构造函数的方式初始化结构体变量
        Student s2 = new Student(25, false, "Jerry", new Teacher());
        s2.Speak();
        
        #endregion
        
    }
}
