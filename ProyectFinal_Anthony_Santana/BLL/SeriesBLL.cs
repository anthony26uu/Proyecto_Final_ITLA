using ProyectFinal_Anthony_Santana.Models;
using ProyectoFinal_Anthony_Santana.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectFinal_Anthony_Santana.BLL
{
    public class SeriesBLL
    {

        public static bool Guardar(Series cliente)
        {
            using (var conexion = new RegistroDb())
            {
                try
                {
                    conexion.seriesdb.Add(cliente);
                    if (conexion.SaveChanges() > 0)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
        public static Series Buscar(int? serieid)
        {
            Series serie = null;
            using (var conexion = new RegistroDb())
            {
                try
                {
                    serie = conexion.seriesdb.Find(serieid);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return serie;
        }
        public static bool Modificar(Series cliente)
        {
            using (var conexion = new RegistroDb())
            {
                try
                {
                    conexion.Entry(cliente).State = EntityState.Modified;
                    if (conexion.SaveChanges() > 0)
                        return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
        public static bool Eliminar(Series cliente)
        {
            using (var conexion = new RegistroDb())
            {
                try
                {
                    conexion.Entry(cliente).State = EntityState.Deleted;
                    if (conexion.SaveChanges() > 0)
                        return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return false;
        }
        public static List<Series> Listar()
        {
            List<Series> listado = null;
            using (var conexion = new RegistroDb())
            {
                try
                {
                    listado = conexion.seriesdb.OrderBy(c => c.Titulo).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }

        public static bool Eliminar(int? clienteId)
        {
            try
            {
                return Eliminar(Buscar(clienteId));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int Identity()
        {
            int identity = 0;
            string con =

            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RegistroDb.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('Series')", conexion);
                    identity = Convert.ToInt32(comando.ExecuteScalar());
                    conexion.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return identity;
        }
    }
}