namespace APIRest_WebForm.Services.UsuarioServices
{
    public interface IUserService
    {
        Task<string> Login(string user, string pass);
    }
}
