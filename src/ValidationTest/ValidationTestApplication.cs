using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

namespace ValidationTest
{
	public class ValidationTestApplication : IApplicationSource
	{
	    public FubuApplication BuildApplication()
	    {
            return FubuApplication.For<ValidationTestFubuRegistry>()
				.StructureMap<ValidationTestRegistry>();
	    }
	}
}