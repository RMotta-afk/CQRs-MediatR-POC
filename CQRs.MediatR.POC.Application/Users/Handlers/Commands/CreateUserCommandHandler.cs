using MediatR;
using CQRs.MediatR.POC.Domain.Users.Events;
using CQRs.MediatR.POC.Domain.Users.Repositories;
using CQRs.MediatR.POC.Application.Users.Commands;

namespace CQRs.MediatR.POC.Application.Users.Handlers.Commands
{
    internal class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMediator _mediator;

        public CreateUserCommandHandler(IUsersRepository usersRepository, IMediator mediator)
        {
            _usersRepository = usersRepository;
            _mediator = mediator;
        }
        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // Logic to create a user and return the user ID

            var user = await _usersRepository.CreateUserAsync(request.UserName, request.Email);

            // For now, returning a dummy user ID
            // Publish the UserCreated event if needed
            await _mediator.Publish(new UserCreated { UserId = user.Id, UserName = user.Name }, cancellationToken);

            return await Task.FromResult(new Random().Next(1, 1000));
        }
    }
}
