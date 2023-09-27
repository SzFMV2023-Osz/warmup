namespace AutomatedCar.SystemComponents.Sensors
{
    using AutomatedCar.Models;
    using AutomatedCar.SystemComponents.Packets;
    using System;

    public class DummySensor : SystemComponent
    {
        private DummyPacket dummyPacket;
        public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
        {

        }
        public override void Process()
        {

        }
    }
}