using StructureMap.Configuration.DSL;

namespace ValidationTest
{
	public class ValidationTestRegistry : Registry
	{
		public ValidationTestRegistry()
		{
			// make any StructureMap configuration here
			
            // Sets up the default "IFoo is Foo" naming convention
            // for auto-registration within this assembly
            Scan(x => {
                x.TheCallingAssembly();
                x.WithDefaultConventions();
            });
		}
	}
}