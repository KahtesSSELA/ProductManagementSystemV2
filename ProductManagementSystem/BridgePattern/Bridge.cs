using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementSystem.BridgePattern
{
    public abstract class Bridge
    {
        public abstract void request(string id, string name, string prodtype, decimal price);
    }
    public class _insert : Bridge
    {
        private SqlCommand cmd;
        SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-C1548M6R\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True");
        public override void request(string id, string name, string prodtype, decimal price)
        {
            try
            {
                cmd = new SqlCommand(@"insert into Product2 (ProductID,ProductName,Price,ProductType)VALUES(@ProductID,@ProductName,@Price,@ProductType)",
                    sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@ProductName", name);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@ProductType", prodtype);
                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                cmd.ExecuteNonQuery();

                sqlCon.Close();
                MessageBox.Show("Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class _update : Bridge
    {
        private SqlCommand cmd;
        SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-C1548M6R\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True");
        public override void request(string id, string name, string prodtype, decimal price)
        {
            try
            {

                cmd = new SqlCommand(@"update Product2 set ProductName=@ProductName,ProductType=@ProductType, Price=@Price where ProductID = @ProductID", sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ProductID", id);
                cmd.Parameters.AddWithValue("@ProductName", name);
                cmd.Parameters.AddWithValue("@ProductType", prodtype);
                cmd.Parameters.AddWithValue("@Price", price);
                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Successfully Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class _delete : Bridge
    {
        private SqlCommand cmd;
        SqlConnection sqlCon = new SqlConnection("Data Source=LAPTOP-C1548M6R\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True");
        public override void request(string id, string name, string prodtype, decimal price)
        {
            try
            {
                sqlCon = new SqlConnection("Data Source=LAPTOP-C1548M6R\\SQLEXPRESS;Initial Catalog=Product;Integrated Security=True");
                cmd = new SqlCommand(@"delete Product2 where ProductID=@ID", sqlCon);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", id);
                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Successfully Deleted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
