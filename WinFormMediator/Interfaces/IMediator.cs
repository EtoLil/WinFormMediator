using System.Drawing;
using WinFormMediator.Enums;

namespace WinFormMediator.Interfaces
{
    public interface IMediator
    {
        void Notify(Color color, Event @event);
    }
}
