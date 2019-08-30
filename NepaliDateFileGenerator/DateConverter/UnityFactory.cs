using DateConverter.Core.Library;
using DateConverter.Core.Library.Interface;
using Unity;

namespace DateConverter.Core
{
    using dateConverterService = Library.Interface.DateConverter;
    public class UnityFactory
    {
        IUnityContainer container = new UnityContainer();
        private static IUnityContainer _container = null;
        public static IUnityContainer getUnityContainer()
        {
            if (_container == null)
            {
                UnityFactory unity = new UnityFactory();
                unity.createContainer();
            }
            return _container;
        }
        private void createContainer()
        {
            IUnityContainer container = new UnityContainer();
            registerServices(container);
            _container = container;
        }

        private void registerServices(IUnityContainer container)
        {
            container.RegisterType<ConversionStartDateData, ConversionStartDate5YearsIntervalImpl>();
            container.RegisterType<dateConverterService, DateConverterImpl>();
            container.RegisterType<DateFunctions, DateFunctionsImpl>();
            container.RegisterType<FiscalYearFunctions, FiscalYearFunctionsImpl>();
            container.RegisterType<NepaliDateData, NepaliDateDataImpl>();
            container.RegisterType<GetSplittedNepaliDateParts, GetSplittedNepaliDatePartsImpl>();
        }
       
    }
}
