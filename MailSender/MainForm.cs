using Markdig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient mySmtpClient = new SmtpClient("smtp.forpsi.com", 587);

                mySmtpClient.UseDefaultCredentials = false;
                NetworkCredential basicAuthenticationInfo = new NetworkCredential("programovani@zdendaki.net", "csharp123");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from, to mailaddresses
                MailAddress from = new MailAddress(Sender.Text, SenderName.Text);
                MailAddress to = new MailAddress(Recipient.Text, RecipientName.Text);
                MailMessage myMail = new MailMessage(from, to);

                // set subject and encoding
                myMail.Subject = Subject.Text;
                myMail.SubjectEncoding = Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = Markdown.ToHtml(Message.Text);
                myMail.BodyEncoding = Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Chyba na straně SMTP serveru.\n{ex.Message}", "Mail se nepodařilo odeslat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-Mail se nepodařilo odeslat.\n{ex.Message}", "Mail se nepodařilo odeslat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
