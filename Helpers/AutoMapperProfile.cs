using AutoMapper;
using NET_6._0_CRUD_API_Project_Structure.Entities;
using NET_6._0_CRUD_API_Project_Structure.Models.Users;

namespace NET_6._0_CRUD_API_Project_Structure.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateRequest -> User
            CreateMap<CreateRequest, User>();

            // UpdateRequest -> User
            CreateMap<UpdateRequest, User>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
             ));
        }
    }
}
