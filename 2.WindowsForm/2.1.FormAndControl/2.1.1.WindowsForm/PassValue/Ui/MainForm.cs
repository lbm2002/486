using System.Windows.Forms;

namespace SmartLin.LearningCSharp.FormAndControl
{
    /// <summary>
    /// 主窗体；
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 用户；
        /// </summary>
        private User _User;
        /// <summary>
        /// 构造函数；
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.FormClosed += this.MainForm_FormClosed;                                //注册窗体关闭事件的处理方法；
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="user">用户</param>
        public MainForm(User user) : this()
        {
            this._User = user;
            MessageBox.Show($"即将进入{ this.Text}，{this._User.Name}。", "消息");
        }
        /// <summary>
        /// 主窗体的窗体关闭；
        /// </summary>
        /// <param name="sender">发送方</param>
        /// <param name="e">窗体关闭事件</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"再见，{this._User.Name}。", "消息");
            Application.Exit();                                                         //应用程序关闭；所有窗体均将关闭，且不触发窗体关闭事件；
        }
    }
}