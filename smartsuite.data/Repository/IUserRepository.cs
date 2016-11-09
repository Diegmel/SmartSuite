using System.Collections.Generic;
using smartsuite.data.Repository;

public interface IUserRepository
{
    List<User> GetAll();
    User Find(int id);
    User Add(User user);
    User Update(User user);
    void Remove(int id);
    User GetUserInformatiom(int id);

    List<UserSecurity> GetAccess();
    UserSecurity LogIn(string UserID, string Pass);
}