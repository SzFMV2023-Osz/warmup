namespace AutomatedCar.SystemComponents
{
    using AutomatedCar.Models;
    using AutomatedCar.SystemComponents.Packets;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class DummySensor : SystemComponent
    {
        DummyPacket dummyPacket;

        public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
        {
            this.dummyPacket = new DummyPacket();
            virtualFunctionBus.DummyPacket = this.dummyPacket;
        }

        public override void Process()
        {
            var circle = World.Instance.WorldObjects
                        .Where(x => x.GetType() == typeof(Circle)).FirstOrDefault();

            var automatedCar = World.Instance.ControlledCar;

            if (circle != null && automatedCar != null)
            {
                this.dummyPacket.DistanceX = Math.Abs(circle.X - automatedCar.X);
                this.dummyPacket.DistanceY = Math.Abs(circle.Y - automatedCar.Y);
            }
        }
    }
}
