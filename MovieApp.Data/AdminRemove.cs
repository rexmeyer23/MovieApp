using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class AdminRemove
    {
        [Key]
        public int RemoveId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public Guid ProfileId { get; set; }
     
        //[ForeignKey(nameof(Profile))]
       // public int ProfileId { get; set; }
        //public virtual Film Film {get; set;}
    }
}
