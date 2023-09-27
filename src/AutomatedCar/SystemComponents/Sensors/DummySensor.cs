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
            var circle = (World.Instance.WorldObjects[0] as Circle);
            var autocar = World.Instance.ControlledCar;
            this.dummyPacket = new DummyPacket() { DistanceX = Math.Abs(autocar.X - circle.X), DistanceY = Math.Abs(autocar.Y - circle.Y) };
            base.virtualFunctionBus.DummyPacket = this.dummyPacket;
        }
    }
}