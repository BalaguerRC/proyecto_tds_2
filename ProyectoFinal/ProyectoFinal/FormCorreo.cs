using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ProyectoFinal
{
    public partial class FormCorreo : Form
    {
        public FormCorreo()
        {
            InitializeComponent();
        }

        private void enviarEmail()
        {
            //string mail = "lectorexample@gmail.com";
            //string pass = "Lectorexample10";


            //cliente.Port = 587;
            
            //cliente.Host = "smtp.gmail.com";
            
            //try
            //{

                MailMessage msg = new MailMessage();
                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                msg.From = new MailAddress("lectorexample@gmail.com", "Lector Programa");
                msg.To.Add(txtPara.Text);
                msg.Subject = txtAsunto.Text;
                msg.Body = "Prueba de envio";  //txtMensaje.TexT
                msg.IsBodyHtml = false;

                //msg.SubjectEncoding = Encoding.UTF8;
                //msg.BodyEncoding = Encoding.UTF8;



                
                cliente.Credentials = new NetworkCredential("lectorexample@gmail.com", "Lectorexample10");
                cliente.EnableSsl = true;
                cliente.Send(msg);
                MessageBox.Show("Enviado", "Aviso Email");

            //}
            //catch (Exception)
            //{

                //MessageBox.Show("Ocurrio un error", "Aviso Email");
            //}
        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            //enviarEmail(txtPara.Text, txtAsunto.Text, txtMensaje.Text);
            enviarEmail();
        }
    }
}
