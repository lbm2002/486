using System;
using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
	/// <summary>
	/// 性别；
	/// </summary>
	public class Gender
	{
		public static readonly string MALE = "男";
		public static readonly string FEMALE = "女";
	}
	/// <summary>
	/// 用户；
	/// </summary>
	public abstract class User                                                      //定义抽象类：
    {
        /// <summary>
        /// 编号；
        /// </summary>
        public string Number { get; private set; }
		/// <summary>
        /// 姓名；
        /// </summary>
        public string Name { get; private set; }
		/// <summary>
		/// 性别；
		/// </summary>
		public string Gender { get; private set; }
        /// <summary>
        /// 电话；
        /// </summary>
        public string PhoneNumber { get; set; }
		/// <summary>
		/// 介绍；
		/// </summary>
		public virtual void Intro()                                                 
        =>	Write($"我叫{this.Name}");
        /// <summary>
        /// 发送短信；
        /// </summary>
        /// <param name="message">消息</param>
        public virtual void SendSms(string message)                                 //定义虚方法；抽象类可包含虚方法；
		{
			if (this.PhoneNumber == null)
			{
				WriteLine("用户尚未登记手机号。");
				return;
			}
			WriteLine($"发送短信至用户手机{this.PhoneNumber}：{message}");
		}
		/// <summary>
		/// 构造函数；
		/// </summary>
		/// <param name="number">编号</param>
		/// <param name="name">姓名</param>
		/// <param name="gender">性别</param>
		public User(string number, string name, string gender)                      //抽象类不能被实例化，但可提供构造函数，便于派生类调用；                 
        {
            this.Number = number;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
