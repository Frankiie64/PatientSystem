using System;
using System.Net;
using EASendMail;

namespace EmailLayer
{
    public class EmailSender
    {

        public bool EnviarEmail(string Destinatario, string Titulo, string Cuerpo)
        {

            try
            {
                SmtpMail mail = new SmtpMail("TryIt");
                
                mail.From = "gbase7768@gmail.com";
                mail.To = Destinatario;
                mail.Subject = Titulo;
                mail.TextBody = Cuerpo;

                SmtpServer server = new SmtpServer("smtp.gmail.com");

                server.User ="gbase7768@gmail.com";
                server.Password = "programacion1";
                server.Port = 587;
                server.ConnectType = SmtpConnectType.ConnectSSLAuto;

                SmtpClient client = new SmtpClient();

                client.SendMail(server,mail);

                return true;
            }
            catch(Exception)
            {

                return false;
            }



        }

    }
}
