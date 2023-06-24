using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebTour.Models.EF
{
    [Table("tb_Category")]
    public class Category : CommonAbs
    {
        //new và category liên kết với nhau qua categoryid

        public Category() {
            this.News = new HashSet<New>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "không được để trống!")]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public int Position { get; set; } 

        public ICollection<New> News { get; set; }
    }
}