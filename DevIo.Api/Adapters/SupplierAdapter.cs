﻿using DevIo.Api.Dtos.Request;
using DevIo.Business.Interfaces;
using DevIo.Business.Model;

namespace DevIo.Api.Adapters
{
    public class SupplierAdapter : IAdapter<SupplierRequestDto, Supplier>
    {
        private readonly Supplier _supplier = new();

        public Supplier ConvertToDestinationObject(SupplierRequestDto source)
        {

            _supplier.Name = source.Name;
            _supplier.Document = source.Document;
            _supplier.IsActive = source.IsActive;
            _supplier.SupplierType = source.SupplierType;
            _supplier.Address = ConvertToDestinationObject(source.Address);
            
            return _supplier;

        }

        private Address ConvertToDestinationObject(AddressRequestDto source)
        {
            return new Address
            {
                Street = source.Street,
                SupplierId = _supplier.Id,
                PostalCode = source.PostalCode,
                Number = source.Number,
                Neighbourhood = source.Neighbourhood,
                Municipality = source.Municipality,
                AdministrativeArea = source.AdministrativeArea,
                Complement = source.Complement            
            };
        }
    }
}
