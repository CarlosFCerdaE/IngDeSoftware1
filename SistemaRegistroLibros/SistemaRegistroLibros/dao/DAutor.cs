using SistemaRegistroLibros.clases;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRegistroLibros.dao
{
    public class DAutor
    {
        string strConn = "Data Source =.; Initial Catalog = BDLibros; Persist Security Info = True; User ID = sa; Password = 123";
        public bool Guardar(Autor a)
        {
            bool flag = false;
            try {
                /*string strConn = ConfigurationManager.ConnectionStrings["strConexion"].ConnectionString.ToString();*/
                
                SqlConnection conn = new SqlConnection(strConn);
                string tsql = "INSERT INTO [dbo].[Autor] VALUES(@FirstName,@LastName)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("FirstName",a.FirstName);
                cmd.Parameters.AddWithValue("LastName", a.LastName);
                cmd.ExecuteNonQuery();
                conn.Close();
                flag= true;
            }catch(Exception ex) {
                flag = false; 
            }

            return flag;
        }

        public bool Editar(Autor a)
        {
            bool flag = false;
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                string tsql = "UPDATE [dbo].[Autor] SET FirstName = @FirstName, LastName = @LastName WHERE AuthorID = @AuthorID";
                conn.Open();
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("FirstName", a.FirstName);
                cmd.Parameters.AddWithValue("LastName", a.LastName);
                cmd.Parameters.AddWithValue("AuthorID", a.Id);

                int x = cmd.ExecuteNonQuery();
                if (x > 0) flag = true;
                conn.Close();
                
            }
            catch (Exception ex)
            {
                flag = false;
            }

            return flag;
        }

        public Autor BuscarPorId(int id)
        {
            Autor autor = new Autor();
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                string tsql = "SELECT * FROM [dbo].[Autor] WHERE AuthorID = @AuthorID";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tsql,strConn);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("AuthorID", id);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    autor.Id = int.Parse(ds.Tables[0].Rows[0]["AuthorId"].ToString());
                    autor.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                    autor.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();

                }
            }
            catch (Exception ex)
            {
            }

            return autor;
        }

        public bool Eliminar(int id)
        {
            bool flag = false;
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                string tsql = "DELETE FROM [dbo].[Autor] WHERE AuthorID = @AuthorID";
                conn.Open();
                SqlCommand cmd = new SqlCommand(tsql, conn);
                cmd.Parameters.AddWithValue("AuthorID", id);
                int x = cmd.ExecuteNonQuery();
                if (x > 0) flag = true;
                conn.Close();
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
            }

            return flag;
        }

        public DataSet mostrarRegistro() { 
            DataSet ds = new DataSet();
            try
            {
                string tsql = "SELECT Firstname AS Nombre, Lastname AS Apellido FROM Autor";
                SqlConnection conn = new SqlConnection(strConn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tsql, strConn);
                sqlDataAdapter.Fill(ds);
            }
            catch (Exception ex)
            {

            }

            return ds; 
        }

        public DataSet mostrarRegistro(string campo,string value)
        {
            DataSet ds = new DataSet();
            try
            {
                value = "%" + value + "%";
                string tsql = "SELECT Firstname AS Nombre, Lastname AS Apellido FROM Autor WHERE "+campo+" LIKE @value";
                SqlConnection conn = new SqlConnection(strConn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(tsql, strConn);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("value", value);
                sqlDataAdapter.Fill(ds);

            }
            catch (Exception ex)
            {

            }

            return ds;
        }

        

    }
}
