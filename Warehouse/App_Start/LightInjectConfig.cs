using AutoMapper;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using WarehouseBL.Configs;
using WarehouseBL.Interfaces;
using WarehouseBL.Services;

namespace Warehouse.App_Start
{
    public static class LightInjectConfig
    {
        public static void Configurate()
        {
            var container = new ServiceContainer();
            container.RegisterControllers(Assembly.GetExecutingAssembly());

            container.EnablePerWebRequestScope();

            var config = new MapperConfiguration(cfg => cfg.AddProfiles(
                  new List<Profile>() { new WebAutoMapperProfile(), new BLAutoMapperProfile() }));

            container.Register(c => config.CreateMapper());

            container = BLLightInjectConfig.Configuration(container);

            container.Register<ICountryService, CountryService>();
            container.Register<ICustomerService, CustomerService>();
            container.Register<IDeliveryService, DeliveryService>();
            container.Register<IEmployeeService, EmployeeService>();
            container.Register<IProductDeliveryService, ProductDeliveryService>();
            container.Register<IProductGroupService, ProductGroupService>();
            container.Register<IProductService, ProductService>();
            container.Register<IProductShipmentService, ProductShipmentService>();
            container.Register<IProviderService, ProviderService>();
            container.Register<IShipmentService, ShipmentService>();

            container.EnableMvc();
        }
    }
}