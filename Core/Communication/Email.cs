using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Communication
{
    public static class Email
    {
        public static void Send(string message)
        {
        }

        public static void Send(string to, string subject, string message)
        {
            EmailCore.SendEmail(to: to
                               , from: "bharrison912@gmail.com"
                               , cc: ""
                               , subject: subject
                               , message: message
                               );
        }

        public static void Send(string to, string from, string subject, string message)
        {

        }

        public static void Send(string to, string from, string cc, string subject, string message)
        {

        }
    }
}