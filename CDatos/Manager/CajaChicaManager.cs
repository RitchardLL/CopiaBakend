using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class ManagerCajaChicaModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(Caja_ChicaModel aCaja_ChicaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aCaja_ChicaModel.Id);
                    command.Parameters.AddWithValue("@Tipo", aCaja_ChicaModel.Tipo);
                    command.Parameters.AddWithValue("@Monto", aCaja_ChicaModel.Monto);
                    command.Parameters.AddWithValue("@ID_Persona", aCaja_ChicaModel.Id_persona);
                    command.Parameters.AddWithValue("@Hora", aCaja_ChicaModel.Hora);
                    command.Parameters.AddWithValue("@Fecha", aCaja_ChicaModel.Fecha);
                    command.Parameters.AddWithValue("@ID_Ventanilla", aCaja_ChicaModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCaja_ChicaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCaja_ChicaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCaja_ChicaModel.Usuario_modificador == null ? (object)DBNull.Value : aCaja_ChicaModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCaja_ChicaModel.Fecha_modificacion == null ? (object)DBNull.Value : aCaja_ChicaModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Caja_ChicaModelInsert";

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
        /// Updates a record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(Caja_ChicaModel aCaja_ChicaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aCaja_ChicaModel.Id);
                    command.Parameters.AddWithValue("@Tipo", aCaja_ChicaModel.Tipo);
                    command.Parameters.AddWithValue("@Monto", aCaja_ChicaModel.Monto);
                    command.Parameters.AddWithValue("@ID_Persona", aCaja_ChicaModel.Id_persona);
                    command.Parameters.AddWithValue("@Hora", aCaja_ChicaModel.Hora);
                    command.Parameters.AddWithValue("@Fecha", aCaja_ChicaModel.Fecha);
                    command.Parameters.AddWithValue("@ID_Ventanilla", aCaja_ChicaModel.Id_ventanilla);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCaja_ChicaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCaja_ChicaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCaja_ChicaModel.Usuario_modificador == null ? (object)DBNull.Value : aCaja_ChicaModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCaja_ChicaModel.Fecha_modificacion == null ? (object)DBNull.Value : aCaja_ChicaModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "Caja_ChicaModelUpdate";

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
        /// Deletes record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>

        /// <summary>
        /// Selects the Single object of Caja_ChicaModel table.
        /// </summary>

        /// <summary>
        /// Selects all the objects of Caja_ChicaModel table.
        /// </summary>
        public List<Caja_ChicaModel> Caja_ChicaModelSelectAll()
        {

            List<Caja_ChicaModel> Caja_ChicaModellist = new List<Caja_ChicaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "Caja_ChicaModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo = (string)(reader["Tipo"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int ID_Persona = (int)(reader["ID_Persona"]);
                            TimeSpan Hora = (TimeSpan)(reader["Hora"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            Caja_ChicaModellist.Add(new Caja_ChicaModel
                            {
                                Id = ID,
                                Tipo = Tipo,
                                Monto = Monto,
                                Id_persona = ID_Persona,
                                Hora = Hora,
                                Fecha = Fecha,
                                Id_ventanilla = ID_Ventanilla,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return Caja_ChicaModellist;
            }
            catch (Exception)
            {
                return Caja_ChicaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of Caja_ChicaModel table by a given criteria.
        /// </summary>
        public List<Caja_ChicaModel> Caja_ChicaModelSelectbyUNKNOW(string aValue)
        {

            List<Caja_ChicaModel> Caja_ChicaModellist = new List<Caja_ChicaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "Caja_ChicaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo = (string)(reader["Tipo"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int ID_Persona = (int)(reader["ID_Persona"]);
                            TimeSpan Hora = (TimeSpan)(reader["Hora"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            int ID_Ventanilla = (int)(reader["ID_Ventanilla"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            Caja_ChicaModellist.Add(new Caja_ChicaModel
                            {
                                Id = ID,
                                Tipo = Tipo,
                                Monto = Monto,
                                Id_persona = ID_Persona,
                                Hora = Hora,
                                Fecha = Fecha,
                                Id_ventanilla = ID_Ventanilla,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return Caja_ChicaModellist;
            }
            catch (Exception)
            {
                return Caja_ChicaModellist;
            }
        }
        #endregion

    }

}
