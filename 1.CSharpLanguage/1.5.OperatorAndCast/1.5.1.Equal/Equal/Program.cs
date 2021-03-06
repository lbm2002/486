using static System.Console;

namespace SmartLin.LearningCSharp.OperatorAndCast
{
	class Program
    {
        static void Main(string[] args)
        {
            Student
                student = new Student("3180707001", "周林好")
                , sameStudent = new Student("3180707001", "(空)")
                , student2 = new Student("20180707001", "周林好");
			WriteLine
				($"{student.Number}号{student.Name}同学" +
                 $"与{sameStudent.Number}号{sameStudent.Name}同学" +
                 $"{(student.Equals(sameStudent) ? "" : "不")}是同一人。");          //调用重写后的Equals方法，判断双方是否相等；
			WriteLine
				($"{student.Number}号{student.Name}同学" +
                 $"与{student2.Number}号{student2.Name}同学" +
                 $"{(student.Equals(student2) ? "" : "不")}是同一人。");
            Read();
        }
    }
}
