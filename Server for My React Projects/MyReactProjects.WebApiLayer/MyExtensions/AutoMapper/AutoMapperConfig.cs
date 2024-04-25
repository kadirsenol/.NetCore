using AutoMapper;
using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.Concrete.VMs.ToplantiKayitVm;
using MeetingOrganizer.EntityLayer.Concrete.VMs.UserVM;


namespace MeetingOrganizer.WebApiLayer.MyExtensions.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<UserLoginVm, User>().ReverseMap();
            CreateMap<UserRegisterVm, User>().ReverseMap();
            CreateMap<ToplantiCreateVm, ToplantiKayit>().ReverseMap();
            CreateMap<ToplantiUpdateVm, ToplantiKayit>().ReverseMap();
        }
    }
}
