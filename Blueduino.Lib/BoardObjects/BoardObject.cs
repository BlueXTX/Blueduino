using Solid.Arduino;

namespace Blueduino.Lib.BoardObjects
{
    public abstract class BoardObject
    {
        protected readonly ArduinoSession Session;

        protected BoardObject(ArduinoSession session)
        {
            Session = session;
        }

        protected abstract void Initialize();
    }
}
