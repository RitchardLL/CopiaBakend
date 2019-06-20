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
    public class ManagerCobroChequesModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the CobroChequesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(CobroChequesModel aCobroChequesModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_Cheque", aCobroChequesModel.Id_cheque);
                    command.Parameters.AddWithValue("@Monto", aCobroChequesModel.Monto);
                    command.Parameters.AddWithValue("@Estado_Cheque", aCobroChequesModel.Estado_cheque);
                    command.Parameters.AddWithValue("@ID_Movimiento", aCobroChequesModel.Id_movimiento);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCobroChequesModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCobroChequesModel.Fecha_modificacion == null ? (object)DBNull.Value : aCobroChequesModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCobroChequesModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCobroChequesModel.Usuario_modificador == null ? (object)DBNull.Value : aCobroChequesModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CobroChequesModelInsert";

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
        /// Updates a record to the CobroChequesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(CobroChequesModel aCobroChequesModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_Cheque", aCobroChequesModel.Id_cheque);
                    command.Parameters.AddWithValue("@Monto", aCobroChequesModel.Monto);
                    command.Parameters.AddWithValue("@Estado_Cheque", aCobroChequesModel.Estado_cheque);
                    command.Parameters.AddWithValue("@ID_Movimiento", aCobroChequesModel.Id_movimiento);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCobroChequesModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCobroChequesModel.Fecha_modificacion == null ? (object)DBNull.Value : aCobroChequesModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCobroChequesModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCobroChequesModel.Usuario_modificador == null ? (object)DBNull.Value : aCobroChequesModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CobroChequesModelUpdate";

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
        /// Deletes record to the CobroChequesModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID_Cheque, int aID_Movimiento)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_Cheque", aID_Cheque);
                    command.Parameters.AddWithValue("@ID_Movimiento", aID_Movimiento);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CobroChequesModelDelete";
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
        /// Selects the Single object of CobroChequesModel table.
        /// </summary>
        public CobroChequesModel GetCobroChequesModel(int aID_Cheque, int aID_Movimiento)
        {
            CobroChequesModel CobroChequesModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID_Cheque", aID_Cheque);
                    command.Parameters.AddWithValue("@ID_Movimiento", aID_Movimiento);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CobroChequesModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_Cheque = (int)(reader["ID_Cheque"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            bool Estado_Cheque = (bool)(reader["Estado_Cheque"]);
                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            CobroChequesModel = new CobroChequesModel
                            {
                                Id_cheque = ID_Cheque,
                                Monto = Monto,
                                Estado_cheque = Estado_Cheque,
                                Id_movimiento = ID_Movimiento,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return CobroChequesModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of CobroChequesModel table.
        /// </summary>
        public List<CobroChequesModel> CobroChequesModelSelectAll()
        {

            List<CobroChequesModel> CobroChequesModellist = new List<CobroChequesModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CobroChequesModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_Cheque = (int)(reader["ID_Cheque"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            bool Estado_Cheque = (bool)(reader["Estado_Cheque"]);
                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            CobroChequesModellist.Add(new CobroChequesModel
                            {
                                Id_cheque = ID_Cheque,
                                Monto = Monto,
                                Estado_cheque = Estado_Cheque,
                                Id_movimiento = ID_Movimiento,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return CobroChequesModellist;
            }
            catch (Exception)
            {
                return CobroChequesModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of CobroChequesModel table by a given criteria.
        /// </summary>
        public List<CobroChequesModel> CobroChequesModelSelectbyUNKNOW(string aValue)
        {

            List<CobroChequesModel> CobroChequesModellist = new List<CobroChequesModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CobroChequesModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_Cheque = (int)(reader["ID_Cheque"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            bool Estado_Cheque = (bool)(reader["Estado_Cheque"]);
                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            CobroChequesModellist.Add(new CobroChequesModel
                            {
                                Id_cheque = ID_Cheque,
                                Monto = Monto,
                                Estado_cheque = Estado_Cheque,
                                Id_movimiento = ID_Movimiento,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return CobroChequesModellist;
            }
            catch (Exception)
            {
                return CobroChequesModellist;
            }
        }
        #endregion

    }

}
