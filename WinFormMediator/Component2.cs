using System.Drawing;
using WinFormMediator.Base;
using WinFormMediator.Enums;

namespace WinFormMediator
{
    public partial class Component2 : BaseComponent
    {
        private Color _color = Color.Green;
        public Component2()
        {
            BackColor = _color;
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            BackColor = _color;
            _mediator.Notify(_color, Event.ColorChanged);
        }

        public void ChangeBackgroundColor(Color color)
        {
            BackColor = color;
        }
    }
}
