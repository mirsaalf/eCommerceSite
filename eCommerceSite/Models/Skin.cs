using System.ComponentModel.DataAnnotations;

namespace eCommerceSite.Models
{
    /// <summary>
    /// Represents a single skin care product available for purchase
    /// </summary>
    public class Skin
    {
        /// <summary>
        /// The unique identifier for each skin care product 
        /// </summary>
        [Key]
        public int SkinID { get; set; }

        /// <summary>
        /// Name + Brand of the skin care product 
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// The sales price of the skin care product 
        /// </summary>
        [Range(0, 1000)]
        public double Price { get; set; } 

        // ToDo: Add rating
    }
}
