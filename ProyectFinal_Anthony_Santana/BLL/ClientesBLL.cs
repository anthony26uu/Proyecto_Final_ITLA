using System;
using System.Collections.Generic;
using System.Linq;

using System.Data.Entity;
using System.Data.SqlClient;
using ProyectoFinal_Anthony_Santana.DAL;
using ProyectFinal_Anthony_Santana.Models;

namespace ProyectFinal_Anthony_Santana.BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes cliente)
        {
            using (var conexion = new RegistroDb())
            {
                try
                {
                    conexion.clientedb.Add(cliente);
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
        public static Clientes Buscar(int? clienteId)
        {
            Clientes cliente = null;
            using (var conexion = new RegistroDb())
            {
                try
                {
                    cliente =  conexion.clientedb.Find(clienteId);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return cliente;
        }
        public static bool Modificar(Clientes cliente)
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
        public static bool Eliminar(Clientes cliente)
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
        public static List<Peliculas> ListarPeliculas()
        {
            List<Peliculas> listado = null;
            using (var conexion = new RegistroDb())
            {
                try
                {
                    listado = conexion.peliculadb.OrderBy(c => c.PeliculaId).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return listado;
        }
        public static List<Clientes> Listar()
        {
            List<Clientes> listado = null;
            using (var conexion = new RegistroDb())
            {
                try
                {
                    listado = conexion.clientedb.OrderBy(c => c.Nombres).ToList();
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

            @"Data Source=DESKTOP-QOJLCSQ\SQLEXPRESS;Initial Catalog=RegistroDb;Integrated Security=True";
            using (SqlConnection conexion = new SqlConnection(con))
            {
                try
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT IDENT_CURRENT('Clientes')", conexion);
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