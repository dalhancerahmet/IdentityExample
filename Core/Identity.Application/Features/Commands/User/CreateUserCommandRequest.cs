using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Application.Features.Commands.User
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string Email { get; set; }
    }
}
