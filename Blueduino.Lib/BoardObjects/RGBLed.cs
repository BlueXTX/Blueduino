using Blueduino.Lib.Models;
using Solid.Arduino;
using Solid.Arduino.Firmata;

namespace Blueduino.Lib.BoardObjects
{
    public class RgbLed : BoardObject
    {
        private readonly int _redPin;
        private readonly int _greenPin;
        private readonly int _bluePin;

        public RgbLed(ArduinoSession session, int redPin, int greenPin, int bluePin) :
            base(session)
        {
            _redPin = redPin;
            _greenPin = greenPin;
            _bluePin = bluePin;
            Initialize();
        }

        protected sealed override void Initialize()
        {
            Session.SetDigitalPinMode(_redPin, PinMode.DigitalInput);
            Session.SetDigitalPinMode(_greenPin, PinMode.DigitalInput);
            Session.SetDigitalPinMode(_bluePin, PinMode.DigitalInput);
        }

        public void SetColor(Color color)
        {
            Session.SetDigitalPin(_redPin, color.Red);
            Session.SetDigitalPin(_greenPin, color.Green);
            Session.SetDigitalPin(_bluePin, color.Blue);
        }
    }
}
