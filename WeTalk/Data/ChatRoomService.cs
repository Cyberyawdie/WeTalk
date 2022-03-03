namespace WeTalk.Data
{
    public class ChatRoomService
    {
       
        public static void GetChatRoom(ChatRoomDbContext db, ChatRoomModel chatRoom)
        {
            

            db.ChatRooms.Add(chatRoom);
            db.SaveChanges();
            
        }
    }
}
