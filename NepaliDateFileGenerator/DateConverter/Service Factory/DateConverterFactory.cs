using DateConverter.Core.Library;
using DateConverter.Core.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace DateConverter.Core.Service_Factory
{
    using dateConverterService = DateConverter.Core.Library.Interface.DateConverter;
    public class DateConverterFactory
    {
        public static dateConverterService getDateConverterService()
        {
            IUnityContainer container = UnityFactory.getUnityContainer();
            var dateFunctions = container.Resolve<DateFunctions>();
            var startDates = container.Resolve<ConversionStartDateData>();
            var nepaliDateData = container.Resolve<NepaliDateData>();
            return new DateConverter.Core.Library.DateConverterImpl(startDates, dateFunctions, nepaliDateData);
        }
    }
}
