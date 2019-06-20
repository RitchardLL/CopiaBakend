using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerHorarios_AtencionModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the Horarios_AtencionModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(Horarios_AtencionModel aHorarios_AtencionModel)
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
                    command.Parameters.AddWithValue("@Fecha", aHorarios_AtencionModel.Fecha);
                    command.Parameters.AddWithValue("@Hora_Inicio", aHorarios_AtencionModel.Hora_inicio);
                    command.Parameters.AddWithValue("@Hora_Fin", aHorarios_AtencionModel.Hora_fin == null ? (object)DBNull.Value : aHorarios_AtencionModel.Hora_fin);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aHorarios_AtencionModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aHorarios_AtencionModel.Usuario_creador);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spHorarios_atencion";

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
        /// Updates a record to the Horarios_AtencionModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(Horarios_AtencionModel aHorarios_AtencionModel)
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
                    command.Parameters.AddWithValue("@Id", aHorarios_AtencionModel.Id);
                    command.Parameters.AddWithValue("@Fecha", aHorarios_AtencionModel.Fecha);
                    command.Parameters.AddWithValue("@Hora_Inicio", aHorarios_AtencionModel.Hora_inicio);
                    command.Parameters.AddWithValue("@Hora_Fin", aHorarios_AtencionModel.Hora_fin == null ? (object)DBNull.Value : aHorarios_AtencionModel.Hora_fin);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aHorarios_AtencionModel.Fecha_modificacion == null ? (object)DBNull.Value : aHorarios_AtencionModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aHorarios_AtencionModel.Usuario_modificador == null ? (object)DBNull.Value : aHorarios_AtencionModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spHorarios_atencion";

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
        /// Deletes record to the Horarios_AtencionModel table.
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
                    command.CommandText = "spHorarios_atencion";
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
        /// Selects the Single object of Horarios_AtencionModel table.
        /// </summary>
        public Horarios_AtencionModel GetHorarios_AtencionModel(int aId)
        {
            Horarios_AtencionModel Horarios_AtencionModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spHorarios_atencion";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            TimeSpan Hora_Inicio = (TimeSpan)(reader["Hora_Inicio"]);
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            Horarios_AtencionModel = new Horarios_AtencionModel
                            {
                                Id = Id,
                                Fecha = Fecha,
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

                return Horarios_AtencionModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of Horarios_AtencionModel table.
        /// </summary>
        public List<Horarios_AtencionModel> Horarios_AtencionModelSelectAll()
        {

            List<Horarios_AtencionModel> Horarios_AtencionModellist = new List<Horarios_AtencionModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spHorarios_atencion";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            TimeSpan Hora_Inicio = (TimeSpan)(reader["Hora_Inicio"]);
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            Horarios_AtencionModellist.Add(new Horarios_AtencionModel
                            {
                                Id = Id,
                                Fecha = Fecha,
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

                return Horarios_AtencionModellist;
            }
            catch (Exception)
            {
                return Horarios_AtencionModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of Horarios_AtencionModel table by a given criteria.
        /// </summary>
        public List<Horarios_AtencionModel> Horarios_AtencionModelSelectbyUNKNOW(string aValue)
        {

            List<Horarios_AtencionModel> Horarios_AtencionModellist = new List<Horarios_AtencionModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "Horarios_AtencionModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            TimeSpan Hora_Inicio = (TimeSpan)(reader["Hora_Inicio"]);
                            TimeSpan? Hora_Fin = reader["Hora_Fin"] as TimeSpan?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            Horarios_AtencionModellist.Add(new Horarios_AtencionModel
                            {
                                Id = Id,
                                Fecha = Fecha,
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

                return Horarios_AtencionModellist;
            }
            catch (Exception)
            {
                return Horarios_AtencionModellist;
            }
        }
        #endregion

    }

}
