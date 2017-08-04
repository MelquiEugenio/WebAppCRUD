using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string País { get; set; }
    }
}