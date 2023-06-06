using AccProdEnterprise.Data;
using AccProdEnterprise.Entities;

namespace AccProdEnterprise.Services
{
    public class PositionService : IPositionService
    {
        public ApplicationDbContext _context;

        public PositionService(ApplicationDbContext context)
        {
            _context = context; 
        }
        public void AddPosition(Position newPosition)
        {
            _context.Positions.Add(newPosition);
            _context.SaveChanges();
        }

        public void DeletePostition(string newPositionName)
        {
            var position = _context.Positions
               .Where(position => position.NamePost == newPositionName)
               .FirstOrDefault();
            position.IsDeleted = true;
            _context.SaveChanges();
        }

        public List<Position> GetAllPositions()
        {
            return _context.Positions
                .Where(p => p.IsDeleted == false)
                .ToList();
        }


        public Position GetPosition(string newPositionName)
        {
            throw new NotImplementedException();
        }

        public void UpdatePosition(string newPositionName, Position newPosition)
        {
            var updatePosition= _context.Positions
                .Where(position=> position.NamePost == newPositionName)
                .FirstOrDefault();
            updatePosition = newPosition;
            _context.SaveChanges();
        }
    }
}
