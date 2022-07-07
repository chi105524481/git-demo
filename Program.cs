//  See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine(123);
//Console.WriteLine("{0} is {1}","henry","student");

#region Notes
// int Height;
// Console.Write("請輸入你的姓名：");
// string Name=Console.ReadLine();
// Console.Write("請輸入你的身高：");
// Height=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Name+" 身高 "+Height);
// Console.WriteLine("請輸入身高：");
// float Height=Convert.ToSingle(Console.ReadLine());
// Console.WriteLine("請輸入體重：");
// float Weight=Convert.ToSingle(Console.ReadLine());
// Console.WriteLine("身高為"+Height+"體重為"+Weight);
// var Height_m=Height/100;
// Console.WriteLine("身高為"+Height_m);
// // float bmi=Weight/(Height/100)**2;
// Console.WriteLine("BMI="+(Weight/((Height/100)*(Height/100))));

// Console.Write("請輸入姓名：");
// var Name=Console.ReadLine();
// Console.WriteLine("電話號碼：");
// var Phone=Console.ReadLine();
// Console.WriteLine("生日：");
// var Birthday=Console.ReadLine();
// Console.WriteLine("{0}你的生日是{1},電話是{2}",Name,Phone,Birthday);

// string a = "1234";
// int b = Convert.ToInt32(a);
// Console.WriteLine(b);
// string c="2019/09/05";
// DateTime d = Convert.ToDateTime(c);
// Console.WriteLine(d);
// double d = 23.14;
// int i = (int)d;
// int i2=123;
// string s=Convert.ToString(i2);
// string s2="12345";
// int i3=Convert.ToInt32(s2);
// long L=12345;
// byte b=(byte)L;
#endregion
using s = System;
namespace demo
{
    #region Person 小白
    // struct Person
    // {
    //     public string name;
    //     public string phone;
    //     public double height;
    //     public double weight;
    // }
    #endregion
    class Program
    {
        #region 遞迴-最大公因數
        // static int fab(int a, int b)
        // {
        //     if (a % b == 0)
        //     {
        //         return b;
        //     }
        //     else
        //     {
        //         return fab(b, a % b);
        //     }
        // }
        #endregion
        #region 遞迴-進制轉換
        static void carry(int a, int b)
        {
            int c;
            if (a < b)
            {
                // Console.WriteLine(a + "%" + b + "：餘數= " + a % b);
                Console.Write(a % b);
            }
            else if (a / b == 0 && a % b == 0)
            {
                Console.Write("0");
            }
            else
            {
                // Console.WriteLine(a + "/" + b + "：商= " + a / b);
                carry(a / b, b);
                Console.Write("e" + a % b);
            }

        }
        #endregion
        static void Main(string[] args)
        {
            #region person

            // Person Ming;
            // Ming.name = "小明";
            // Ming.phone = "0911111111";
            // Ming.height = 177;
            // Ming.weight = 70;
            // Console.WriteLine("學生："+Ming.name+ "，身高："+Ming.height +"，體重："+Ming.weight+"，電話："+Ming.phone);

            // Person Ying;
            // Ying.name = "小瑛";
            // Ying.phone = "09123456789";
            // Ying.height = 162.1;
            // Ying.weight = 70.6;
            // Console.WriteLine("學生："+Ying.name+ "/身高："+Ying.height +"/體重："+Ying.weight+"/電話："+Ying.phone);

            // Person Chi;
            // Chi.name = "小奇";
            // Chi.phone = "0800-543-210";
            // Chi.height = 166.6;
            // Chi.weight = 65.4;
            // Console.WriteLine("學生："+Chi.name+ "\t身高："+Chi.height +"\t體重："+Chi.weight+"\t電話："+Chi.phone);
            #endregion
            #region 猜數字
            // Random ran = new Random();             
            // int a = ran.Next(1,10);
            // Console.Write("猜數字(1~10)：");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine((a!=b)?"錯了":"對了");
            // Console.WriteLine("ans="+a);
            #endregion
            // Console.WriteLine(a3/10000);

            #endregion
            #region 猜拳
            // Random mora = new Random();
            // int m1 = mora.Next(1,4);

            // Console.Write("猜猜拳==>1=拳頭，2=剪刀，3=布：");
            // string guest = Console.ReadLine();
            // if (m1==1 && guest=="1"){
            //     Console.WriteLine("平手"+"電腦出 拳頭");
            // }
            // else if(m1==1 && guest=="2"){
            //     Console.WriteLine("你輸了，"+"電腦出 拳頭");
            // }
            // else if(m1==1 && guest=="3"){
            //     Console.WriteLine("你贏了，"+"電腦出 拳頭");
            // }
            // else if(m1==2 && guest=="1"){
            //     Console.WriteLine("你贏了，"+"電腦出剪刀");
            // }
            // else if(m1==2 && guest=="2"){
            //     Console.WriteLine("平手，"+"電腦出 剪刀");
            // }
            // else if(m1==2 && guest=="3"){
            //     Console.WriteLine("你輸了，"+"電腦出 剪刀");
            // }
            // else if(m1==3 && guest=="1"){
            //     Console.WriteLine("你輸了，"+"電腦出 布");
            // }
            // else if(m1==3 && guest=="2"){
            //     Console.WriteLine("你贏了，"+"電腦出 布");
            // }
            // else if(m1==3 && guest=="3"){
            //     Console.WriteLine("平手，"+"電腦出 布");
            // }            
            // else{
            //     Console.WriteLine("輸入錯誤");
            // }

            #endregion

            #region 輸入三個數字，輸出比大小
            // Console.Write("輸入三個數字比大小，請輸入第一個：");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("輸入三個數字比大小，請輸入第二個：");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.Write("輸入三個數字比大小，請輸入第三個：");
            // int c = Convert.ToInt32(Console.ReadLine());

            // if (a>b){
            //     if (a>c){
            //         if (b>c){
            //             Console.WriteLine(a + ">"+b + ">"+c);
            //         }else{
            //             Console.WriteLine(a + ">"+c + ">"+b);
            //         }
            //     }else{
            //         Console.WriteLine(c + ">"+a + ">"+b);
            //     }

            // }else{
            //     if(a<c){
            //         if(b<c){
            //             Console.WriteLine(c + ">"+b + ">"+a);
            //         }else{
            //             Console.WriteLine(b + ">"+c + ">"+a);
            //         }
            //     }else{
            //         Console.WriteLine(b + ">"+a + ">"+c);
            //     }
            // }
            #endregion
            #region 輸入三個數字，輸出Max
            // Console.Write("輸入三個數字比大小，請輸入第一個：");
            // int a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("輸入三個數字比大小，請輸入第二個：");
            // int b = Convert.ToInt32(Console.ReadLine());
            // Console.Write("輸入三個數字比大小，請輸入第三個：");
            // int c = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("最大值為： " + ((a > b ? a : b) > c ? (a > b ? a : b) : c));


            #endregion
            #region for 迴圈
            // for (int i=0;i<10;i++2){
            //     Console.Write(i+ "\t");
            // }
            #endregion
            #region 樂透產生器
            // Random lotto = new Random();
            // int a2=lotto.Next(1,50);

            #endregion
            #region 費式數列50
            // long a = 1;
            // long b = 1;
            // long c = 0;
            // Console.Write(a+" "+b+" ");
            // for (int i=0;i<48;i++){
            //     c=a+b;
            //     a=b;
            //     b=c;
            //     Console.Write(c + " ");
            // }
            // Console.Write("\n第50個數字："+c);
            #endregion
            #region 九九乘法
            // for (int i = 1; i <= 9; i++)
            // {
            //     for (int j = 1; j <= 9; j++)
            //     {
            //         Console.Write(i + "*" + j + "=" + (i * j) + "\t");
            //     }
            //     Console.WriteLine();
            // }
            #endregion
            #region 遞迴-最大公因數
            // int result = fab(12, 8);
            // Console.WriteLine(result);
            #endregion
            #region 遞迴-進制轉換
            carry(127, 8);
            // Console.WriteLine(result);
            #endregion
            Console.ReadKey();
        }
    }

}







