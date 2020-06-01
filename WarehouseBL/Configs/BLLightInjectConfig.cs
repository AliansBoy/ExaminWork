using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseDAL.Interfaces;
using WarehouseDAL.Repositories;

namespace WarehouseBL.Configs
{
    public class BLLightInjectConfig
    {
        public static ServiceContainer Configuration(ServiceContainer container)
        {
            container.Register(typeof(IGenericRepository<>), typeof(GenericRepositiory<>));

            return container;
        }
    }
}
