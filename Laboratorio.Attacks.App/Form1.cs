using Laboratorio.Attacks.App.Attacks;

namespace Laboratorio.Attacks.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FakeRansom.ExecuteRansom();
        }
    }
}
