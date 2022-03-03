namespace WeTalk.Data
{
    public class ChatRoomModel
    {
        public int Id { get; set; }
        public string? Room { get; set; }

        
        public ChatRoomModel(string? room)
        {
            Room = room;
        }
    }
   
}


