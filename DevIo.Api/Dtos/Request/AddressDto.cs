namespace DevIo.Api.Dtos.Request
{
    public class AddressDto
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; } = string.Empty;
        public string PostalCode { get; set; }
        public string Neighbourhood { get; set; }
        public string Municipality { get; set; }
        public string AdministrativeArea { get; set; }

    }
}
