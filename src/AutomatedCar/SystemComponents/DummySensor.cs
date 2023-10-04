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
        public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
        {
        }

        public override void Process()
        {
            var circle = World.Instance.WorldObjects.First(x => x is Circle);
            var autoCar = World.Instance.ControlledCar;
            (this.virtualFunctionBus.DummyPacket as DummyPacket).DistanceX = circle.X - autoCar.X;
            (this.virtualFunctionBus.DummyPacket as DummyPacket).DistanceY = circle.Y - autoCar.Y;
        }
    }
}
