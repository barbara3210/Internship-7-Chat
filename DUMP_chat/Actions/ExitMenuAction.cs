using Chat.presentation.Abstractions;


namespace Chat.presentation.Actions
{
    public class ExitMenuAction : IAction
    {
        public int MenuIndex { get; set; }
        public string Name { get; set; } = "Exit";

        public ExitMenuAction()
        {
        }
        public void Open()
        {
        }
    }

}
