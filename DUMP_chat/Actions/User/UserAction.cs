using Chat.presentation.Abstractions;
using System.Xml.Linq;

namespace Chat.presentation.Actions.User
{
    public class UserAction : BaseMenuAction
    {
        public UserAction(IList<IAction> actions) : base(actions)
        {
            Name = "User menu";
        }

        public override void Open()
        {
            Console.WriteLine("Users management");
            base.Open();
        }
    }

}


