using System.ComponentModel.DataAnnotations;

namespace EventEaseAppOwethuHadebeMVC.Models
{
    public class EventType
    {
        public int EventTypeID { get; set; }

        [Required]

        public string? Name { get; set; }
    }
}
