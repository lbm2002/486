﻿using static System.Console;

namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 教职工；
    /// </summary>
    public class Faculty : User, IEvaluate, IScientificSubject                              //定义类，派生于另一个类以及一个（或若干）接口；
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
        /// 课题选题；
        /// </summary>
        public string SubjectTitle                                                          //实现接口中的属性；
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
			Write(this.Department == null ?
					"，今天刚入职"
					: $"，来自{this.Department.Name}");
		}
		/// <summary>
		/// 评教；
		/// </summary>
		/// <param name="faculty">教职工</param>
		public virtual void Evaluate(Faculty faculty)                                       //实现接口中的方法；
        {
			WriteLine
				($"同行对{faculty.Name}老师的评教：\n从大纲、进度、教案、讲稿、教学设计、课堂纪律等方面进行评教……\n"
				+ $"评教人：{this.Name}\n");
        }
        /// <summary>
        /// 申报课题；
        /// </summary>
        public void SubmitSubject()
        {
            WriteLine
                ("教师独立申报厅级或以上级别课题，选题为《{0}》。"
                , this.SubjectTitle);
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
