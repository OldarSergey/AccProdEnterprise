using AccProdEnterprise.Data;
using AccProdEnterprise.Entities;

namespace AccProdEnterprise
{
    public static class SeedData
    {
        public static async Task EnsureSeedData(IServiceProvider provider)
        {
            var dbContext = provider.GetRequiredService<ApplicationDbContext>();


            // Проверяем, существуют ли уже должности в базе данных
            
            if (!dbContext.Positions.Any())
            {
                var positions = new[]
                {
                    new Position
                    {
                        NamePost = "Программист",
                        Descripton = "Frontend developer",
                        Salary = 50000.0m,
                        EducationRequirement = "Низшее образование",
                        DateOfCreate = DateTime.Now,
                        LastUpdateDate = DateTime.Now,
                        DateOfDelete = DateTime.Now,    
                    },
                    new Position
                    {
                        NamePost = "Старший программист",
                        Descripton = "Backend developer",
                        Salary = 100000.0m,
                        EducationRequirement = "Высшее образование",
                        DateOfCreate = DateTime.Now,
                        LastUpdateDate = DateTime.Now,
                        DateOfDelete = DateTime.Now,
                    }
                };

                await dbContext.Positions.AddRangeAsync(positions);
                 await dbContext.SaveChangesAsync();
            }
        }
    }
}
