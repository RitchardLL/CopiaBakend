using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerTurnoUsuarioModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TurnoUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TurnoUsuarioModel aTurnoUsuarioModel)
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
                    command.Parameters.AddWithValue("@Fecha", aTurnoUsuarioModel.Fecha);
                    command.Parameters.AddWithValue("@HoraInicio", aTurnoUsuarioModel.Horainicio);
                    command.Parameters.AddWithValue("@HoraFin", aTurnoUsuarioModel.Horafin);
                    command.Parameters.AddWithValue("@ID_Usuario", aTurnoUsuarioModel.Id_usuario);
                    command.Parameters.AddWithValue("@ID_Ventanilla", aTurnoUsuarioModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@ID_Horarios_Atencion", aTurnoUsuarioModel.Id_horarios_atencion);
                    command.Parameters.AddWithValue("@ID_Turnos", aTurnoUsuarioModel.Id_turnos == null ? (object)DBNull.Value : aTurnoUsuarioModel.Id_turnos);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTurnoUsuarioModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTurnoUsuarioModel.Usuario_creador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spTurnoUsuario";

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
        /// Updates a record to the TurnoUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TurnoUsuarioModel aTurnoUsuarioModel)
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
                    command.Parameters.AddWithValue("@ID", aTurnoUsuarioModel.Id);
                    command.Parameters.AddWithValue("@Fecha", aTurnoUsuarioModel.Fecha);
                    command.Parameters.AddWithValue("@HoraInicio", aTurnoUsuarioModel.Horainicio);
                    command.Parameters.AddWithValue("@HoraFin", aTurnoUsuarioModel.Horafin);
                    command.Parameters.AddWithValue("@ID_Usuario", aTurnoUsuarioModel.Id_usuario);
                    command.Parameters.AddWithValue("@ID_Ventanilla", aTurnoUsuarioModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@ID_Horarios_Atencion", aTurnoUsuarioModel.Id_horarios_atencion);
                    command.Parameters.AddWithValue("@ID_Turnos", aTurnoUsuarioModel.Id_turnos == null ? (object)DBNull.Value : aTurnoUsuarioModel.Id_turnos);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTurnoUsuarioModel.Fecha_modificacion == null ? (object)DBNull.Value : aTurnoUsuarioModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTurnoUsuarioModel.Usuario_modificador == null ? (object)DBNull.Value : aTurnoUsuarioModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spTurnoUsuario";

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
        /// Deletes record to the TurnoUsuarioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID)
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
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "spTurnoUsuario";
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
        /// Selects the Single object of TurnoUsuarioModel table.
        /// </summary>
        public TurnoUsuarioModel GetTurnoUsuarioModel(int aID)
        {
            TurnoUsuarioModel TurnoUsuarioModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spTurnoUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            TimeSpan HoraInicio = (TimeSpan)(reader["HoraInicio"]);
                            TimeSpan HoraFin = (TimeSpan)(reader["HoraFin"]);
                            int ID_Usuario = (int)(reader["ID_Usuario"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            int ID_Horarios_Atencion = (int)(reader["ID_Horarios_Atencion"]);
                            int? ID_Turnos = reader["ID_Turnos"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TurnoUsuarioModel = new TurnoUsuarioModel
                            {
                                Id = ID,
                                Fecha = Fecha,
                                Horainicio = HoraInicio,
                                Horafin = HoraFin,
                                Id_usuario = ID_Usuario,
                                Id_ventanilla = ID_Ventanilla,
                                Id_horarios_atencion = ID_Horarios_Atencion,
                                Id_turnos = ID_Turnos,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return TurnoUsuarioModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TurnoUsuarioModel table.
        /// </summary>
        public List<TurnoUsuarioModel> TurnoUsuarioModelSelectAll()
        {

            List<TurnoUsuarioModel> TurnoUsuarioModellist = new List<TurnoUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TurnoUsuarioModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            TimeSpan HoraInicio = (TimeSpan)(reader["HoraInicio"]);
                            TimeSpan HoraFin = (TimeSpan)(reader["HoraFin"]);
                            int ID_Usuario = (int)(reader["ID_Usuario"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            int ID_Horarios_Atencion = (int)(reader["ID_Horarios_Atencion"]);
                            int? ID_Turnos = reader["ID_Turnos"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            TurnoUsuarioModellist.Add(new TurnoUsuarioModel
                            {
                                Id = ID,
                                Fecha = Fecha,
                                Horainicio = HoraInicio,
                                Horafin = HoraFin,
                                Id_usuario = ID_Usuario,
                                Id_ventanilla = ID_Ventanilla,
                                Id_horarios_atencion = ID_Horarios_Atencion,
                                Id_turnos = ID_Turnos,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TurnoUsuarioModellist;
            }
            catch (Exception)
            {
                return TurnoUsuarioModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TurnoUsuarioModel table by a given criteria.
        /// </summary>
        public List<TurnoUsuarioModel> TurnoUsuarioModelSelectbyUNKNOW(string aValue)
        {

            List<TurnoUsuarioModel> TurnoUsuarioModellist = new List<TurnoUsuarioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TurnoUsuarioModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            TimeSpan HoraInicio = (TimeSpan)(reader["HoraInicio"]);
                            TimeSpan HoraFin = (TimeSpan)(reader["HoraFin"]);
                            int ID_Usuario = (int)(reader["ID_Usuario"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            int ID_Horarios_Atencion = (int)(reader["ID_Horarios_Atencion"]);
                            int? ID_Turnos = reader["ID_Turnos"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            TurnoUsuarioModellist.Add(new TurnoUsuarioModel
                            {
                                Id = ID,
                                Fecha = Fecha,
                                Horainicio = HoraInicio,
                                Horafin = HoraFin,
                                Id_usuario = ID_Usuario,
                                Id_ventanilla = ID_Ventanilla,
                                Id_horarios_atencion = ID_Horarios_Atencion,
                                Id_turnos = ID_Turnos,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return TurnoUsuarioModellist;
            }
            catch (Exception)
            {
                return TurnoUsuarioModellist;
            }
        }
        #endregion

    }

}
