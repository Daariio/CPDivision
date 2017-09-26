using CPDivision.Services.Users.Models;

namespace CPDivision.Services.Users.Repositories
{
    public interface IRTokenRepository
    {
        bool AddToken(RToken token);

        bool ExpireToken(RToken token);

        RToken GetToken(string refresh_token,string client_id);
    }
}
