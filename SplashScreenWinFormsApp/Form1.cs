using SplashScreen;

namespace SplashScreenWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            System.Threading.Thread.Sleep(800);
            Splasher.Status = "正在展示相关的内容......";
            System.Threading.Thread.Sleep(1800);

            //.......此处加载耗时的代码

            Splasher.Status = "初始化完毕............";
            System.Threading.Thread.Sleep(800);

            Splasher.Close();

        }
    }
}
