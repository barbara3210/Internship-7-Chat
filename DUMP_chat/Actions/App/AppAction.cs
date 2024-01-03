using Chat.presentation.Abstractions;


namespace Chat.presentation.Actions.App
{
    public class AppAction : BaseMenuAction
    {
        public AppAction(IList<IAction> actions) : base(actions)
        {
            Name = "App menu";
        }

    }
}
