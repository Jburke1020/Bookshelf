using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]           //this is the data annotation and need to add the using.Statement above (only one Key per record)
        public int ID { get; set; } //unique identification for a database
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }   

        [ForeignKey("Category")]  //Primary key in another table this is the format.  This is the data annotation and the using.Statement above with "Schema" is used
        public int CategoryID {get; set;}
        public virtual Category Category { get; set; }

    }

    
}