using System.ComponentModel.DataAnnotations;

namespace DevIo.Api.Dtos
{
    public class AddressDto
    {
        [Key]
        public Guid Id { get; set; } 
        public Guid SupplierId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string PostalCode { get; set; }
        public string Neighbourhood { get; set; }
        public string Municipality { get; set; }
        public string AdministrativeArea { get; set; }
    }
}