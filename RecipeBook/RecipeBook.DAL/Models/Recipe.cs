using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.DAL.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string? Name { get; set; }

        [MinLength(2)]
        [MaxLength(5000)]
        public string? Description { get; set; }
        public ICollection<Ingredient>? Ingredients { get; set; }
    }
}
