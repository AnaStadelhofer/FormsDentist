using System;
using System.Windows.Forms;
using Telas;
using lib;

namespace Telas
{
    public class Login : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPassword;
        TextBox txtUser;
        TextBox txtPass;

        Button btnLogar;
        Button btnSair;
        public Login()
        {
            this.lblUser = new Campos.LabelField("Usuário", 120, 30);

            this.txtUser = new Campos.TextBoxField(60, 60, 180, 20);
    
            this.lblPassword = new Campos.LabelField("Senha", 120, 100);

            this.txtPass = new Campos.TextBoxField(60, 130, 180, 20);
            //this.txtPass.PasswordChar = "*";

            btnLogar = new Campos.ButtonField("Logar", 100, 180, 100, 30);
			btnLogar.Click += new EventHandler(this.btnLogarClick);

			btnSair = new Campos.ButtonField("Sair", 100, 220, 100, 30);
			btnSair.Click += new EventHandler(this.btnSairClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnSair);
            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Login";
        }

        public void btnLogarClick(object sender, EventArgs e)
        {              
            try
            {
                if (txtUser.Text == "jose.carmo@dentista.com") 
                {
                    MenuDentistaTela MenuDentistaTelas = new MenuDentistaTela();
                    MenuDentistaTelas.ShowDialog();
                }
                else 
                {
                    MenuPacienteTela MenuPacienteTelas = new MenuPacienteTela();
                    MenuPacienteTelas.ShowDialog();                
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void btnSairClick(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
