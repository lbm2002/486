using static System.Console;

namespace SmartLin.LearningCSharp.Basics
{
	class Program
	{
		static void Main()
		{
			bool isValid = false;
			float rate = 0;
			while (true)                                                    //while适用于循环次数未知的场景；
			{
				Write($"请输入评教成绩：");
				var input = ReadLine();
				isValid = float.TryParse(input, out rate);                  
				if (!isValid)
				{
					continue;                                               //continue将跳至下一次循环；
				}
				break;                                                      //break将结束循环；
			}
			WriteLine($"评教成绩{rate}已保存。");
			Read();
		}
	}
}
