using MeetingOrganizer.BussinesLayer.Abstract;
using MeetingOrganizer.EntityLayer.Concrete;
using MeetingOrganizer.EntityLayer.Concrete.VMs.UserVM;

namespace MeetingOrganizer.BussinesLayer.Concrete
{
    public class UserManager : Manager<User, int>, IUserManager
    {

        //IUserManagerde is kurallari olusturursan ilgili manager metodunu override edip configure edebilirsin.
        public async Task<User> ChackUserLogin(User entity)
        {
            User user = await FirstOrDefault(p => p.Email == entity.Email && p.Password == entity.Password);
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
            User user = await FirstOrDefault(p => p.Email == entity.Email);
            if (user == null)
            {
                return true;
            }
            else
            {
                throw new Exception("Kullanıcı zaten mevcut. !");
            }

        }

        public async Task<bool> ChackConfirmPassword(UserRegisterVm userRegisterVm)
        {
            if (userRegisterVm.Password == userRegisterVm.ConfirmPassword)
            {
                return true;
            }
            else
            {
                throw new Exception("Girilen parolalar eşleşmiyor. !");
            }

        }

        public async Task<bool> ChackTcNo(UserRegisterVm userRegisterVm)
        {

            if (!long.TryParse(userRegisterVm.TcNo, out long sonuc))
            {
                throw new Exception("Lütfen TcNo alanını sadece rakamdan oluşacak şekilde giriniz.");
            }
            else if (userRegisterVm.TcNo.Length != 11)
            {
                throw new Exception("Lütfen TcNo alanını 11 karakterden oluşacak şekilde giriniz.");
            }

            return true;
        }

        public async Task<User> GetByEmailUser(string email)
        {
            User user = await FirstOrDefault(p => p.Email == email);
            if (user == null)
            {
                throw new Exception("Kayıt işlemi sırasında beklenmedik bir hata meydana geldi, lütfen tekrar kayıt olunuz.");
            }
            return user;
        }


        public async Task<bool> ConfirmEmailAsync(string uid, string code)
        {
            User user = await GetByPK(int.Parse(uid));

            if (user == null || user.ConfirmEmailGuid != code)
            {
                throw new Exception("Email confirm sırasında bir hata meydana geldi, lütfen tekrar deneyin");
            }

            user.isConfirmEmail = true;
            await update(user);

            return true;
        }

        public async Task<string> CreateEmailConfirmGuidCode(User user)
        {
            Guid guid = Guid.NewGuid();
            string code = guid.ToString();
            user.ConfirmEmailGuid = code;
            await update(user);
            return code;
        }

        public async Task<bool> ChackUserEmailConfirm(User user)
        {
            User myuser = await GetByPK(user.Id);
            if (myuser.isConfirmEmail)
            {
                return true;
            }
            else
            {
                throw new Exception("Lütfen email adresinizi, mail adresinize gönderdiğim linkten onaylayınız.");
            }

        }



    }
}
