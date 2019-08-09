﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public enum Gender
    {
        FEMALE = 0,
        MALE = 1
    }
    public class Student                                                    
    {
        private string _Number;                                     //定义私有字段，用于保存相应属性所用的数据；只能在所属的类中访问私有成员；
        public string Number                                        //定义公有属性；
        {
            get                                                     //get访问器用于读取属性；get访问器不包含任何参数；
            {
                return this._Number;                                //返回类的当前实例的相应字段；
            }
            set                                                     //set访问器用于写入属性；
            {                                                       //若该字段尚未赋值，则予以赋值；（否则保持该字段不变）
                if (this._Number == null)                           //string作为引用类型，未初始化时的值为空；
                {
                    this._Number = value;                           //set访问器包含隐式参数value；
                }
                else
                {
                    WriteLine("已有学号，不得更改！");
                }
            }
        }
        private string _Name;
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }
        public Gender Gender
        {
            get;                                                    //自动实现属性；
            set;
        }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public int Age
        {                                                                   
            get
            {
                return DateTime.Now.Year - this.BirthDate.Year;
            }                                                       //省略set访问器，即可实现只读属性；
        }
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get
            {
                if (this._PhoneNumber != null)                      //若手机号不为空，方可进行字符串处理，否则导致异常；
                {
                    return this._PhoneNumber.Substring(0, 3) + "****" + this._PhoneNumber.Substring(7, 4);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this._PhoneNumber = value;
            }
        }
        public Class Class
        {
            get;
            set;
        }
    }
}
