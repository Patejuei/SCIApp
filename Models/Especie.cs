using Microsoft.Data.SqlClient;
using System.Data;

namespace SCIApp.Models
{
    internal class Especie : Connection
    {
        public string code { get; set; }
        public string detail { get; set; }
        public string brand { get; set; }
        public string model { set; get; }
        public int quantity { get; set; }
        public string location { get; set; }
        public string dependency { get; set; }

        public Especie(string code)
        {
            this.code = code;
            connection.Open();
            SqlCommand sql = new SqlCommand("db_find_item", connection);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@id", code);
            SqlDataReader dr = sql.ExecuteReader();
            if (dr.Read())
            {
                this.detail = dr["detalle"].ToString();
                this.brand = dr["marca"].ToString();
                this.model = dr["modelo"].ToString();
                this.quantity = int.Parse(dr["cantidad"].ToString());
                this.location = dr["ubicación"].ToString();
                this.dependency = dr["dependencia"].ToString();
            }
            connection.Close();
        }

        public Especie(string code, string detail, string quantity, string location, string dependency)
        {
            this.code = code;
            this.detail = detail;
            this.quantity = Filter_Int(quantity);
            this.location = location;
            this.dependency = dependency;
            brand = "N/A";
            model = "N/A";
        }

        public string[] getParams()
        {
            return new string[] { code, detail, brand, model, quantity.ToString(), dependency, location };
        }

        private string Filter_Code(string code)
        {
            return code;
        }
        private int Filter_Int(string num)
        {
            if (num.Length > 0)
            {
                return int.Parse(num);
            }
            return 0;
        }
        public void InsertItem()
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("db_InsertItem", connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@itemCode", code);
                sql.Parameters.AddWithValue("@detail", detail);
                sql.Parameters.AddWithValue("@marca", brand);
                sql.Parameters.AddWithValue("@model", model);
                sql.Parameters.AddWithValue("@qty", quantity);
                sql.Parameters.AddWithValue("@ubic", location);
                sql.Parameters.AddWithValue("@dep", dependency);
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

        public void UpdateItem()
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("db_editItem", connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@id", code);
                sql.Parameters.AddWithValue("@location", location);
                sql.Parameters.AddWithValue("@dependency", dependency);
                sql.Parameters.AddWithValue("@quantity", quantity);
                sql.ExecuteNonQuery();
                sql.Parameters.Clear();

                MessageBox.Show("Especie modificada con éxito", "Movimiento de Especie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
        }

        public void set_quantity(string qty)
        {
            quantity = Filter_Int(qty);
        }

        public void DeleteItem()
        {
            try
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("db_deleteItem", connection);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@id", code);
                sql.ExecuteNonQuery();
                sql.Parameters.Clear();
                MessageBox.Show("Especie Eliminada con éxito", "Movimiento de Especie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally { connection.Close(); }
        }

    }
}
