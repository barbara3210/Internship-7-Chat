using Chat.domain.Enums;
using Chat.presentation.Abstractions;
using System.Reflection.PortableExecutable;
using Chat.data.Entities.Models;
using Chat.domain.Repositories;
using Chat.presentation.Helpers;

namespace Chat.Presentation.Actions.Group;

public class ChatDeleteAction : IAction
{
    private readonly ChannelRepository _channelRepository;

    public int MenuIndex { get; set; }
    public string Name { get; set; } = "Delete chat";

    public ChatDeleteAction(ChannelRepository chatRepository)
    {
        _channelRepository = chatRepository;
    }

    public void Open()
    {
        var channels = _channelRepository.GetAll();
        //Input.Write(channels);

        Console.WriteLine("\nChat id you want to delete or exit");
        var isRead = Reader.TryReadNumber(out var channelId);
        if (!isRead)
        {
            Input.Error("Error: Not a number");
            return;
        }

        var responseResult = _channelRepository.Delete(channelId);

        switch (responseResult)
        {
            case ResponseResultType.Success:
                Console.WriteLine("Deleted successfully!");
                break;
            case ResponseResultType.NotFound:
                Console.WriteLine("Inputted id does not exist.");
                break;
            case ResponseResultType.NoChanges:
                Console.WriteLine("No changes applied");
                break;
            default:
                Console.WriteLine("Error occurred while updating group");
                break;
        }

        Console.ReadLine();
        Console.Clear();
    }
}