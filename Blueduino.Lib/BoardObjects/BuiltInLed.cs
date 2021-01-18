using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace Blueduino.Lib.BoardObjects
{
    public class BuiltInLed : BoardObject
    {
        private readonly int _ledPin;
        private bool _state;

        public BuiltInLed(ArduinoSession session,
            int ledPin = 13,
            bool initialState = false) : base(session)
        {
            _ledPin = ledPin;
            _state = initialState;
            Initialize();
        }

        protected sealed override void Initialize()
        {
            Session.SetDigitalPinMode(_ledPin, PinMode.DigitalOutput);
            Session.SetDigitalPin(_ledPin, _state);
        }

        public void Toggle()
        {
            _state = !_state;
            Session.SetDigitalPin(_ledPin, _state);
        }

        public void SetState(bool enabled)
        {
            _state = enabled;
            Session.SetDigitalPin(_ledPin, _state);
        }
    }
}
