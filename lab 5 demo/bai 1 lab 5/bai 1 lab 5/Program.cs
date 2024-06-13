using bai_1_lab_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_lab_5
{
    class UserAccountLab5
    {
        public string name;
        public int rank;
        public float winRate;
        public string type;
        public int skin;

        public UserAccountLab5(string name, int rank, float winRate, string type, int skin)
        {
            this.name = name;
            this.rank = rank;
            this.winRate = winRate;
            this.type = type;
            this.skin = skin;
        }
    }
}

class Program
{
    static void Main()
    {
        List<UserAccountLab5> List = new List<UserAccountLab5>
        {
            new UserAccountLab5("Sơn Tùng", 10, 55.5f, "Ca Nhạc", 50),
            new UserAccountLab5("Đen Vâu", 5, 70, "Ca Nhạc", 10),
            new UserAccountLab5("Thúy Linh", 15, 45.5f, "Ca Nhạc", 25),
            new UserAccountLab5("Độ Mixi", 1, 90, "ALL", 2),
            new UserAccountLab5("bà Tuyết Diamond", 3, 60.5f, "Ẩm thực", 10),
            new UserAccountLab5("PewPew", 4, 55.5f, "live", 50),
            new UserAccountLab5("Liên Minh", 2, 85.5f, "Game", 255),
            new UserAccountLab5("Liên Quân", 11, 55.5f, "Game", 200),
            new UserAccountLab5("Fifa 4", 7, 55.5f, "Game", 150),
            new UserAccountLab5("CSO", 8, 55.5f, "Game", 1000),
            new UserAccountLab5("CSGO", 6, 85.5f, "Game", 500)
        };
        var gameUsers = List.Where(user => user.type == "Game").ToList();
        Console.WriteLine("Users with type 'Game':");

        foreach (var user in gameUsers)
        {
            Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, WinRate: {user.winRate}, Skins: {user.skin}");
        } 

        var sortedByRank = List.OrderBy(user => user.rank).ToList();
        Console.WriteLine("\nUsers sorted by rank:");

        foreach (var user in sortedByRank)
        {
            Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, WinRate: {user.winRate}, Skins: {user.skin}");
        }

        string searchName = "Độ Mixi";

        var specificUser = List.FirstOrDefault(user => user.name == searchName);

        if (specificUser != null)
        {
            Console.WriteLine($"\nFound user {searchName}: Rank: {specificUser.rank}, WinRate: {specificUser.winRate}, Type: {specificUser.type}, Skins: {specificUser.skin}");
        }
        else
        {
            Console.WriteLine($"\nUser {searchName} not found.");
        }
    }

} 
