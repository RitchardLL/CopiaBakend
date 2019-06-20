using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerPermisosUsuarioModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the PermisosUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(PermisosUsuarioModel aPermisosUsuarioModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 4);

                    command.Parameters.AddWithValue("@Id_usuario", aPermisosUsuarioModel.Id_usuario == null ? (object)DBNull.Value : aPermisosUsuarioModel.Id_usuario);
                    command.Parameters.AddWithValue("@Id_rol", aPermisosUsuarioModel.Id_rol == null ? (object)DBNull.Value : aPermisosUsuarioModel.Id_rol);
                    command.Parameters.AddWithValue("@Id_componente", aPermisosUsuarioModel.Id_componente == null ? (object)DBNull.Value : aPermisosUsuarioModel.Id_componente);
                    command.Parameters.AddWithValue("@Estado", aPermisosUsuarioModel.Estado);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aPermisosUsuarioModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aPermisosUsuarioModel.Fecha_creacion);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spPermisosUsuario";

                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Updates a record to the PermisosUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(PermisosUsuarioModel aPermisosUsuarioModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 5);

                    command.Parameters.AddWithValue("@Id", aPermisosUsuarioModel.Id);
                    command.Parameters.AddWithValue("@Id_usuario", aPermisosUsuarioModel.Id_usuario == null ? (object)DBNull.Value : aPermisosUsuarioModel.Id_usuario);
                    command.Parameters.AddWithValue("@Id_rol", aPermisosUsuarioModel.Id_rol == null ? (object)DBNull.Value : aPermisosUsuarioModel.Id_rol);
                    command.Parameters.AddWithValue("@Id_componente", aPermisosUsuarioModel.Id_componente == null ? (object)DBNull.Value : aPermisosUsuarioModel.Id_componente);
                    command.Parameters.AddWithValue("@Estado", aPermisosUsuarioModel.Estado);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aPermisosUsuarioModel.Usuario_modificador == null ? (object)DBNull.Value : aPermisosUsuarioModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aPermisosUsuarioModel.Fecha_modificacion == null ? (object)DBNull.Value : aPermisosUsuarioModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spPermisosUsuario";

                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Deletes record to the PermisosUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aId)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 6);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spPermisosUsuario";
                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Selects the Single object of PermisosUsuarioModel table.
        /// </summary>
        public PermisosUsuarioModel GetPermisosUsuarioModel(int aId)
        {
            PermisosUsuarioModel PermisosUsuarioModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spPermisosUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            int? Id_usuario = reader["Id_usuario"] as int?;
                            int? Id_rol = reader["Id_rol"] as int?;
                            int? Id_componente = reader["Id_componente"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            PermisosUsuarioModel = new PermisosUsuarioModel
                            {
                                Id = Id,
                                Id_usuario = Id_usuario,
                                Id_rol = Id_rol,
                                Id_componente = Id_componente,
                                Estado = Estado,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            };
                        }
                    }
                }

                return PermisosUsuarioModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of PermisosUsuarioModel table.
        /// </summary>
        public List<PermisosUsuarioModel> PermisosUsuarioModelSelectAll()
        {

            List<PermisosUsuarioModel> PermisosUsuarioModellist = new List<PermisosUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spPermisosUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            int? Id_usuario = reader["Id_usuario"] as int?;
                            int? Id_rol = reader["Id_rol"] as int?;
                            int? Id_componente = reader["Id_componente"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            PermisosUsuarioModellist.Add(new PermisosUsuarioModel
                            {
                                Id = Id,
                                Id_usuario = Id_usuario,
                                Id_rol = Id_rol,
                                Id_componente = Id_componente,
                                Estado = Estado,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return PermisosUsuarioModellist;
            }
            catch (Exception)
            {
                return PermisosUsuarioModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of PermisosUsuarioModel table by a given criteria.
        /// </summary>
        public List<PermisosUsuarioModel> PermisosUsuarioModelSelectbyUNKNOW(string aValue)
        {

            List<PermisosUsuarioModel> PermisosUsuarioModellist = new List<PermisosUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PermisosUsuarioModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            int? Id_usuario = reader["Id_usuario"] as int?;
                            int? Id_rol = reader["Id_rol"] as int?;
                            int? Id_componente = reader["Id_componente"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            PermisosUsuarioModellist.Add(new PermisosUsuarioModel
                            {
                                Id = Id,
                                Id_usuario = Id_usuario,
                                Id_rol = Id_rol,
                                Id_componente = Id_componente,
                                Estado = Estado,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return PermisosUsuarioModellist;
            }
            catch (Exception)
            {
                return PermisosUsuarioModellist;
            }
        }
        #endregion

    }

}
