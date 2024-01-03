using Chat.domain.Repositories;
using Chat.presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.presentation.Actions.Channel
{
    public class ChannelAddAction:IAction
    {
        private readonly ChannelRepository _channelRepository;

        public int MenuIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Open()
        {
            throw new NotImplementedException();
        }
    }
}
