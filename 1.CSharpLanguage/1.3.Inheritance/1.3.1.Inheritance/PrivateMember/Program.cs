using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	class Program
    {
        static void Main()
        {
			Student boy = new Student("3210707000", "张三", Gender.MALE)              
			{
				BirthDate = new DateTime(2003, 1, 2),
				PhoneNumber = "18900001111",
			};
			boy.Intro();
			boy.SendSms("请及时评教。");
			Read();
		}
	}
}