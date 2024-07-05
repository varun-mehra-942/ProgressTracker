namespace Entities
{
    public class Guild
    {
        public Guid GuildId { get; set; }
        public string GuildName { get; set; } = null!;
        public List<User>? Members { get; set; }
        public User LeaderId { get; set; } = null!;
    }
}
