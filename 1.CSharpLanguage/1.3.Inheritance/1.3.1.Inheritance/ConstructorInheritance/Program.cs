﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
            Student boy = new Student("3180707000", "张三", Gender.MALE)              //派生类的构造函数实际调用基类的构造函数；
			{
                BirthDate = new DateTime(2000, 1, 2),
                PhoneNumber = "18900001111",
			};
			boy.Intro();                                                             
			boy.SendSms("请及时评教。");
			Read();
		}
	}
}