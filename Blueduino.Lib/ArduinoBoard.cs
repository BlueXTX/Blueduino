using System;
using Solid.Arduino;

namespace Blueduino.Lib
{
    public class ArduinoBoard : IDisposable
    {
        public ArduinoSession Session { get; }

        public ArduinoBoard(string portName,
            SerialBaudRate baudRate = SerialBaudRate.Bps_57600)
        {
            Session = new ArduinoSession(
                new EnhancedSerialConnection(portName, baudRate)
            );
        }

        public void Dispose()
        {
            Session?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
