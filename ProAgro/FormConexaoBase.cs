using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_no_database
{
    public partial class FormConexaoBase : Form
    {
        public Boolean Conectado = false;
        public FormConexaoBase()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //string ConectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2}; Password{3}", cboServer.Text, txtDatabase.Text, txtUserName.Text, txtPassword.Text);
            string ConectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security = True;", cboServer.Text, txtDatabase.Text);
            try
            {
                SqlHelper helper = new SqlHelper(ConectionString);
                if (helper.IsConection)
                    MessageBox.Show("Conexão efetuada com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormConexaoBase_Load(object sender, EventArgs e)
        {
            txtDatabase.Text = "DBProAgro";
            cboServer.Items.Add(string.Format(@"{0}", Environment.MachineName));
            cboServer.Items.Add(@".\SQLEXPRESS");
            cboServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cboServer.Items.Add(".");
            cboServer.Items.Add("local");
            cboServer.SelectedIndex = 3;
            TryConection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string ConectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2}; Password{3}", cboServer.Text, txtDatabase.Text, txtUserName.Text, txtPassword.Text);
            string ConectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security = True;", cboServer.Text, txtDatabase.Text);
            try
            {
               /* SqlHelper helper = new SqlHelper(ConectionString);
                if (helper.IsConection)
                {*/
                    AppSetting setting =new AppSetting();
                    setting.SaveConnectionString("ProAgro", ConectionString);
                    //MessageBox.Show("Sua conexão  foi salva.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Conectado = true;
                    Close();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não pode fazer conexão com os dados informados, assim nao pode salvar as configurações! Os erros foram " + ex.Message, "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TryConection()
        {
            for (int i = 0; i < cboServer.Items.Count ; i++)
            {
                cboServer.SelectedIndex = i;
                string ConectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security = True;", cboServer.Text , txtDatabase.Text);
                try
                {
                    SqlHelper helper = new SqlHelper(ConectionString);
                    if (helper.IsConection)
                    {
                        AppSetting setting = new AppSetting();
                        setting.SaveConnectionString("ProAgro", ConectionString);
                        Conectado = true;
                        Close();                        
                    }
                }
                catch(Exception ex)
                { }
            }
            cboServer.SelectedIndex = 0;
        }
    }
}
