using System.ComponentModel.DataAnnotations;
using Structures;
namespace Entities
{

    public class Question
    {
        [Key]
        public string QuestionId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Link { get; set; } = null!;
        public Status Status { get; set; }
    }
}
