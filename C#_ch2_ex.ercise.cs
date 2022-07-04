Console.WriteLine("現在的燈號是...?");
string light = Console.ReadLine();
if (light == "綠燈") { Console.WriteLine("踩油門過馬路"); }
else if (light == "黃燈") { Console.WriteLine("依照距離判斷停或過"); }
else if (light == "紅燈") { Console.WriteLine("踩剎車停止"); }

student student1 = new student("小白", 10, "白白國小");

Console.WriteLine(student1.age);

student1.PrintName();


Console.ReadKey();