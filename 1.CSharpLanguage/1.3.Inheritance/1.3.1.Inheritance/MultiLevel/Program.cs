﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
			Undergraduate boy = new Undergraduate("3190707000", "张三", Gender.MALE)
			{
				BirthDate = new DateTime(2000, 1, 2),
				PhoneNumber = "18900001111",
				Class = "19信管",
				Instructor = "林立"                                                                      //派生类访问自身的属性；
			};
			Postgraduate girl = new Postgraduate("2190757001", "李四", Gender.FEMALE)
			{
				Supervisor = "杨雪梅"
			};
			boy.Intro();																				//派生类调用基类的方法；
			girl.Intro();
            boy.SendSms("请及时评教。");																	  
			boy.Register();                                                                             //派生类调用基类的方法；
            girl.Register();
            girl.AssignDirection("数据可视化");                                                          //派生类调用自身的方法；
			Read();
        }
    }
}