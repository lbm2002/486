using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Gender
	{
		public static readonly string FEMALE = "女";
		public static readonly string MALE = "男";
	}
	public class Nationality
	{
		public static readonly string HAN = "汉族";
		public static readonly string QIANG = "羌族";
		public static readonly string SHE = "畲族";
	}
	public class Student
	{
		public string Number { get; private set; }
		public string Name { get; private set; }
		public string Gender { get; private set; }
		public string Nationality { get; set; }
		public DateTime BirthDate { get; set; }
		public int Age
		=>	DateTime.Now.Year - this.BirthDate.Year;
		public string PhoneNumber { get; set; }
		public Class Class { get; private set; }
		private Student(string number, string name, string gender)                          //将构造函数定义为私有；                   
		{
			this.Number = number;
			this.Name = name;
			this.Gender = gender;
		}
		private Student(string number, string name, string gender, Class currentClass)
			: this(number, name, gender)
		{
			this.Class = currentClass;
		}
		public static Student Create(string number, string name, string gender)             
		{                                                                                   
			if (number.Length != 10)
			{
				WriteLine("学号长度应为10位！");
				Read();
				return null;
			}
			Student student = new Student(number, name, gender);                            
			return student;
		}
		public static Student Create(string number, string name, string gender, Class currentClass)
		{
			Student student = Create(number, name, gender);                                 
			if (student != null)
			{
				student.Class = currentClass;
			}
			return student;
		}
	}
}
