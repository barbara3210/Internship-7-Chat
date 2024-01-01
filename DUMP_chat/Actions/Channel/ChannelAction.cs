using Chat.presentation.Abstractions;


namespace Chat.presentation.Actions.Channel
{
    public class ChannelAction:BaseMenuAction
    {

        public ChannelAction(IList<IAction> actions) : base(actions)
        {
            Name = "Channel menu";
        }


    }
}
