// See https://aka.ms/new-console-template for more information

static bool CheckLogin(string username, string password, out string message)
{
    message = "";
    if (username == "eano")
    {
        if(password == "666"){
            message = "Login successful";
            return true;
        }
        else{
            message = "Invalid password";
            return false;
        }

    }
    else
    {
        message = "Invalid username";
        return false;
    }
}

string message;

Console.WriteLine("请输入正确的用户名:");
string adminUsername = Console.ReadLine();
Console.WriteLine("请输入正确的密码:");
string adminPassword = Console.ReadLine();
while(CheckLogin(adminUsername, adminPassword, out message)== false){
    // 输出上一次的错误信息
    Console.WriteLine(message);
    Console.WriteLine("请输入正确的用户名:");
    adminUsername = Console.ReadLine();
    Console.WriteLine("请输入正确的密码:");
    adminPassword = Console.ReadLine();
}
Console.WriteLine(message);

