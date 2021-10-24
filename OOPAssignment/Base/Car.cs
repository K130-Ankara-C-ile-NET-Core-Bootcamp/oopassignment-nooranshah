using OOPAssignment.Base;
using OOPAssignment.IBase;
using OOPAssignment.Struct;
using System;

namespace OOPAssignment
{
    public class Car : ICarCommand, IBase.IObservable<CarInfo>
    {
        public Guid Id { get; set; }
        public Coordinates Coordinates;
        public Direction Direction;
        public ISurface Surface;
        private IBase.IObserver<CarInfo> Observer;
        public Car(Coordinates coordinates, Direction direction, ISurface surface)
        {
            Id = Guid.NewGuid();
            Coordinates = coordinates;
            Direction = direction;
            Surface = surface;
        }

        public void Attach(IBase.IObserver<CarInfo> observer)
        {
            Observer = observer;
            Notify();
        }

        public void Move()
        {
            switch (Direction)
            {
                case Direction.N:
                    Coordinates.Y++;
                    break;
                case Direction.E:
                    Coordinates.X++;
                    break;
                case Direction.W:
                    Coordinates.X--;
                    break;
                case Direction.S:
                    Coordinates.Y--;
                    break;
                default:
                    throw new Exception("Yanlış yoldasınız");
            }
            Notify();
        }

        public void Notify()
        {
            Observer.Update(new CarInfo(Id, Coordinates));
        }

        public void TurnLeft()
        {
            switch (Direction) {
                case Direction.N:
                    Direction = Direction.W;
                    break;
                case Direction.W:
                    Direction = Direction.S;
                    break;
                case Direction.S:
                    Direction = Direction.E;
                    break;
                case Direction.E:
                    Direction = Direction.N;
                    break;
                default:
                    throw new Exception();
            }
        }

        public void TurnRight()
        {
            switch (Direction) {

                case Direction.N:
                    Direction = Direction.E;
                    break;
                case Direction.E:
                    Direction = Direction.S;
                    break;
                case Direction.S:
                    Direction = Direction.W;
                    break;
                case Direction.W:
                    Direction = Direction.N;
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
