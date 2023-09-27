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
            this.dummyPacket = new DummyPacket();
            this.virtualFunctionBus.DummyPacket = this.dummyPacket;
        }
        public override void Process()
        {
            var circle = (World.Instance.WorldObjects[0] as Circle);
            var autocar = World.Instance.ControlledCar;
            this.dummyPacket.DistanceX = Math.Abs(autocar.X - circle.X);
            this.dummyPacket.DistanceY = Math.Abs(autocar.Y - circle.Y);
        }
    }
}