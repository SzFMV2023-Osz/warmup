using AutomatedCar.Models;
using AutomatedCar.SystemComponents;
using AutomatedCar.SystemComponents.Packets;
using JetBrains.Annotations;
using System;

public class DummySensor : SystemComponent
{
    DummyPacket DummyPacket { get; set; }

    public DummySensor(VirtualFunctionBus virtualFunctionBus) : base(virtualFunctionBus)
    {
        virtualFunctionBus.RegisterComponent(this);
        DummyPacket = new DummyPacket();
    }

    public override void Process()
    {
        var circleX = World.Instance.WorldObjects[0].X;
        var circleY = World.Instance.WorldObjects[0].Y;
        var carX = World.Instance.controlledCars[0].X;
        var carY = World.Instance.controlledCars[0].Y;
        DummyPacket.DistanceX = carX - circleX;
        DummyPacket.DistanceY = carY - circleY;
    }
}
