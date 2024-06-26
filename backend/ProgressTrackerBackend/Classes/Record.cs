using System.ComponentModel.DataAnnotations;
using Structures;

public class Record
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Link { get; set; } = null!;
    public Status Status { get; set; }
}
