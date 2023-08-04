using System.Globalization;

namespace Infrastructure.Repository;
public static class PersianDateToMiladi
{
     public static DateTime PersianDateToMiladiDate(this string persianDate){
           
           var persianCalendar=new PersianCalendar();
           var year=int.Parse(persianDate.Substring(0,4));
           var month=int.Parse(persianDate.Substring(5,2));
           var day=int.Parse(persianDate.Substring(8,2));
           var hour=int.Parse(persianDate.Substring(11,2));
           var minute=int.Parse(persianDate.Substring(14,2));
           var second=int.Parse(persianDate.Substring(17,2));
           var miladiDate=persianCalendar.ToDateTime(year,month,day,hour,minute,second,0);
           return miladiDate;
     }

     public static string ConvertToJalali(this DateTime miladiDate){
           

           var persianCalendar=new PersianCalendar();
           var year =persianCalendar.GetYear(miladiDate);
           var month=persianCalendar.GetMonth(miladiDate);
           var day=persianCalendar.GetDayOfMonth(miladiDate);
           var hour=persianCalendar.GetHour(miladiDate);
           var minute=persianCalendar.GetMinute(miladiDate);
           var second=persianCalendar.GetSecond(miladiDate);
           var shamsiDate=$"{year}/{month}/{day} {hour}:{minute}:{second}";
           return shamsiDate;



           
     }

            
     }
