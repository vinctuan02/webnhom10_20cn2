using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebTour.Models.EF
{
    [Table("tb_New1")]
    public class New : CommonAbs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public int Categoryid { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }

        public virtual Category Category { get; set; }
    }
}