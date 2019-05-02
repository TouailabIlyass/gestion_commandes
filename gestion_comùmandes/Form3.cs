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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            t1.Text = "";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";

            t1.Focus();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                connexion.cn.Open();
                connexion.cmd.CommandText = "insert into clients values('" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "')";
                connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("Bien");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                connexion.cn.Close();
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                connexion.cn.Open();
                connexion.cmd.CommandText = "update clients set nom='" + t2.Text + "',prenom='" + t3.Text + "',adresse='" + t4.Text + "' where codeclt='" + t1.Text + "'";
                connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("Bien");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                connexion.cn.Close();
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                connexion.cn.Open();
                connexion.cmd.CommandText = "delete from clients where codeclt='" + t1.Text + "'";
                connexion.cmd.ExecuteNonQuery();
                MessageBox.Show("Bien");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

                connexion.cn.Close();
            }
        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            connexion.cn.Open();

            connexion.cmd.CommandText = "select * from clients where codeclt='" + t1.Text + "'";
            connexion.dr = connexion.cmd.ExecuteReader();

            if (connexion.dr.Read() == true)
            {
                t1.Text = connexion.dr[0].ToString();
                t2.Text = connexion.dr[1].ToString();
                t3.Text = connexion.dr[2].ToString();
                t4.Text = connexion.dr[3].ToString();
            }
            else
            {
                MessageBox.Show("ce code n existe pas!");
            }

            connexion.dr.Close();
            connexion.cn.Close();
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            connexion.cn.Open();
            connexion.cmd.CommandText = "select * from clients";
            connexion.dr = connexion.cmd.ExecuteReader();

            connexion.bs.DataSource = connexion.dr;
            g1.DataSource = connexion.bs;

            connexion.dr.Close();
            connexion.cn.Close();
        }

        private void premier_Click(object sender, EventArgs e)
        {
            connexion.bs.MoveFirst();
        }

        private void precedent_Click(object sender, EventArgs e)
        {
            connexion.bs.MovePrevious();
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            connexion.bs.MoveNext();
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            connexion.bs.MoveLast();
        }

        private void g1_SelectionChanged(object sender, EventArgs e)
        {
            t1.Text = g1.CurrentRow.Cells[0].Value.ToString();
            t2.Text = g1.CurrentRow.Cells[1].Value.ToString();
            t3.Text = g1.CurrentRow.Cells[2].Value.ToString();
            t4.Text = g1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
