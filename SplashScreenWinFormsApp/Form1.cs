using SplashScreen;

namespace SplashScreenWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            System.Threading.Thread.Sleep(800);
            Splasher.Status = "����չʾ��ص�����......";
            System.Threading.Thread.Sleep(1800);

            //.......�˴����غ�ʱ�Ĵ���

            Splasher.Status = "��ʼ�����............";
            System.Threading.Thread.Sleep(800);

            Splasher.Close();

        }
    }
}
