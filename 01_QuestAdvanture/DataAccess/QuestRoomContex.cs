namespace _01_QuestAdvanture.DataAccess
{
    using _01_QuestAdvanture.DataAccess.Initializer;
    using _01_QuestAdvanture.Models;
    using System;
    using System.Data.Entity;
    using System.Drawing;
    using System.Linq;

    public class QuestRoomContex : DbContext
    {
        public DbSet<QuestRoom> QuestRooms { get; set; }
        public DbSet<Images> Images { get; set; }
        public QuestRoomContex()
            : base("name=QuestRoomConnectionString")
        {
            Database.SetInitializer(new Custominitializer());
        }
    }
}