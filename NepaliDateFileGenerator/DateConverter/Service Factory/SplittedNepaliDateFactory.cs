using DateConverter.Core.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace DateConverter.Core.Service_Factory
{
    public class SplittedNepaliDateFactory
    {
        public static GetSplittedNepaliDateParts getSplittedNepaliDateService()
        {
            IUnityContainer container = UnityFactory.getUnityContainer();
            return container.Resolve<GetSplittedNepaliDateParts>();
        }
    }
}
