using AccProdEnterprise.Entities;

namespace AccProdEnterprise.Services
{
    public interface IPositionService
    {
        public void AddPosition(Position newPosition);
        public void DeletePostition(string newPositionName);
        public void UpdatePosition(string newPositionName, Position newPosition);
        public Position GetPosition(string newPositionName);
        public List<Position> GetAllPositions();
    }
}
