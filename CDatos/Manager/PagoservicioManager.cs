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
    public class ManagerPagoServiciosModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the PagoServiciosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(PagoServiciosModel aPagoServiciosModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Nro_Contrato", aPagoServiciosModel.Nro_contrato);
                    command.Parameters.AddWithValue("@ID_Movimiento", aPagoServiciosModel.Id_movimiento);
                    command.Parameters.AddWithValue("@FechaPago", aPagoServiciosModel.Fechapago);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aPagoServiciosModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aPagoServiciosModel.Fecha_modificacion == null ? (object)DBNull.Value : aPagoServiciosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aPagoServiciosModel.Usuario_modificador == null ? (object)DBNull.Value : aPagoServiciosModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aPagoServiciosModel.Usuario_creador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PagoServiciosModelInsert";

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
        /// Updates a record to the PagoServiciosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(PagoServiciosModel aPagoServiciosModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Nro_Contrato", aPagoServiciosModel.Nro_contrato);
                    command.Parameters.AddWithValue("@ID_Movimiento", aPagoServiciosModel.Id_movimiento);
                    command.Parameters.AddWithValue("@FechaPago", aPagoServiciosModel.Fechapago);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aPagoServiciosModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aPagoServiciosModel.Fecha_modificacion == null ? (object)DBNull.Value : aPagoServiciosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aPagoServiciosModel.Usuario_modificador == null ? (object)DBNull.Value : aPagoServiciosModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aPagoServiciosModel.Usuario_creador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PagoServiciosModelUpdate";

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
        /// Deletes record to the PagoServiciosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aNro_Contrato, int aID_Movimiento)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Nro_Contrato", aNro_Contrato);
                    command.Parameters.AddWithValue("@ID_Movimiento", aID_Movimiento);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PagoServiciosModelDelete";
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
        /// Selects the Single object of PagoServiciosModel table.
        /// </summary>
        public PagoServiciosModel GetPagoServiciosModel(int aNro_Contrato, int aID_Movimiento)
        {
            PagoServiciosModel PagoServiciosModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Nro_Contrato", aNro_Contrato);
                    command.Parameters.AddWithValue("@ID_Movimiento", aID_Movimiento);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PagoServiciosModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Nro_Contrato = (int)(reader["Nro_Contrato"]);
                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            DateTime FechaPago = (DateTime)(reader["FechaPago"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);

                            PagoServiciosModel = new PagoServiciosModel
                            {
                                Nro_contrato = Nro_Contrato,
                                Id_movimiento = ID_Movimiento,
                                Fechapago = FechaPago,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Usuario_creador = USUARIO_CREADOR,

                            };
                        }
                    }
                }

                return PagoServiciosModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of PagoServiciosModel table.
        /// </summary>
        public List<PagoServiciosModel> PagoServiciosModelSelectAll()
        {

            List<PagoServiciosModel> PagoServiciosModellist = new List<PagoServiciosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PagoServiciosModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Nro_Contrato = (int)(reader["Nro_Contrato"]);
                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            DateTime FechaPago = (DateTime)(reader["FechaPago"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);

                            PagoServiciosModellist.Add(new PagoServiciosModel
                            {
                                Nro_contrato = Nro_Contrato,
                                Id_movimiento = ID_Movimiento,
                                Fechapago = FechaPago,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Usuario_creador = USUARIO_CREADOR,

                            });
                        }
                    }
                }

                return PagoServiciosModellist;
            }
            catch (Exception)
            {
                return PagoServiciosModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of PagoServiciosModel table by a given criteria.
        /// </summary>
        public List<PagoServiciosModel> PagoServiciosModelSelectbyUNKNOW(string aValue)
        {

            List<PagoServiciosModel> PagoServiciosModellist = new List<PagoServiciosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PagoServiciosModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Nro_Contrato = (int)(reader["Nro_Contrato"]);
                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            DateTime FechaPago = (DateTime)(reader["FechaPago"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);

                            PagoServiciosModellist.Add(new PagoServiciosModel
                            {
                                Nro_contrato = Nro_Contrato,
                                Id_movimiento = ID_Movimiento,
                                Fechapago = FechaPago,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Usuario_creador = USUARIO_CREADOR,

                            });
                        }
                    }
                }

                return PagoServiciosModellist;
            }
            catch (Exception)
            {
                return PagoServiciosModellist;
            }
        }
        #endregion

    }

}
