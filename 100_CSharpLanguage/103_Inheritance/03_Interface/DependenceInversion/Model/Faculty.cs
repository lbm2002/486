﻿using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 教职工；
	/// </summary>
	public class Faculty : User                                                             //定义类，派生于另一个类以及一个（或若干）接口；
    {
        /// <summary>
        /// 部门；
        /// </summary>
        public Department Department
        {
            get;
            private set;
        }
        /// <summary>
        /// 专长；
        /// </summary>
        public string Speciality
        {
            get;
            set;
        }
        /// <summary>
        /// 介绍；
        /// </summary>
        public override void Intro()                                                       
        {
			Write($"我是{this.Name.Substring(0, 1)}老师");
            if (this.Department != null)
            {
				Write($"，来自{this.Department.Name}");
            }
            else
            {
				Write("，今天刚入职");
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        public Faculty(string number, string name, string gender)
            : base(number, name, gender)                                                    
        {
            ;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="number">工号</param>
        /// <param name="name">姓名</param>
        /// <param name="gender">性别</param>
        /// <param name="department">部门</param>
        public Faculty(string number, string name, string gender, Department department)
            : this(number, name, gender)                                                    
        {
            this.Department = department;
        }                                                 
    }
}
