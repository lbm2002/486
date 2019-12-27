﻿using System;

namespace SmartLin.LearningCSharp.ClassAndObject
{
    public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
    public class Student                                                    
    {
		public string Number { get; private set; }
		public string Name { get; private set; }
		public Gender Gender { get; private set; }
		public DateTime BirthDate { get; set; }
		public int Age
		=>	DateTime.Now.Year - this.BirthDate.Year;
		public string PhoneNumber { get; set; }
		public Class Class { get; private set; }
        public Student(string number, string name, Gender gender)                       //定义构造函数（重载1）；编译器将不再自动提供默认的（无参数）构造函数；
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
        public Student(string number, string name, Gender gender, Class currentClass)   //定义构造函数（重载2）；
            : this(number, name, gender)                                                //构造函数初始化器，用于调用参数匹配的其它构造函数；
        {                                                                               //先执行构造函数初始化器调用的其它构造函数，后执行本构造函数；
            this.Class = currentClass;
        }
    }
}
