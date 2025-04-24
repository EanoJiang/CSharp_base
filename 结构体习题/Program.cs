namespace 结构体习题
{

    class Program
    {
        #region 1
        struct Student{
        public string name;
        public int age;
        public bool isMale;
        public int classNum;
        public string subject;
        public Student(string name, int age, bool isMale, int classNum, string subject){
            this.name = name;
            this.age = age;
            this.isMale = isMale;
            this.classNum = classNum;
            this.subject = subject;
        }
        public void PrintInfo(){
            Console.WriteLine("Name:{0}, Age:{1}, Gender:{2}, Class:{3}, Subject:{4}", name, age, isMale? "Male" : "Female", classNum, subject);
        }
    }
    #endregion
        
        #region 3
        struct Rectangle{
            public int height;
            public int width;
            public Rectangle(int height, int width){
                this.height = height;
                this.width = width;
            }
            public void PrintInfo(){
                Console.WriteLine("Rectangle length: {0}, width: {1}, area: {2}, perimeter: {3}", height, width, height * width, 2 * (height + width));
            }
        }
        #endregion
        
        #region 4
        enum Occupation{
                /// <summary>
                /// 战士
                /// </summary>
                warrior,
                /// <summary>
                /// 法师
                /// </summary>
                mage,
                /// <summary>
                /// 猎人
                /// </summary>
                hunter,

            }
        struct Player{
            public string playerName;
            public Occupation playerOccupation;

            public Player(string playerName, Occupation playerOccupation){
                this.playerName = playerName;
                this.playerOccupation = playerOccupation;
            }
            public void PrintAtkInfo(){
                string occupation = "";
                string skill = "";
                switch(playerOccupation){
                    case Occupation.warrior: 
                        occupation = "战士";
                        skill = "冲锋";
                        break;
                    case Occupation.mage:
                        occupation = "法师";
                        skill = "奥术攻击";
                        break;
                    case Occupation.hunter:
                        occupation = "猎人";
                        skill = "假死";
                        break;

                }
                Console.WriteLine("{0}{1}释放了{2}", occupation, playerName,skill);

                }
            }
            
        #endregion
        
        #region 5
        struct Monster{
            public string name;
            public int attack;
            public Monster(string name, int attack){
                this.name = name;
                this.attack = attack;
            }
            public void PrintInfo(){
                Console.WriteLine("{0}的攻击力为{1}", name, attack);
            }
        }
        #endregion

        #region 7
        struct OutMan{
            public string name;
            public int attack;
            public int hp;
            public int defence;
            public OutMan(string name, int attack, int hp, int defence){
                this.name = name;
                this.attack = attack;
                this.hp = hp;
                this.defence = defence;
            }
            public void PrintInfo(){
                Console.WriteLine("{0}的攻击力为{1}", name, attack);
            }
            public void Attack(ref Boss boss) {
                if (boss.attack > defence) {
                    boss.hp -= (attack - boss.defence);
                    Console.WriteLine("{0}攻击了{1}, 造成{2}点伤害, {3}剩余{4}点血量", name, boss.name, attack - boss.defence, boss.name, boss.hp);
                }
                else {
                    Console.WriteLine("{0}闪避了{1}的攻击", name, boss.name);
                }
            }

        }   
        struct Boss{
            public string name;
            public int attack;
            public int hp;
            public int defence;
            public Boss(string name, int attack, int hp, int defence){
                this.name = name;
                this.attack = attack;
                this.hp = hp;
                this.defence = defence;
            }
            public void PrintInfo(){
                Console.WriteLine("{0}的攻击力为{1}", name, attack);
            }
            public void Attack(ref OutMan outman) {
                if (outman.attack > defence) {
                    outman.hp -= (attack - outman.defence);
                    Console.WriteLine("{0}攻击了{1}, 造成{2}点伤害, {3}剩余{4}点血量", name, outman.name, attack - outman.defence, outman.name, outman.hp);
                }
                else {
                    Console.WriteLine("{0}闪避了{1}的攻击", name, outman.name);
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {   //1
            Student s1 = new Student("John", 18, true, 101, "Math");
            s1.PrintInfo();
            
            //2
            // private只能在类内部访问
            // public可以在类外部访问
            
            //3
            Rectangle r1 = new Rectangle(5, 10);
            r1.PrintInfo();

            //4
            Player p1 = new Player("唐老师", Occupation.hunter);
            p1.PrintAtkInfo();

            //6
            Monster[] monstersName = new Monster[10];
            Random r = new Random();
            for(int i = 0; i < 10; i++){
                //用结构体构造函数初始化每个怪物的名字:
                // monstersName[i].name 、 monstersName[i].attack
                monstersName[i] = new Monster("怪物" + i, r.Next(100));
                monstersName[i].PrintInfo();
            }

            //7
            OutMan outMan = new OutMan("路飞", 50, 100, 55);
            Boss boss = new Boss("索隆", 60, 200, 30);
            while(outMan.hp > 0 && boss.hp > 0){
                outMan.Attack(ref boss);
                boss.Attack(ref outMan);
            }

        }
    }
}