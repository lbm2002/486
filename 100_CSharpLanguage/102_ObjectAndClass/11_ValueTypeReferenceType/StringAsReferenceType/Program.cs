﻿using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	class Program
	{
		static void Main()
		{
			string fjtcm = "福建中医药大学", myUniversity = "福建中医药大学";				//字符串属于内置类型，但非值类型，而是引用类型；
			WriteLine
				($"fjtcm{(fjtcm == myUniversity ? "等于" : "不等于")}myUniversity");	//但字符串的比较方式与值类型相同，只比较值；
			myUniversity = fjtcm;                                                   //字符串的赋值遵照引用类型的默认赋值方式，只复制引用（即地址）；
			fjtcm = "FuJian Traditional Chinese Medicine";							//但若向字符串变量赋予新值，则新值将存入新地址，且变量指向新地址；
			WriteLine
				($"fjtcm{(fjtcm == myUniversity ? "等于" : "不等于")}myUniversity");
			Read();
		}
	}
}
