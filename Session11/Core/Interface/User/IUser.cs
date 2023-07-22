using Core.Domain.User;
namespace Core.Domain.User;
public interface IUser{
    
    int SendSms(string phonenumber);
    void AddUser(MUser user);
    bool CheckToken(string token);

}