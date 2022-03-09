using System.ComponentModel.DataAnnotations;

namespace aspnet_notebook.Models
{
    public class NotebookItem
    {
        [Key]
        public Guid ItemId { get; set; }
        public bool IsRead { get; set; } = false;

        [Required]
        public string Title { get; set; }
        public string? Text { get; set; }
        public DateTimeOffset? Created { get; set; } = DateTimeOffset.Now;
    }
}
