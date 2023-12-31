using Core.Domain.User;
using Infrastructure.Data.Context;
using Infrastructure.Data.Entities.User;
using Kavenegar;

namespace Infrastructure.Repository.User;
public class User : IUser
{
    private readonly Context db;

    public User(Context dbContext)
    {
        db=dbContext;
    }
    public void AddUser(MUser user)
    {
      TblUser us=new TblUser();
      us.Name=user.Name;
      us.PhoneNumber=user.PhoneNumber;
      us.Token=user.Token;

        db.TblUsers.Add(us);
        db.SaveChanges();
    }

    public bool CheckToken(string token)
    {
        throw new NotImplementedException();
    }

    public int SendSms(string phone)
    {
            Random rnd=new Random();
            string number=rnd.Next(1000, 9999).ToString();

            var api = new KavenegarApi("3871353043697339486A70384F544A4A574C74612B51432F4C7A4B305076645457396F5267456F7A5A34383D");
            api.VerifyLookup(phone, number,"demo");


            return int.Parse(number);
    }
}