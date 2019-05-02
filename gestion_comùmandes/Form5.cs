using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            charger_accessoire();
            charger_g1();
        }

        private void charger_g1()
        {
            connexion.cn.Open();
            connexion.cmd.CommandText = "select numcom,libelle,qtecommande from ligne_commandes l,accessoire a where l.codeacc=a.codeacc and numcom='"+ t1.Text +"'";
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.bs3.DataSource = connexion.dr;

            connexion.dr.Close();
            connexion.cn.Close();

            g1.DataSource = connexion.bs3;
        }

        private void charger_accessoire()
        {
            connexion.cn.Open();
            connexion.cmd.CommandText = "select codeacc,libelle from accessoire";
            connexion.dr = connexion.cmd.ExecuteReader();
            connexion.bs2.DataSource = connexion.dr;

            c1.DisplayMember = "libelle";
            c1.ValueMember = "codeacc";

            connexion.dr.Close();
            connexion.cn.Close();

            c1.DataSource = connexion.bs2;

        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connexion.cn.Open();
            connexion.cmd.CommandText = "select prix,stockacc from accessoire where codeacc='"+ c1.SelectedValue.ToString()+"'";
            connexion.dr = connexion.cmd.ExecuteReader();

            connexion.dr.Read();
            t3.Text = connexion.dr[0].ToString();
            t4.Text = connexion.dr[1].ToString();

            connexion.dr.Close();
            connexion.cn.Close();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
             t4.Text =( int.Parse(t4.Text) - int.Parse(t5.Text)).ToString();
             connexion.cn.Open();
            
            try
            {

            connexion.cmd.CommandText = "insert into ligne_commandes values('"+ t1.Text +"','"+ c1.SelectedValue.ToString() +"','"+ t5.Text +"')";
            connexion.cmd.ExecuteNonQuery();


            }
            catch
            {

                connexion.cmd.CommandText = "update ligne_commandes set qtecommande=qtecommande+ '" + t5.Text + "' where numcom='"+ t1.Text +"' and codeacc='" + c1.SelectedValue.ToString() + "'";
                connexion.cmd.ExecuteNonQuery();
            }

           
            connexion.cmd.CommandText = "update accessoire set stockacc='" + t4.Text + "' where codeacc='" + c1.SelectedValue.ToString() + "'";
            connexion.cmd.ExecuteNonQuery();
            
                      
            connexion.cn.Close();

            charger_g1();
        }

        private void t5_TextChanged(object sender, EventArgs e)
        {
            if (t5.Text != "")
            {

                if (int.Parse(t5.Text) > int.Parse(t4.Text))
                {
                    MessageBox.Show("La quantité commandée doit etre <= quatite en stock");
                    t5.Text = "";
                    t5.BackColor = Color.Red;
                }
            
            
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            string numc,codea,lib,qte;

            numc = g1.CurrentRow.Cells[0].Value.ToString();
            lib = g1.CurrentRow.Cells[1].Value.ToString();
            qte = g1.CurrentRow.Cells[2].Value.ToString();

            connexion.cn.Open();
            connexion.cmd.CommandText = "select codeacc from accessoire where libelle='"+ lib +"'";
            codea = connexion.cmd.ExecuteScalar().ToString();

            connexion.cmd.CommandText = "delete from ligne_commandes where numcom='"+ numc +"' and codeacc='"+ codea +"'";
            connexion.cmd.ExecuteNonQuery();

            connexion.cmd.CommandText = "update accessoire set stockacc=stockacc+'"+ int.Parse(qte) +"' where codeacc='" + codea + "'";
            connexion.cmd.ExecuteNonQuery();
            
            connexion.cn.Close();

            charger_g1();

        }
    } 
}
