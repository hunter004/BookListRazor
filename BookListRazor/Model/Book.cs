using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        //key will create a unique ID value automatically
        [Key]
        public int Id { get; set; }

        //name cannot be null
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
