using Identity.Domain;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Identity.Application.Features.Commands.User
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        UserManager<AppUser> _userManager;

        public CreateUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        async Task<CreateUserCommandResponse> IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>.Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            IdentityResult result= await _userManager.CreateAsync(new()
            {
                Email = request.Email,
            });
            return new()
            {
                Succeded = result.Succeeded,
                Message = "Hata!!"
            };
        }
    }
}