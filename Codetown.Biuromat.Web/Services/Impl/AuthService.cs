using Codetown.Biuromat.Web.Data;

namespace Codetown.Biuromat.Web.Services.Impl
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _dbContext;
        
        public AuthService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        
    }
}