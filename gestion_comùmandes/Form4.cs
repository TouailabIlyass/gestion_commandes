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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            charger_client();
        }

        private void charger_client()
        {
            connexion.cn.Open();
            connexion.cmd.CommandText = "select codeclt,nom from clients";
            connexion.dr = connexion.cmd.ExecuteReader();

            connexion.bs.DataSource = connexion.dr;
           

            c1.DisplayMember = "nom";
            c1.ValueMember = "codeclt";

            connexion.dr.Close();
            connexion.cn.Close(); 
            
            c1.DataSource = connexion.bs;
        }

        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connexion.cn.Open();
            connexion.cmd.CommandText = "select prenom,adresse from clients where codeclt='"+ c1.SelectedValue.ToString()+"'";
            connexion.dr = connexion.cmd.ExecuteReader();

            connexion.dr.Read();
            t1.Text = connexion.dr["prenom"].ToString();
            t2.Text = connexion.dr["adresse"].ToString();

            connexion.dr.Close();

            connexion.cn.Close();


            charger_commandes();
        }

        private void charger_commandes()
        {
            connexion.cn.Open();
            connexion.cmd.CommandText = "select numcom,datecom from commandes where codeclt='"+c1.SelectedValue.ToString()+"'";
            connexion.dr = connexion.cmd.ExecuteReader();

            connexion.bs1.DataSource = connexion.dr;

            c2.DisplayMember = "numcom";
            c2.ValueMember = "datecom";

            connexion.dr.Close();
            connexion.cn.Close();

            c2.DataSource = connexion.bs1;

        }

        private void c2_SelectedIndexChanged(object sender, EventArgs e)
        {
            t3.Text = c2.SelectedValue.ToString();
        }

        private void details_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();

            f.t1.Text = c2.Text;
            f.t2.Text = c2.SelectedValue.ToString();


            f.Show();
        } 
    }
}
