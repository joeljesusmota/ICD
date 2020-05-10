using System;
using System.ComponentModel.DataAnnotations;

namespace Ventas.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public string client { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public decimal totalAmount { get; set; }
    }
}