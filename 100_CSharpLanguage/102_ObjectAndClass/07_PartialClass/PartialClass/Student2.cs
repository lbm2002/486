﻿using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public partial class Student                                                        //定义部分类；                                                
    {
        public string Email { get; set; }
        public void SendEmail(string message)
        {
            if (this.Email != null)
            {
				WriteLine($"发送电子邮件至{this.Email}：{message}");
            }
            else
            {
                WriteLine("尚未登记电子邮件。");
            }
        }
    }
}
