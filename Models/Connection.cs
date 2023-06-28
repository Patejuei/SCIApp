using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security;
using DocumentFormat.OpenXml.Spreadsheet;
using SCIApp.Models;

namespace SCIApp
{
    internal class Connection
    {
        protected SqlConnection connection;
        private string _ConnectionString;
        public Connection()
        {
            _ConnectionString = GetConnectionString();
            try
            {
                connection = new SqlConnection(_ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexión fallida.\nCódigo de error: " + ex, "Estado de Conexión");
            }
        }

        static private string GetConnectionString()
        {
            return "Data Source=localhost; Initial Catalog=novenaDB; Integrated Security=True; TrustServerCertificate=true";
        }

        public int LogInSystem(string user, string password)
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("db_login", connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@username", user);
                sql.Parameters.AddWithValue("@password", password);
                SqlDataReader dr = sql.ExecuteReader();

                if (dr.Read())
                {
                    return dr.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
            return 0;
        }
        public void getItems(DataGridView dg)
        {
            try
            {
                connection.Open();
                string cmd = "SELECT * from inventario";
                SqlDataAdapter data = new SqlDataAdapter(cmd, connection);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dg.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
        }
        public void getItemsBySearch(DataGridView dg, string dep, string ubi, string desc)
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("db_srcItem", connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@desc", desc);

                if (dep != "Todo")
                {
                    sql.Parameters.AddWithValue("@depen", dep);
                }
                if (ubi != "Todo")
                {
                    sql.Parameters.AddWithValue("@ubic", ubi);

                }
                if (dep == "Todo")
                {
                    sql.Parameters.AddWithValue("@depen", "");
                }
                if (ubi == "Todo")
                {
                    sql.Parameters.AddWithValue("@ubic", "");
                }
                SqlDataAdapter data = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dg.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }

        }

        public SqlDataReader find(string id)
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("db_find_item", connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = sql.ExecuteReader();
                if (dr.Read())
                {
                    return dr;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
            finally { connection.Close(); }
            return null;
        }


    }

}

