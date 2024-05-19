using MediatR;
using Microsoft.AspNetCore.Identity;

public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, IdentityResult>
{

    private readonly UserManager<ApplicationUser> _userManager;

    public RegisterUserCommandHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IdentityResult> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
    {
        var user = new ApplicationUser { UserName = request.UserName, Email = request.Email };
        return await _userManager.CreateAsync(user, request.Password);
    }
}
