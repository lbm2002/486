namespace SmartLin.LearningCSharp.Inheritance
{
    /// <summary>
    /// 公开课；
    /// </summary>
    public class OpenLesson
    {
        /// <summary>
        /// 主讲人；
        /// </summary>
        public Faculty Lecturer { get; set; }
        /// <summary>
        /// 观众；
        /// </summary>
        public IEvaluate[] Audiences { get; set; }                                      //定义属性，其类型为接口（数组）；
		/// <summary>
		/// 评教；
		/// </summary>
		public void Evaluate()
        {
            for (int i = 0; i < this.Audiences.Length; i++)
            {
                this.Audiences[i].Evaluate(this.Lecturer);                              //只能调用该接口的方法；                                         
            }
        }
    }
}
