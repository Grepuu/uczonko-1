using Codetown.Biuromat.Web.Data;

namespace Codetown.Biuromat.Web.Services.Impl
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _dbContext;
        
        public AccountService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void ChangePassword(string oldpassword, string newpassword, string newpasswordconfirm)
        {
            throw new System.NotImplementedException();
        }
    }
}