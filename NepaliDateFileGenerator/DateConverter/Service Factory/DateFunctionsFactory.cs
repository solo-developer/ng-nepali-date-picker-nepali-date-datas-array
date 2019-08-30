using DateConverter.Core.Library;
using DateConverter.Core.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace DateConverter.Core.Service_Factory
{
    public class DateFunctionsFactory
    {
        public static DateFunctions getDateFunctionsService()
        {
            IUnityContainer container = UnityFactory.getUnityContainer();
            var nepaliDateData = container.Resolve<NepaliDateData>();
            return new DateFunctionsImpl(nepaliDateData);
        }
    }
}
