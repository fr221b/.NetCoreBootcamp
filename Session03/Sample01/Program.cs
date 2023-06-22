using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kavenegar;


namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
           // try 
            //{
                KavenegarApi Api = new KavenegarApi("4632492B4141306C4E4A7648766F71673456375458695246586C36654B2B49504C624F4142336D643136673D");
                //Api.VerifyLookup("1008663","09167815367","سلام");
                var message = Api.Send("1008663", "09117074782", "Hi");
            //}

           // catch()
            //{

           // }
            Console.ReadLine();
        }
    }
}
