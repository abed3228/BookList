using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book
    {
        public int Id { get; set; }

        //השם לא יכול להיות ריק 
        [Required]
        public string Name { get; set; }
    }
}
