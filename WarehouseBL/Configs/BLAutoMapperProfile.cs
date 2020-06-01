using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseBL.Models.Customer;
using WarehouseBL.Models.Employee;
using WarehouseBL.Models.Products;
using WarehouseBL.Models.Provider;
using WarehouseDAL.Entities;

namespace WarehouseBL.Configs
{
    public class BLAutoMapperProfile : Profile
    {
        public BLAutoMapperProfile()
        {
            CreateMap<CustomerBL, Customer>().ReverseMap();
            CreateMap<ProductShipmentBL, ProductShipment>().ReverseMap();
            CreateMap<ShipmentBL, Shipment>().ReverseMap();
            CreateMap<EmployeeBL, Employee>().ReverseMap();
            CreateMap<CountryBL, Country>().ReverseMap();
            CreateMap<ProductBL, Product>().ReverseMap();
            CreateMap<ProductGroupBL, ProductGroup>().ReverseMap();
            CreateMap<DeliveryBL, Delivery>().ReverseMap();
            CreateMap<ProviderBL, Provider>().ReverseMap();
            CreateMap<ProductDeliveryBL, ProductDelivery>().ReverseMap();

        }
    }
}
