using System.Windows.Forms;
using WinFormMediator.Interfaces;

namespace WinFormMediator.Base
{
    public partial class BaseComponent : Form
    {
        protected IMediator? _mediator;

        public BaseComponent()
        {
            InitializeComponent();
        }

        public BaseComponent(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
