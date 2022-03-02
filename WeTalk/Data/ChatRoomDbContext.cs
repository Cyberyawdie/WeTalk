using Microsoft.EntityFrameworkCore;

namespace WeTalk.Data
{
    public class ChatRoomDbContext : DbContext
    {
        public  ChatRoomDbContext(DbContextOptions<ChatRoomDbContext> options) : base(options) { }
        public DbSet<ChatRoomModel> ChatRooms => Set<ChatRoomModel>();
    }
}
