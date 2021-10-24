using OOPAssignment.Struct;

namespace OOPAssignment.IBase
{
    public interface ISurface
    {
       /*private readonly long _width;
        private readonly long _height;*/

        bool IsCoordinatesInBounds(Coordinates coordinates);
    }
}
