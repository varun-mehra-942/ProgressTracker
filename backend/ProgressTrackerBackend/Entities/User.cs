namespace Entities
{
    public class User
    {
        public string UserId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Guid GuildId { get; set; }
        public int QS { get; set; } = 0;
    }

}
