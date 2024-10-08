﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.DAL
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
