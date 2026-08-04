using System.Net.Mail;

namespace SwishSystems.Web.Helper
{
    public class Mailer
    {
        //    private static void Send(string body, MailSettings mailSettings)
        //    {
        //        try
        //        {

        //            if (mailSettings.SendNotification)
        //            {
        //                SmtpClient smtpClient = new(mailSettings.Server, mailSettings.Port)
        //                {
        //                    //UseDefaultCredentials = config.DefaultCredentials,
        //                    EnableSsl = mailSettings.EnableSsl,
        //                    Credentials = new NetworkCredential(mailSettings.Username, mailSettings.Password)
        //                };

        //                MailMessage mail = new()
        //                {
        //                    From = new MailAddress(mailSettings.From),
        //                    Subject = mailSettings.Subject,
        //                    SubjectEncoding = System.Text.Encoding.UTF8,
        //                    IsBodyHtml = mailSettings.IsHTML,
        //                    BodyEncoding = System.Text.Encoding.UTF8,
        //                    Body = body
        //                };

        //                if (!String.IsNullOrEmpty(mailSettings.To))
        //                {
        //                    for (int ctr = 0; ctr < mailSettings.To.Split(';').Length; ctr++)
        //                    {
        //                        mail.To.Add(mailSettings.To.Split(';')[ctr]);
        //                    }
        //                }

        //                if (!String.IsNullOrEmpty(mailSettings.Cc))
        //                {
        //                    for (int ctr = 0; ctr < mailSettings.Cc.Split(';').Length; ctr++)
        //                    {
        //                        mail.CC.Add(mailSettings.Cc.Split(';')[ctr]);
        //                    }
        //                }

        //                if (!String.IsNullOrEmpty(mailSettings.Bcc))
        //                {
        //                    for (int ctr = 0; ctr < mailSettings.Bcc.Split(';').Length; ctr++)
        //                    {
        //                        mail.Bcc.Add(mailSettings.Bcc.Split(';')[ctr]);
        //                    }
        //                }

        //                smtpClient.Send(mail);
        //            }


        //        }
        //        catch (SmtpException ex)
        //        {
        //            throw new ApplicationException($"Exception has occurred: {ex.Message}");
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new ApplicationException($"Exception has occurred: {ex.Message}");
        //        }

        //    }

    }
}
