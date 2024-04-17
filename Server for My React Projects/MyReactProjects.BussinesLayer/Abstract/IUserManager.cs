using MeetingOrganizer.EntityLayer.Concrete;

namespace MeetingOrganizer.BussinesLayer.Abstract
{
    public interface IUserManager : IManager<User, int>
    {
        //Gerekli is kurallari var ise eklenecek.
        public Task<User> ChackUserLogin(User entity);
        public Task<bool> ChackUserRegister(User entity);


    }
}
