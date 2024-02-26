﻿namespace DevIo.Business.Model
{
    public class Adress : BaseEntity
    {
        public Guid SupplierId { get; set; }

        public string Logradouro { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string PostalCode { get; set; }
        public string Neighbourhood { get; set; }
        public string Municipality { get; set; }
        public string AdministrativeArea { get; set; }
    }
}
