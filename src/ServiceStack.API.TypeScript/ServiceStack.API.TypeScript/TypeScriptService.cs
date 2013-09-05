namespace ServiceStack.API.TypeScript
{
    public class TypeScriptService : ServiceInterface.Service
    {
        public object Get(Definition request)
        {
            return TypeLite.TypeScript.Definitions()
                .ForLoadedAssemblies()
                .WithFormatter((type, f) => "I" + ((TypeLite.TsModels.TsClass)type).Name)
                .Generate();
        }
    }
}
