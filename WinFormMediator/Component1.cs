using System.Drawing;
using WinFormMediator.Base;
using WinFormMediator.Enums;

namespace WinFormMediator
{
    public partial class Component1 : BaseComponent
    {
        private Color _color = Color.Red;
        public Component1()
        {
            this.BackColor = _color;
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _mediator.Notify(_color, Event.ColorChanged);
        }

        public void ChangeBackgroundColor(Color color)
        {
            BackColor = color;
        }
    }
}
