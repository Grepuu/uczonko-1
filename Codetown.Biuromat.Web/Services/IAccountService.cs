namespace Codetown.Biuromat.Web.Services
{
    public interface IAccountService
    {
        public void ChangePassword(string oldpassword, string newpassword, string newpasswordconfirm);
    }
}