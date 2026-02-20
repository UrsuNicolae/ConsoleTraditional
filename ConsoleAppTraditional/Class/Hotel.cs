namespace ConsoleAppTraditional.Class
{
    public class Hotel
    {
        private List<Room> rooms = new List<Room>();
        public static decimal TotalIncome;
        static Hotel()
        {
            TotalIncome = 0;
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void RemoveRoom(Room room)
        {
            rooms.Remove(room);
        }

        public Room FindRoomByType(RoomType type)
        {
            return rooms.FirstOrDefault(r => r.Type == type);
        }         

        public void ListAvailableRooms()
        {
            foreach(var room in rooms.Where(r => !r.IsOccupied))
            {
                Console.WriteLine(room);
            }
        }

        public void ReserveRoom(int nr)
        {
            var room = rooms.FirstOrDefault(room => room.RoomNumber == nr);
            if(room == null || room.IsOccupied)
            {
                Console.WriteLine("Room is occupied!");
            }else
            {
                room.CheckIn();
                TotalIncome += room.Price;
            }
        }

        public void EmptyRoom(int nr)
        {
            var room = rooms.FirstOrDefault(room => room.RoomNumber == nr);
            if (room == null || !room.IsOccupied)
            {
                Console.WriteLine("Room is not occupied!");
            }
            else
            {
                room.CheckOut();
            }
        }
    }
    public enum RoomType
    {
        Single,
        Double
    }
    public class Room
    {
        public int RoomNumber { get; set; }
        public RoomType Type { get; set; }
        public decimal Price { get; set; }
        public bool IsOccupied { get; set; }

        public void CheckIn()
        {
            IsOccupied = true; 
        } 
        public void CheckOut()
        {
            IsOccupied = false;
        }

        public override string ToString()
        {
            return $"Room:{RoomNumber} of type: {Type} has: {Price} is occupied: {IsOccupied}";
        }
    }
}
