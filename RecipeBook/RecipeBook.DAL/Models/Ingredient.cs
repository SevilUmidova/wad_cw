using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.DAL.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        public string? Name { get; set; }
        public double Quantity { get; set; }
        public int RecipeId { get; set; }
    }
}
