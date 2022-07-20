using App_no_database.DBSET;
using App_no_database.Modelo;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ProAgroContext())
            {
                try
                {
                    var lUsuario = new USUARIO();
                    lUsuario.LOGIN_USU = "YgorRaphael";
                    lUsuario.SENHA_USU = "123456";
                    lUsuario.NOME_USU = "Ygor Raphael";


                    db.USUARIOs.Add(lUsuario);
                    db.SaveChanges();
                    MessageBox.Show("base criada com sucesso!", "SUCESSO", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu durante o processo: " + ex.Message);
                }                
            }
        }
    }
}


/* try
                {
                    var lstudent = new Student() { Name = "Ygor raphael" , Telefone = "991244001"};

                    var lmathSubj = new Subject() { Name = "Matematicas" };
                    var lPortSubj = new Subject() { Name = "Portugues" };

                    var lstudent2 = new Student() { Name = "Carlos", Telefone = "939136321" };

                    var lGeoSubj = new Subject() { Name = "Geografia" };
                    var lHisSubj = new Subject() { Name = "Historia" };

                    lstudent.Sunbjects.Add(lmathSubj);
                    lstudent.Sunbjects.Add(lPortSubj);

                    lstudent2.Sunbjects.Add(lGeoSubj);
                    lstudent2.Sunbjects.Add(lHisSubj);

                    db.Students.Add(lstudent);
                    db.Students.Add(lstudent2);
                    db.SaveChanges();
                    MessageBox.Show("base criada com sucesso!", "SUCESSO", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Um erro ocorreu durante o processo: " + ex.Message);
              }*/
