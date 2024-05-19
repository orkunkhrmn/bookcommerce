using MediatR;
using Microsoft.AspNetCore.Identity;

public class RegisterUserCommand : IRequest<IdentityResult>
{
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}