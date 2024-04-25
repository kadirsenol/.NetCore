using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.Concrete.VMs.UserVM;


namespace MeetingOrganizer.BussinesLayer.Abstract
{
    public interface IUserManager : IManager<User, int>
    {
        //Gerekli is kurallari var ise eklenecek.
        public Task<User> ChackUserLogin(User entity);
        public Task<bool> ChackUserRegister(User entity);

        public Task<bool> ChackConfirmPassword(UserRegisterVm userRegisterVm);

        public Task<bool> ChackTcNo(UserRegisterVm userRegisterVm);

    }
}
