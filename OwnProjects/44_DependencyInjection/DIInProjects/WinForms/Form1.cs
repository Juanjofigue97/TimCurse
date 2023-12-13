using DIDemoLibrary;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1(IMessages messages)
        {
            InitializeComponent();

            HelloText.Text = messages.SayHello();
            goodbyeText.Text = messages.SayGoodbye();
        }
    }
}
