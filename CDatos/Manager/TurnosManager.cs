using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerTurnosModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TurnosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TurnosModel aTurnosModel)
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
                    command.Parameters.AddWithValue("@Descripcion", aTurnosModel.Descripcion);
                    command.Parameters.AddWithValue("@Hora_Inicio", aTurnosModel.Hora_inicio == null ? (object)DBNull.Value : aTurnosModel.Hora_inicio);
                    command.Parameters.AddWithValue("@Hora_Fin", aTurnosModel.Hora_fin == null ? (object)DBNull.Value : aTurnosModel.Hora_fin);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTurnosModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTurnosModel.Usuario_creador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_Turnos";

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
        /// Updates a record to the TurnosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TurnosModel aTurnosModel)
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
                    command.Parameters.AddWithValue("@Id", aTurnosModel.Id);
                    command.Parameters.AddWithValue("@Descripcion", aTurnosModel.Descripcion);
                    command.Parameters.AddWithValue("@Hora_Inicio", aTurnosModel.Hora_inicio == null ? (object)DBNull.Value : aTurnosModel.Hora_inicio);
                    command.Parameters.AddWithValue("@Hora_Fin", aTurnosModel.Hora_fin == null ? (object)DBNull.Value : aTurnosModel.Hora_fin);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTurnosModel.Fecha_modificacion == null ? (object)DBNull.Value : aTurnosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTurnosModel.Usuario_modificador == null ? (object)DBNull.Value : aTurnosModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_Turnos";

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
        /// Deletes record to the TurnosModel table.
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
                    command.CommandText = "sp_Turnos";
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
        /// Selects the Single object of TurnosModel table.
        /// </summary>
        public TurnosModel GetTurnosModel(int aId)
        {
            TurnosModel TurnosModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_Turnos";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            TimeSpan? Hora_Inicio = reader["Hora_Inicio"] as TimeSpan?;
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TurnosModel = new TurnosModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Hora_inicio = Hora_Inicio,
                                Hora_fin = Hora_Fin,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return TurnosModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TurnosModel table.
        /// </summary>
        public List<TurnosModel> TurnosModelSelectAll()
        {

            List<TurnosModel> TurnosModellist = new List<TurnosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_Turnos";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            TimeSpan? Hora_Inicio = reader["Hora_Inicio"] as TimeSpan?;
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TurnosModellist.Add(new TurnosModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Hora_inicio = Hora_Inicio,
                                Hora_fin = Hora_Fin,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TurnosModellist;
            }
            catch (Exception)
            {
                return TurnosModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TurnosModel table by a given criteria.
        /// </summary>
        public List<TurnosModel> TurnosModelSelectbyUNKNOW(string aValue)
        {

            List<TurnosModel> TurnosModellist = new List<TurnosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TurnosModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            TimeSpan? Hora_Inicio = reader["Hora_Inicio"] as TimeSpan?;
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            TurnosModellist.Add(new TurnosModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,
                                Hora_inicio = Hora_Inicio,
                                Hora_fin = Hora_Fin,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TurnosModellist;
            }
            catch (Exception)
            {
                return TurnosModellist;
            }
        }
        #endregion

    }

}
