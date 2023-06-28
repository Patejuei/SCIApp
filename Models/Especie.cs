using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

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

    }
}
