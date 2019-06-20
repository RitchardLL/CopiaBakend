using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerTipoMovimientoModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TipoMovimientoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TipoMovimientoModel aTipoMovimientoModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_TipoMovimientoModel", aTipoMovimientoModel.Id_tipomovimiento);
                    command.Parameters.AddWithValue("@Descripcion", aTipoMovimientoModel.Descripcion == null ? (object)DBNull.Value : aTipoMovimientoModel.Descripcion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTipoMovimientoModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTipoMovimientoModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTipoMovimientoModel.Usuario_modificador == null ? (object)DBNull.Value : aTipoMovimientoModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTipoMovimientoModel.Fecha_modificacion == null ? (object)DBNull.Value : aTipoMovimientoModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoMovimientoModelInsert";

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
        /// Updates a record to the TipoMovimientoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TipoMovimientoModel aTipoMovimientoModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_TipoMovimientoModel", aTipoMovimientoModel.Id_tipomovimiento);
                    command.Parameters.AddWithValue("@Descripcion", aTipoMovimientoModel.Descripcion == null ? (object)DBNull.Value : aTipoMovimientoModel.Descripcion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTipoMovimientoModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTipoMovimientoModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTipoMovimientoModel.Usuario_modificador == null ? (object)DBNull.Value : aTipoMovimientoModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTipoMovimientoModel.Fecha_modificacion == null ? (object)DBNull.Value : aTipoMovimientoModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoMovimientoModelUpdate";

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
        /// Deletes record to the TipoMovimientoModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID_TipoMovimientoModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_TipoMovimientoModel", aID_TipoMovimientoModel);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoMovimientoModelDelete";
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
        /// Selects the Single object of TipoMovimientoModel table.
        /// </summary>
        public TipoMovimientoModel GetTipoMovimientoModel(int aID_TipoMovimientoModel)
        {
            TipoMovimientoModel TipoMovimientoModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID_TipoMovimientoModel", aID_TipoMovimientoModel);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoMovimientoModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_TipoMovimientoModel = (int)(reader["ID_TipoMovimientoModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            TipoMovimientoModel = new TipoMovimientoModel
                            {
                                Id_tipomovimiento = ID_TipoMovimientoModel,
                                Descripcion = Descripcion,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            };
                        }
                    }
                }

                return TipoMovimientoModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TipoMovimientoModel table.
        /// </summary>
        public List<TipoMovimientoModel> TipoMovimientoModelSelectAll()
        {

            List<TipoMovimientoModel> TipoMovimientoModellist = new List<TipoMovimientoModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoMovimientoModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_TipoMovimientoModel = (int)(reader["ID_TipoMovimientoModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            TipoMovimientoModellist.Add(new TipoMovimientoModel
                            {
                                //Id_TipoMovimientoModel = ID_TipoMovimientoModel,
                                Descripcion = Descripcion,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return TipoMovimientoModellist;
            }
            catch (Exception)
            {
                return TipoMovimientoModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TipoMovimientoModel table by a given criteria.
        /// </summary>
        public List<TipoMovimientoModel> TipoMovimientoModelSelectbyUNKNOW(string aValue)
        {

            List<TipoMovimientoModel> TipoMovimientoModellist = new List<TipoMovimientoModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoMovimientoModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_TipoMovimientoModel = (int)(reader["ID_TipoMovimientoModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            TipoMovimientoModellist.Add(new TipoMovimientoModel
                            {
                                //Id_TipoMovimientoModel = ID_TipoMovimientoModel,
                                Descripcion = Descripcion,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return TipoMovimientoModellist;
            }
            catch (Exception)
            {
                return TipoMovimientoModellist;
            }
        }
        #endregion

    }

}
