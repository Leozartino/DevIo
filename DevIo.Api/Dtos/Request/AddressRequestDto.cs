using System.Text.Json.Serialization;

namespace DevIo.Api.Dtos.Request
{
    public class AddressRequestDto
    {

        [JsonIgnore] 
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
