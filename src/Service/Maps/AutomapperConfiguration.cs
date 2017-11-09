using AutoMapper;


namespace SimpleCommerce.Service.Maps
{
    public class AutomapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<CategoryProfile>();
                cfg.AddProfile<ProductProfile>();
               
            });
        }
    }
}
