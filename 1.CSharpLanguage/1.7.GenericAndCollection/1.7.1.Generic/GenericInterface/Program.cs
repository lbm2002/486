using static System.Console;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
	class Program
    {
        static void Main()
        {
            Course Oop = new Course("2060238", "面向对象程序设计",4.5);
            Student boy = new Student("3210707001", "张三", Gender.MALE);
            CourseUi courseUi = new CourseUi();
            StudentUi studentUi = new StudentUi();
            courseUi.Display(Oop);
            studentUi.Display(boy);
            Read();
        }
    }
}
