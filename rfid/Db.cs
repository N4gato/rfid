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
       delegate void addItemCallback(string id); // creati delegate 


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

        public SqlDataReader getlastId() {
            SqlCommand cm = new SqlCommand("SELECT Id FROM Tag ORDER BY Id DESC ", this.cn);
            SqlDataReader lastId = cm.ExecuteReader();
            // reader.Close();
            return lastId;
        }


        public void storeId(Object source, byte[] tagId) {
            string datas = "";
            for (int i = 5; i < 10; i++)
                datas += tagId[i].ToString("X");

           // addItemCallback aic = new addItemCallback(addItem); //init the delegate 
            //this.Invoke(aic, datas); // this tread please invoke or take controle of datas that belong to other thread 
            ////with my methode Additem
            string date = System.DateTime.Now.ToString();

            SqlCommand prikaz = new SqlCommand("INSERT INTO Tag(TagId,Date,Destination,Status) values(@TagId,@Date,@Destination,@Status)", this.cn);

            prikaz.Parameters.AddWithValue("@TagId", datas);
            prikaz.Parameters.AddWithValue("@Date", date);
            prikaz.Parameters.AddWithValue("@Destination", "Rabat");
            prikaz.Parameters.AddWithValue("@Status", "Out");
            //cn.Open();
            try {
                // code here
                prikaz.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    MessageBox.Show(ex.ToString());
                }
                else {
                    // Handle generic ones here.
                }
            }
        }

        public void deletItem(string id)
        {
            SqlCommand prikaz = new SqlCommand("DELETE FROM Tag WHERE Id = "+id, this.cn);

            try
            {
                // code here
                prikaz.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (ex is SqlException)
                {
                    MessageBox.Show(ex.ToString());
                }
                else {
                    // Handle generic ones here.
                }
            }
        }



    }
}
