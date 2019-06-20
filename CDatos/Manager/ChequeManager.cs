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
    public class ManagerChequesModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the ChequesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(ChequesModel aChequesModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aChequesModel.Numero);
                    command.Parameters.AddWithValue("@FechaEmision", aChequesModel.Fechaemision);
                    command.Parameters.AddWithValue("@FechaCobro", aChequesModel.Fechacobro == null ? (object)DBNull.Value : aChequesModel.Fechacobro);
                    command.Parameters.AddWithValue("@Destinatario", aChequesModel.Destinatario);
                    command.Parameters.AddWithValue("@Monto", aChequesModel.Monto);
                   // command.Parameters.AddWithValue("@IDChequesModelra", aChequesModel.IdChequesModelra);
                    command.Parameters.AddWithValue("@Estado", aChequesModel.Estado);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aChequesModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aChequesModel.Fecha_modificacion == null ? (object)DBNull.Value : aChequesModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREACION", aChequesModel.Usuario_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aChequesModel.Usuario_modificador == null ? (object)DBNull.Value : aChequesModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ChequesModelInsert";

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
        /// Updates a record to the ChequesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(ChequesModel aChequesModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aChequesModel.Numero);
                    command.Parameters.AddWithValue("@FechaEmision", aChequesModel.Fechaemision);
                    command.Parameters.AddWithValue("@FechaCobro", aChequesModel.Fechacobro == null ? (object)DBNull.Value : aChequesModel.Fechacobro);
                    command.Parameters.AddWithValue("@Destinatario", aChequesModel.Destinatario);
                    command.Parameters.AddWithValue("@Monto", aChequesModel.Monto);
                   // command.Parameters.AddWithValue("@IDChequesModelra", aChequesModel.IdChequesModelra);
                    command.Parameters.AddWithValue("@Estado", aChequesModel.Estado);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aChequesModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aChequesModel.Fecha_modificacion == null ? (object)DBNull.Value : aChequesModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREACION", aChequesModel.Usuario_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aChequesModel.Usuario_modificador == null ? (object)DBNull.Value : aChequesModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ChequesModelUpdate";

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
        /// Deletes record to the ChequesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aNumero)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aNumero);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ChequesModelDelete";
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
        /// Selects the Single object of ChequesModel table.
        /// </summary>
        public ChequesModel GetChequesModel(int aNumero)
        {
            ChequesModel ChequesModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Numero", aNumero);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequesModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            DateTime FechaEmision = (DateTime)(reader["FechaEmision"]);
                            DateTime? FechaCobro = reader["FechaCobro"] as DateTime?;
                            string Destinatario = (string)(reader["Destinatario"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int IDChequesModelra = (int)(reader["IDChequesModelra"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREACION = (string)(reader["USUARIO_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            ChequesModel = new ChequesModel
                            {
                                Numero = Numero,
                                Fechaemision = FechaEmision,
                                Fechacobro = FechaCobro,
                                Destinatario = Destinatario,
                                Monto = Monto,
                              //  IdChequesModelra = IDChequesModelra,
                                Estado = Estado,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creacion = USUARIO_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return ChequesModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of ChequesModel table.
        /// </summary>
        public List<ChequesModel> ChequesModelSelectAll()
        {

            List<ChequesModel> ChequesModellist = new List<ChequesModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequesModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            DateTime FechaEmision = (DateTime)(reader["FechaEmision"]);
                            DateTime? FechaCobro = reader["FechaCobro"] as DateTime?;
                            string Destinatario = (string)(reader["Destinatario"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int IDChequesModelra = (int)(reader["IDChequesModelra"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREACION = (string)(reader["USUARIO_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            ChequesModellist.Add(new ChequesModel
                            {
                                Numero = Numero,
                                Fechaemision = FechaEmision,
                                Fechacobro = FechaCobro,
                                Destinatario = Destinatario,
                                Monto = Monto,
                            //    IdChequesModelra = IDChequesModelra,
                                Estado = Estado,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creacion = USUARIO_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return ChequesModellist;
            }
            catch (Exception)
            {
                return ChequesModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of ChequesModel table by a given criteria.
        /// </summary>
        public List<ChequesModel> ChequesModelSelectbyUNKNOW(string aValue)
        {

            List<ChequesModel> ChequesModellist = new List<ChequesModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequesModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            DateTime FechaEmision = (DateTime)(reader["FechaEmision"]);
                            DateTime? FechaCobro = reader["FechaCobro"] as DateTime?;
                            string Destinatario = (string)(reader["Destinatario"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int IDChequesModelra = (int)(reader["IDChequesModelra"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREACION = (string)(reader["USUARIO_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            ChequesModellist.Add(new ChequesModel
                            {
                                Numero = Numero,
                                Fechaemision = FechaEmision,
                                Fechacobro = FechaCobro,
                                Destinatario = Destinatario,
                                Monto = Monto,
                                //IdChequesModelra = IDChequesModelra,
                                Estado = Estado,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creacion = USUARIO_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return ChequesModellist;
            }
            catch (Exception)
            {
                return ChequesModellist;
            }
        }
        #endregion

    }

}
