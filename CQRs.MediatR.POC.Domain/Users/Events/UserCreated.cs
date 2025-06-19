using MediatR;

namespace CQRs.MediatR.POC.Domain.Users.Events
{
    public class UserCreated : INotification
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = string.Empty;



        public class UserCreatedHandler : INotificationHandler<UserCreated>
        {
            readonly IMediator Mediator;

            public UserCreatedHandler(IMediator mediator)
                => Mediator = mediator;

            public async Task Handle(UserCreated user, CancellationToken cancellationToken)
            {
                // Logic to handle the user created event, e.g., logging, sending notifications, etc.
            }
        }
    }
}
