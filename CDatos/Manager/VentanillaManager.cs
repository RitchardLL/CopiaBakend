using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerVentanillaModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the VentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(VentanillaModel aVentanillaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Descripcion", aVentanillaModel.Descripcion);
                    command.Parameters.AddWithValue("@IdSucursal", aVentanillaModel.Idsucursal);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aVentanillaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aVentanillaModel.Fecha_modificacion == null ? (object)DBNull.Value : aVentanillaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aVentanillaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aVentanillaModel.Usuario_modificador == null ? (object)DBNull.Value : aVentanillaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "VentanillaModelInsert";

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
        /// Updates a record to the VentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(VentanillaModel aVentanillaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_VentanillaModel", aVentanillaModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@Descripcion", aVentanillaModel.Descripcion);
                    command.Parameters.AddWithValue("@IdSucursal", aVentanillaModel.Idsucursal);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aVentanillaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aVentanillaModel.Fecha_modificacion == null ? (object)DBNull.Value : aVentanillaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aVentanillaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aVentanillaModel.Usuario_modificador == null ? (object)DBNull.Value : aVentanillaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "VentanillaModelUpdate";

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
        /// Deletes record to the VentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID_VentanillaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_VentanillaModel", aID_VentanillaModel);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "VentanillaModelDelete";
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
        /// Selects the Single object of VentanillaModel table.
        /// </summary>
        public VentanillaModel GetVentanillaModel(int aID_VentanillaModel)
        {
            VentanillaModel VentanillaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID_VentanillaModel", aID_VentanillaModel);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "VentanillaModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID_VentanillaModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int IdSucursal = (int)(reader["IdSucursal"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            VentanillaModel = new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion,
                                Idsucursal = IdSucursal,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return VentanillaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of VentanillaModel table.
        /// </summary>
        public List<VentanillaModel> VentanillaModelSelectAll()
        {

            List<VentanillaModel> VentanillaModellist = new List<VentanillaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "VentanillaModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID_VentanillaModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int IdSucursal = (int)(reader["IdSucursal"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            VentanillaModellist.Add(new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion,
                                Idsucursal = IdSucursal,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return VentanillaModellist;
            }
            catch (Exception)
            {
                return VentanillaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of VentanillaModel table by a given criteria.
        /// </summary>
        public List<VentanillaModel> VentanillaModelSelectbyUNKNOW(string aValue)
        {

            List<VentanillaModel> VentanillaModellist = new List<VentanillaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "VentanillaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_VentanillaModel = (int)(reader["ID_VentanillaModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int IdSucursal = (int)(reader["IdSucursal"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            VentanillaModellist.Add(new VentanillaModel
                            {
                                Id_ventanilla = ID_VentanillaModel,
                                Descripcion = Descripcion,
                                Idsucursal = IdSucursal,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return VentanillaModellist;
            }
            catch (Exception)
            {
                return VentanillaModellist;
            }
        }
        #endregion

    }

}
