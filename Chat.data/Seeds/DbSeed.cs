using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        }

    }
}
