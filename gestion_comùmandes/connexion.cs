using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class connexion
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=gestion_commande;Integrated Security=True");
        public static SqlCommand cmd = cn.CreateCommand();
        public static SqlDataReader dr;

        public static BindingSource bs = new BindingSource();
        public static BindingSource bs1 = new BindingSource();
        public static BindingSource bs2 = new BindingSource();
        public static BindingSource bs3 = new BindingSource();

        }
}
