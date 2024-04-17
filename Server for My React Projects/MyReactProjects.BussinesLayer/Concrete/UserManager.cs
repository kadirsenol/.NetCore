using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;

namespace MeetingOrganizer.BussinesLayer.Concrete
{
    public class UserManager : Manager<User, int>, IUserManager
    {

        //IUserManagerde is kurallari olusturursan ilgili manager metodunu override edip configure edebilirsin.
        public async Task<User> ChackUserLogin(User entity)
        {
            User user = await base.FirstOrDefault(p => p.Email == entity.Email && p.Password == entity.Password);
            if (user == null)
            {
                throw new Exception("Kullanıcı adı veya şifre hatalı");
            }
            else
            {
                return user;
            }

        }
        public async Task<bool> ChackUserRegister(User entity)
        {
            User user = await base.FirstOrDefault(p => p.Email == entity.Email);
            if (user == null)
            {
                return true;
            }
            else
            {
                throw new Exception("Kullanıcı zaten mevcut. !");
            }

        }
    }
}
