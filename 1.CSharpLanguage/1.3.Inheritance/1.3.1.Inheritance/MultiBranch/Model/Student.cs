﻿using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 学生；
	/// </summary>
	public class Student : User                                                 
    {
		/// <summary>
		/// 班级
		/// </summary>
		public string Class { get; set; }
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">学号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public Student(string number, string name, string gender)               
            : base(number, name, gender)                                        
        {
            ;
        }                                                 
    }
}
