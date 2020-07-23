using _01_QuestAdvanture.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _01_QuestAdvanture.DataAccess.Initializer
{
    public class Custominitializer : DropCreateDatabaseAlways<QuestRoomContex>
    {
        protected override void Seed(QuestRoomContex context)
        {
            var questRooms = new List<QuestRoom>
            {
                new QuestRoom
                {
                    Name="FirstRoom",
                    Description = "Hear we are...",
                    Time = 2,
                    NumberPlayers =4,
                    MinAge = 18,
                    Address = "Rivne",
                    Phone = 89348389,
                    Company = "Be the best",
                    Price = 98,
                    LevelOfFear = 3,
                    LevelOfDifficulty = 2
                },
                new QuestRoom
                {
                    Name="SecondRoom",
                    Description = "Butter and Bread...",
                    Time = 2,
                    NumberPlayers = 4,
                    MinAge = 18,
                    Address = "Ostrig",
                    Phone = 89777379,
                    Company = "Be the best",
                    Price = 98,
                    LevelOfFear = 3,
                    LevelOfDifficulty = 2
                }
            };
            var images = new List<Images>
            {
                new Images{Path="https://i.playground.ru/p/vpSSq-useByoePbJAjtyNg.jpeg", QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="FirstRoom") },
                new Images{Path="https://gamenewsblog.ru/wp-content/uploads/06.11.2019_CatQuest2-728x409.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="FirstRoom") },
                new Images{Path="https://images.androeed.ru/screenshotes/2020/06/15/angelo-and-deemon-one-hell-of-a-quest-706710.png",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="FirstRoom") },
                new Images{Path="https://i.ytimg.com/vi/oBDYD49kh3I/maxresdefault.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="FirstRoom")},
                new Images{Path="https://img.grouponcdn.com/deal/eXBkJK5WrdhmYfnqv8VL/4t-1000x600/v1/c700x420.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="FirstRoom")},
                new Images{Path="https://f.kyivmaps.com/location/3195/VXRwS.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="SecondRoom")},
                new Images{Path="https://f.kyivmaps.com/location/3204/VDvzc.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="SecondRoom")},
                new Images{Path="https://f.kyivmaps.com/location/3207/mGevK.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="SecondRoom")},
                new Images{Path="https://f.kyivmaps.com/location/3224/3rsR9.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="SecondRoom")},
                new Images{Path="https://questroom.com.ua/dist/pict_rooms/6td9kL4F.jpg",QuestRoom=questRooms.FirstOrDefault(z=>z.Name=="SecondRoom")}
            };
            context.Images.AddRange(images);
            context.QuestRooms.AddRange(questRooms);

            context.SaveChanges();

            base.Seed(context);
        }
    }
}