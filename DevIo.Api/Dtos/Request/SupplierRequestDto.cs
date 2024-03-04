﻿using DevIo.Business.Model;

namespace DevIo.Api.Dtos.Request
{
    public class SupplierRequestDto
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public SupplierType SupplierType { get; set; }
        public bool IsActive { get; set; }
        public AddressRequestDto Address { get; set; }
    }
}
