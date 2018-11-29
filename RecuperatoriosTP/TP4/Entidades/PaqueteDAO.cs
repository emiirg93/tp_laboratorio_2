using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PaqueteDAO
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            PaqueteDAO.comando = new SqlCommand();

            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }

        public static bool Insertar(Paquete p)
        {
            bool tof = false;

            try
            {
                string instruccion = "insert into dbo.Paquetes (direccionEntrega,trackingID,alumno) values('"+ p.DireccionEntrega + "','" + p.TrackingID + "','Emiliano Rago Y Fernandez')";

                PaqueteDAO.comando.CommandText = instruccion;
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();

                tof = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);     
            }
            finally
            {
                if(PaqueteDAO.conexion.State == System.Data.ConnectionState.Open)
                {
                    PaqueteDAO.conexion.Close();
                }
            }

            return tof;
        }


    }
}
