using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerTipoDocumentoModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TipoDocumentoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TipoDocumentoModel aTipoDocumentoModel)
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
                    command.Parameters.AddWithValue("@Descripcion", aTipoDocumentoModel.Descripcion);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTipoDocumentoModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTipoDocumentoModel.Usuario_creador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spTipoDocumento";

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
        /// Updates a record to the TipoDocumentoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TipoDocumentoModel aTipoDocumentoModel)
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
                    command.Parameters.AddWithValue("@Id_documento", aTipoDocumentoModel.Id_documento);
                    command.Parameters.AddWithValue("@Descripcion", aTipoDocumentoModel.Descripcion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTipoDocumentoModel.Fecha_modificacion == null ? (object)DBNull.Value : aTipoDocumentoModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTipoDocumentoModel.Usuario_modificador == null ? (object)DBNull.Value : aTipoDocumentoModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spTipoDocumento";

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
        /// Deletes record to the TipoDocumentoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aId_documento)
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
                    command.Parameters.AddWithValue("@Id_documento", aId_documento);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spTipoDocumento";
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
        /// Selects the Single object of TipoDocumentoModel table.
        /// </summary>
        public TipoDocumentoModel GetTipoDocumentoModel(int aId_documento)
        {
            TipoDocumentoModel TipoDocumentoModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id_documento", aId_documento);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spTipoDocumento";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id_documento = (int)(reader["Id_documento"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TipoDocumentoModel = new TipoDocumentoModel
                            {
                                Id_documento = Id_documento,
                                Descripcion = Descripcion,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return TipoDocumentoModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TipoDocumentoModel table.
        /// </summary>
        public List<TipoDocumentoModel> TipoDocumentoModelSelectAll()
        {

            List<TipoDocumentoModel> TipoDocumentoModellist = new List<TipoDocumentoModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spTipoDocumento";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id_documento = (int)(reader["Id_documento"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TipoDocumentoModellist.Add(new TipoDocumentoModel
                            {
                                Id_documento = Id_documento,
                                Descripcion = Descripcion,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TipoDocumentoModellist;
            }
            catch (Exception)
            {
                return TipoDocumentoModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TipoDocumentoModel table by a given criteria.
        /// </summary>
        public List<TipoDocumentoModel> TipoDocumentoModelSelectbyUNKNOW(string aValue)
        {

            List<TipoDocumentoModel> TipoDocumentoModellist = new List<TipoDocumentoModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoDocumentoModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id_documento = (int)(reader["Id_documento"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            TipoDocumentoModellist.Add(new TipoDocumentoModel
                            {
                                Id_documento = Id_documento,
                                Descripcion = Descripcion,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TipoDocumentoModellist;
            }
            catch (Exception)
            {
                return TipoDocumentoModellist;
            }
        }
        #endregion

    }

}
