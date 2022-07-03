Console.Write("請輸入您的名字：");
string name = Console.ReadLine();
Console.WriteLine("我猜" + name + "您一定是男生!!");
Console.WriteLine("所以...您真的是男生嗎(y/n)");
string sex = Console.ReadLine();
if (sex == "y" || sex == "Y")
{
    Console.WriteLine("YES!我猜對了!");
}
else
{
    Console.WriteLine("喔NO~希望我這樣的行為沒有傷到你!");
}













Console.ReadKey();