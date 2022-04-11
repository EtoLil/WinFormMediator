using System.Drawing;
using WinFormMediator.Enums;
using WinFormMediator.Interfaces;

namespace WinFormMediator
{
    public class ConcreteMediator : IMediator
    {
        private Component1 _component1;

        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(Color color, Event @event)
        {
            switch (@event)
            {
                case Event.ColorChanged:
                    _component1.ChangeBackgroundColor(color);
                    _component2.ChangeBackgroundColor(color);
                    break;
                default:
                    break;
            }
        }
    }
}
