using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Warehouse.Models.Customer;
using Warehouse.Models.Employee;
using Warehouse.Models.Products;
using Warehouse.Models.Provider;
using WarehouseBL.Models.Customer;
using WarehouseBL.Models.Employee;
using WarehouseBL.Models.Products;
using WarehouseBL.Models.Provider;

namespace Warehouse.App_Start
{
    public class WebAutoMapperProfile : Profile
    {
        public WebAutoMapperProfile()
        {
            CreateMap<ProviderRegisterModel, ProviderBL>().ReverseMap();
            CreateMap<EmployeeRegisterModel, EmployeeBL>().ReverseMap();
            CreateMap<CustomerRegisterModel, CustomerBL>().ReverseMap();
            CreateMap<CustomerViewModel, CustomerBL>().ReverseMap();
            CreateMap<ProductShipmentViewModel, ProductShipmentBL>().ReverseMap();
            CreateMap<ShipmentViewModel, ShipmentBL>().ReverseMap();
            CreateMap<EmployeeViewModel, EmployeeBL>().ReverseMap();
            CreateMap<CountryViewModel, CountryBL>().ReverseMap();
            CreateMap<ProductViewModel, ProductBL>().ReverseMap();
            CreateMap<ProductGroupViewModel, ProductGroupBL>().ReverseMap();
            CreateMap<DeliveryViewModel, DeliveryBL>().ReverseMap();
            CreateMap<ProviderViewModel, ProviderBL>().ReverseMap();
            CreateMap<ProductDeliveryViewModel, ProductDeliveryBL>().ReverseMap();
        }

    }
}