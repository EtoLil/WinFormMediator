using System;
using System.Windows.Forms;

namespace WinFormMediator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var component1 = new Component1();
            var component2 = new Component2();

            var mediator = new ConcreteMediator(component1, component2);

            component1.Show();
            component2.Show();
        }
    }
}
