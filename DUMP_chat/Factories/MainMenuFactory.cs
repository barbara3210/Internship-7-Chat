using Chat.presentation.Abstractions;
using Chat.presentation.Actions;
using Chat.presentation.Extensions;

namespace Chat.presentation.Factories
{
    public class MainMenuFactory
    {

        public static IList<IAction> CreateActions()
        {
            var actions = new List<IAction>
        {
            UserActionsFactory.Create(),
            
            new ExitMenuAction(),
        };

            actions.SetActionIndexes();

            return actions;
        }
    }
}
