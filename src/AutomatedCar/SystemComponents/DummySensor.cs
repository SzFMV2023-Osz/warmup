namespace AutomatedCar.SystemComponents
{
    using AutomatedCar.Models;
    using AutomatedCar.SystemComponents.Packets;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class DummySensor : SystemComponent
    {
        private DummyPacket dummyPacket;
        public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
        {
            this.dummyPacket = new DummyPacket();
            this.virtualFunctionBus.DummyPacket = this.dummyPacket;
        }

        public override void Process()
        {
            var circle = World.Instance.WorldObjects[0] as Circle;
            var car = World.Instance.ControlledCar;

            this.dummyPacket.DistanceX = Math.Abs(car.X - circle.X);
            this.dummyPacket.DistanceY = Math.Abs(car.Y - circle.Y);
        }
    }
}
