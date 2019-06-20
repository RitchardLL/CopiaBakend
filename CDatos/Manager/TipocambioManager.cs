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
    public class ManagerTipoCambioModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TipoCambioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TipoCambioModel aTipoCambioModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aTipoCambioModel.Id);
                    command.Parameters.AddWithValue("@Fecha", aTipoCambioModel.Fecha);
                    command.Parameters.AddWithValue("@MonedaOrigen", aTipoCambioModel.Monedaorigen);
                    command.Parameters.AddWithValue("@MonedaObjetivo", aTipoCambioModel.Monedaobjetivo);
                    command.Parameters.AddWithValue("@MontoCompra", aTipoCambioModel.Montocompra);
                    command.Parameters.AddWithValue("@MontoVenta", aTipoCambioModel.Montoventa);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTipoCambioModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTipoCambioModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTipoCambioModel.Usuario_modificador == null ? (object)DBNull.Value : aTipoCambioModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTipoCambioModel.Fecha_modificacion == null ? (object)DBNull.Value : aTipoCambioModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoCambioModelInsert";

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
        /// Updates a record to the TipoCambioModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TipoCambioModel aTipoCambioModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aTipoCambioModel.Id);
                    command.Parameters.AddWithValue("@Fecha", aTipoCambioModel.Fecha);
                    command.Parameters.AddWithValue("@MonedaOrigen", aTipoCambioModel.Monedaorigen);
                    command.Parameters.AddWithValue("@MonedaObjetivo", aTipoCambioModel.Monedaobjetivo);
                    command.Parameters.AddWithValue("@MontoCompra", aTipoCambioModel.Montocompra);
                    command.Parameters.AddWithValue("@MontoVenta", aTipoCambioModel.Montoventa);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTipoCambioModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTipoCambioModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTipoCambioModel.Usuario_modificador == null ? (object)DBNull.Value : aTipoCambioModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTipoCambioModel.Fecha_modificacion == null ? (object)DBNull.Value : aTipoCambioModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoCambioModelUpdate";

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
        /// Deletes record to the TipoCambioModel table.
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

                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TipoCambioModelDelete";
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
        /// Selects the Single object of TipoCambioModel table.
        /// </summary>
        public TipoCambioModel GetTipoCambioModel(int aID)
        {
            TipoCambioModel TipoCambioModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoCambioModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            int MonedaOrigen = (int)(reader["MonedaOrigen"]);
                            int MonedaObjetivo = (int)(reader["MonedaObjetivo"]);
                            decimal MontoCompra = (decimal)(reader["MontoCompra"]);
                            decimal MontoVenta = (decimal)(reader["MontoVenta"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            TipoCambioModel = new TipoCambioModel
                            {
                                Id = ID,
                                Fecha = Fecha,
                                Monedaorigen = MonedaOrigen,
                                Monedaobjetivo = MonedaObjetivo,
                                Montocompra = MontoCompra,
                                Montoventa = MontoVenta,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            };
                        }
                    }
                }

                return TipoCambioModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TipoCambioModel table.
        /// </summary>
        public List<TipoCambioModel> TipoCambioModelSelectAll()
        {

            List<TipoCambioModel> TipoCambioModellist = new List<TipoCambioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoCambioModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            int MonedaOrigen = (int)(reader["MonedaOrigen"]);
                            int MonedaObjetivo = (int)(reader["MonedaObjetivo"]);
                            decimal MontoCompra = (decimal)(reader["MontoCompra"]);
                            decimal MontoVenta = (decimal)(reader["MontoVenta"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            TipoCambioModellist.Add(new TipoCambioModel
                            {
                                Id = ID,
                                Fecha = Fecha,
                                Monedaorigen = MonedaOrigen,
                                Monedaobjetivo = MonedaObjetivo,
                                Montocompra = MontoCompra,
                                Montoventa = MontoVenta,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return TipoCambioModellist;
            }
            catch (Exception)
            {
                return TipoCambioModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TipoCambioModel table by a given criteria.
        /// </summary>
        public List<TipoCambioModel> TipoCambioModelSelectbyUNKNOW(string aValue)
        {

            List<TipoCambioModel> TipoCambioModellist = new List<TipoCambioModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TipoCambioModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            int MonedaOrigen = (int)(reader["MonedaOrigen"]);
                            int MonedaObjetivo = (int)(reader["MonedaObjetivo"]);
                            decimal MontoCompra = (decimal)(reader["MontoCompra"]);
                            decimal MontoVenta = (decimal)(reader["MontoVenta"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            TipoCambioModellist.Add(new TipoCambioModel
                            {
                                Id = ID,
                                Fecha = Fecha,
                                Monedaorigen = MonedaOrigen,
                                Monedaobjetivo = MonedaObjetivo,
                                Montocompra = MontoCompra,
                                Montoventa = MontoVenta,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return TipoCambioModellist;
            }
            catch (Exception)
            {
                return TipoCambioModellist;
            }
        }
        #endregion

    }

}
