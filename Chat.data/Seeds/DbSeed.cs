using Microsoft.EntityFrameworkCore;
using Chat.data.Entities.Models;
using System.Text.RegularExpressions;

namespace Chat.data.Seeds
{
    public class DbSeed
    {

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new List<User>
                {
                new User("Andrea", "Anic","andrea@gmail.com", "anaanic45")
                {
                    Id = 1,
                },
                new User("Ante", "Roca","ante@gmail.com", "rock45")
                {
                    Id = 2,
                },
                new User("Bartol", "Deak","bartol@yahoo.com", "dbar78")
                {
                    Id = 3,
                },
                new User("Duje", "Saric","duje@gmail.com", "sarduje23")
                {
                    Id = 4,
                },
                new User("Damjana", "Baric","damjana@gmail.com", "damn45")
                {
                    Id = 5,
                },
                new User("Frane", "Doljanin","frane@yahoo.com", "dolje7")
                {
                    Id = 6,
                },
                new User("Igor", "Ticinovic","igorT@gmail.com", "tigor52")
                {
                    Id = 7,
                },
                new User("Ivo", "Jovanovic","ivoJ@yahoo.com", "iviv56")
                {
                    Id = 8,
                },
                new User("Jan", "Modun","MJan@yahoo.com", "ijan89")
                {
                    Id = 9,
                },
                new User("Lovre", "Tomic","LTomic@gmail.com", "lovrinjo25")
                {
                    Id = 10,
                },
                new User("Lucija", "Fradelic","luce@yahoo.com", "luce23")
                {
                    Id = 11,
                },
                new User("Lucas", "Sardelic","lucas@gmail.com", "skusa")
                {
                    Id = 12,
                },
                new User("Lucija", "Jurkovic","lucijas@gmail.com", "lucijas")
                {
                    Id = 13,
                },
                new User("Luka", "Brcic","lukab@yahoo.com", "brko")
                {
                    Id = 14,
                },
                new User("Luka", "Smiljic","lukasm@gmail.com", "smajlic")
                {
                    Id = 15,
                },
                new User("Mario", "Mitov","mitov@gmail.com", "mitovvm")
                {
                    Id = 16,
                },
                new User("Matea", "Vucemilovic","matea@gmail.com", "mateaVU")
                {
                    Id = 17,
                },
                new User("Nikolina", "Maglica","niki@gmail.com", "magla")
                {
                    Id = 18,
                },
                new User("Roko", "Perisic","roko@gmail.com", "PEROko")
                {
                    Id = 19,
                },
                new User("Sime", "Jadrijev","sime@gmail.com", "jaSime")
                {
                    Id = 20,
                },
                new User("Tin", "Juric","tiin@gmail.com", "ententini")
                {
                    Id = 21,
                },
                new User("Toni", "Grbic","tonig@gmail.com","tonig")
                {
                    Id = 22,
                },
                new User("Zoran", "Pujic","zoran@gmail.com","zora123")
                {
                    Id = 23,
                },
                });

            DateTime dateTime = DateTime.Now;

            builder.Entity<Message>()
            .HasData(new List<Message>
            {
                new Message(1,2,"Pozdrav",dateTime.AddDays(-2))
                {
                    Id = 1,
                },
                new Message(2,1,"Bok",dateTime.AddDays(-8))
                {
                    Id = 2,
                },
                new Message(9,2,"Hej",dateTime.AddDays(-5))
                {
                    Id = 3,
                },
                new Message(1,9,"Bok",dateTime.AddDays(-3))
                {
                    Id = 4,
                },
                new Message(1,9,"Pozdrav",dateTime.AddDays(-5))
                {
                    Id = 5,
                },
                new Message(8,1,"Bok",dateTime.AddDays(-2))
                {
                    Id = 6,
                },
                new Message(8,2,"Hej",dateTime.AddDays(-1))
                {
                    Id = 7,
                },
                new Message(5,9,"Bok",dateTime.AddDays(-8))
                {
                    Id = 8,
                },
                new Message(4,6,"Pozdrav",dateTime.AddDays(-6))
                {
                    Id = 9,
                },
                new Message(8,2,"Bok",dateTime.AddDays(-5))
                {
                    Id = 10,
                },
                new Message(9,5,"Hej",dateTime.AddDays(-6))
                {
                    Id = 11,
                },
                new Message(3,4,"Bok",dateTime.AddDays(-5))
                {
                    Id = 12,
                },
                new Message(10,18,"Pozdrav",dateTime.AddDays(-1))
                {
                    Id = 13,
                },
                new Message(8,11,"Bok",dateTime.AddDays(-2))
                {
                    Id = 14,
                },
                new Message(20,2,"Hej",dateTime.AddDays(-5))
                {
                    Id = 15,
                },
                new Message(2,20,"Bok",dateTime.AddDays(-2))
                {
                    Id = 16,
                },

            });

            builder.Entity<ChatChannel>()
            .HasData(new List<ChatChannel>
            {
                new ChatChannel("dev",3)
                {
                    Id = 1,
                },
                new ChatChannel("design", 2)
                {
                    Id = 2,
                },
                new ChatChannel("random",8)
                {
                    Id = 3,
                },
                new ChatChannel("marketing", 2)
                {
                    Id = 4,
                },
                new ChatChannel("multimedia", 9)
                {
                    Id = 5,
                },
                new ChatChannel("general",10)
                {
                    Id = 6,
                },
            });

            builder.Entity<ChannelMember>()
            .HasData(new List<ChannelMember>
            {
                new ChannelMember(1,1),
                new ChannelMember(1,2),
                new ChannelMember(1,3),
                new ChannelMember(1,4),
                new ChannelMember(1,5),
                new ChannelMember(1,6),
                new ChannelMember(1,7),
                new ChannelMember(1,8),
                new ChannelMember(1,9),
                new ChannelMember(1,10),

                new ChannelMember(2,11),
                new ChannelMember(2,12),
                new ChannelMember(2,13),
                new ChannelMember(2,14),
                new ChannelMember(2,15),
                new ChannelMember(2,16),
                new ChannelMember(2,17),
                new ChannelMember(2,18),
                new ChannelMember(2,19),
                new ChannelMember(2,20),

                new ChannelMember(3,1),
                new ChannelMember(3,2),
                new ChannelMember(3,3),
                new ChannelMember(3,4),
                new ChannelMember(3,5),
                new ChannelMember(3,6),
                new ChannelMember(3,7),
                new ChannelMember(3,8),
                new ChannelMember(3,9),
                new ChannelMember(3,10),
                new ChannelMember(3,11),
                new ChannelMember(3,12),
                new ChannelMember(3,13),
                new ChannelMember(3,14),
                new ChannelMember(3,15),
                new ChannelMember(3,16),
                new ChannelMember(3,17),
                new ChannelMember(3,18),
                new ChannelMember(3,19),
                new ChannelMember(3,20),

                new ChannelMember(4,11),
                new ChannelMember(4,15),
                new ChannelMember(4,16),
                new ChannelMember(4,19),
                new ChannelMember(4,20),
                new ChannelMember(4,21),
                new ChannelMember(4,22),
                new ChannelMember(4,23),

                new ChannelMember(5,1),
                new ChannelMember(5,5),
                new ChannelMember(5,6),
                new ChannelMember(5,9),
                new ChannelMember(5,20),
                new ChannelMember(5,21),
                new ChannelMember(5,22),
                new ChannelMember(5,23),

                new ChannelMember(6, 1),
                new ChannelMember(6, 2),
                new ChannelMember(6, 3),
                new ChannelMember(6, 4),
                new ChannelMember(6, 5),
                new ChannelMember(6, 6),
                new ChannelMember(6, 7),
                new ChannelMember(6, 8),
                new ChannelMember(6, 9),
                new ChannelMember(6, 10),
                new ChannelMember(6, 11),
                new ChannelMember(6, 12),
                new ChannelMember(6, 13),
                new ChannelMember(6, 14),
                new ChannelMember(6, 15),
                new ChannelMember(6, 16),
                new ChannelMember(6, 17),
                new ChannelMember(6, 18),
                new ChannelMember(6, 19),
                new ChannelMember(6, 20),
                new ChannelMember(6, 21),
                new ChannelMember(6, 22),
                new ChannelMember(6, 23),

            });


        }

    }
}
