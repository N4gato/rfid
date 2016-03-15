using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rfid
{
    class Db
    {

        SqlConnection cn;
        

        public Db() {
            // constructer connect to db

            this.cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nagato\Documents\RfidDb.mdf;Integrated Security=True;Connect Timeout=30; ");
            try {
                this.cn.Open();
            } catch(SqlException sEx){
                MessageBox.Show(sEx.Message, Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.ExitThread();
            }
        }

        public SqlDataReader dbGet() {
           
            SqlCommand cm = new SqlCommand("SELECT * FROM Tag ", this.cn);
            SqlDataReader reader = cm.ExecuteReader();
           // reader.Close();
            return reader;
            
        }
        
    }
}
