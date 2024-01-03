using Chat.domain.Factories;
using Chat.domain.Repositories;
using Chat.presentation.Abstractions;
using Chat.presentation.Actions.User;
using Chat.presentation.Actions;


namespace Chat.presentation.Factories;

public class UserActionsFactory
{
    public static UserAction Create()
    {
        var actions = new List<IAction>
        {
            new UserAddAction(RepositoryFactory.Create<UserRepository>()),
            new UserEditAction(RepositoryFactory.Create<UserRepository>()),
            new UserDeleteAction(RepositoryFactory.Create<UserRepository>()),
            new ExitMenuAction()
        };

        var menuAction = new UserAction(actions);
        return menuAction;
    }
}
