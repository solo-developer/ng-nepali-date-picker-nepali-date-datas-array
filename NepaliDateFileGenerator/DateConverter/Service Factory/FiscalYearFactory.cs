using DateConverter.Core.Library;
using DateConverter.Core.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace DateConverter.Core.Service_Factory
{
    using dateConverterService = DateConverter.Core.Library.Interface.DateConverter;
    public class FiscalYearFactory
    {
        public static FiscalYearFunctions getFiscalYearService()
        {
            IUnityContainer container = UnityFactory.getUnityContainer();
            var dateConverter = container.Resolve<dateConverterService>();
            var nepaliDateData = container.Resolve<NepaliDateData>();
            return new FiscalYearFunctionsImpl(dateConverter, nepaliDateData);
        }
    }
}
