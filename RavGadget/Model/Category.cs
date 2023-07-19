using System.ComponentModel.DataAnnotations;

namespace RavGadget.Model
{
    public class Category   //Shortcut: prop tab
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
