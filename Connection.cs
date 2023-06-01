using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security;

namespace SCIApp
{
    internal class Connection
    {
        private SqlConnection connection;
        private string _ConnectionString;
        public Connection()
        {
            _ConnectionString = GetConnectionString();
            try
            {
                connection = new SqlConnection(_ConnectionString);
                MessageBox.Show("Conexión establecida satisfactoriamente", "Estado de Conexión");
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

        public bool LogInSystem(string user, string password)
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
                    MessageBox.Show("Sesión iniciada...", "Inicio de Sesión");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }

            return false;
        }

        public void InsertItem(Especie Item)
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("db_InsertItem", connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@itemCode", Item.code);
                sql.Parameters.AddWithValue("@detail", Item.detail);
                sql.Parameters.AddWithValue("@marca", Item.brand);
                sql.Parameters.AddWithValue("@model", Item.model);
                sql.Parameters.AddWithValue("@qty", Item.quantity);
                sql.Parameters.AddWithValue("@ubic", Item.location);
                sql.Parameters.AddWithValue("@dep", Item.dependency);
                sql.ExecuteNonQuery();
                sql.Parameters.Clear();

                MessageBox.Show("Especie ingresada con éxito", "Movimiento de Especie");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
        }


    }
}
