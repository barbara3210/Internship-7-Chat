using Chat.domain.Enums;
using Chat.domain.Repositories;
using Chat.presentation.Abstractions;
using Chat.presentation.Helpers;

namespace Chat.presentation.Actions.User;

public class UserAddAction : IAction
{
    private readonly UserRepository _userRepository;

    public int MenuIndex { get; set; }
    public string Name { get; set; } = "Add user";

    public UserAddAction(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public void Open()
    {
        Reader.ReadInput("Email", out var email);
        Reader.ReadInput("Password", out var pass);
        var user = new Chat.data.Entities.Models.User(email,pass);

        var responseResult = _userRepository.Add(user);
        if (responseResult is ResponseResultType.Success)
        {
           
            Console.ReadLine();

            return;
        }

        Console.WriteLine("Failed to add user, no changes saved!");
        Console.ReadLine();
    }
}
