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
    public class ManagerCuentasModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the CuentasModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(CuentasModel aCuentasModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                   // command.Parameters.AddWithValue("@NroCuentasModel", aCuentasModel.NroCuentasModel);
                    command.Parameters.AddWithValue("@Estado", aCuentasModel.Estado);
                    command.Parameters.AddWithValue("@SaldoContable", aCuentasModel.Saldocontable);
                    command.Parameters.AddWithValue("@SaldoDisponible", aCuentasModel.Saldodisponible);
                    command.Parameters.AddWithValue("@SobreGiro", aCuentasModel.Sobregiro);
                    //command.Parameters.AddWithValue("@TipoCuentasModel", aCuentasModel.TipoCuentasModel);
                    command.Parameters.AddWithValue("@TipoMoneda", aCuentasModel.Tipomoneda);
                    command.Parameters.AddWithValue("@Id_Tarjeta", aCuentasModel.Id_tarjeta == null ? (object)DBNull.Value : aCuentasModel.Id_tarjeta);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCuentasModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Cliente", aCuentasModel.Cliente);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCuentasModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCuentasModel.Fecha_modificacion == null ? (object)DBNull.Value : aCuentasModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCuentasModel.Usuario_modificador == null ? (object)DBNull.Value : aCuentasModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CuentasModelInsert";

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
        /// Updates a record to the CuentasModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(CuentasModel aCuentasModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    //command.Parameters.AddWithValue("@NroCuentasModel", aCuentasModel.NroCuentasModel);
                    command.Parameters.AddWithValue("@Estado", aCuentasModel.Estado);
                    command.Parameters.AddWithValue("@SaldoContable", aCuentasModel.Saldocontable);
                    command.Parameters.AddWithValue("@SaldoDisponible", aCuentasModel.Saldodisponible);
                    command.Parameters.AddWithValue("@SobreGiro", aCuentasModel.Sobregiro);
                    //command.Parameters.AddWithValue("@TipoCuentasModel", aCuentasModel.TipoCuentasModel);
                    command.Parameters.AddWithValue("@TipoMoneda", aCuentasModel.Tipomoneda);
                    command.Parameters.AddWithValue("@Id_Tarjeta", aCuentasModel.Id_tarjeta == null ? (object)DBNull.Value : aCuentasModel.Id_tarjeta);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCuentasModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Cliente", aCuentasModel.Cliente);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCuentasModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCuentasModel.Fecha_modificacion == null ? (object)DBNull.Value : aCuentasModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCuentasModel.Usuario_modificador == null ? (object)DBNull.Value : aCuentasModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CuentasModelUpdate";

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
        /// Deletes record to the CuentasModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(string aNroCuentasModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@NroCuentasModel", aNroCuentasModel);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "CuentasModelDelete";
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
        /// Selects the Single object of CuentasModel table.
        /// </summary>
        public CuentasModel GetCuentasModel(string aNroCuentasModel)
        {
            CuentasModel CuentasModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@NroCuentasModel", aNroCuentasModel);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuentasModel = (string)(reader["NroCuentasModel"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal SobreGiro = (decimal)(reader["SobreGiro"]);
                            string TipoCuentasModel = (string)(reader["TipoCuentasModel"]);
                            short TipoMoneda = (short)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            CuentasModel = new CuentasModel
                            {
                               // NroCuentasModel = NroCuentasModel,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                //TipoCuentasModel = TipoCuentasModel,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return CuentasModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of CuentasModel table.
        /// </summary>
        public List<CuentasModel> CuentasModelSelectAll()
        {

            List<CuentasModel> CuentasModellist = new List<CuentasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuentasModel = (string)(reader["NroCuentasModel"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal SobreGiro = (decimal)(reader["SobreGiro"]);
                            string TipoCuentasModel = (string)(reader["TipoCuentasModel"]);
                            short TipoMoneda = (short)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            CuentasModellist.Add(new CuentasModel
                            {
                                //NroCuentasModel = NroCuentasModel,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                //TipoCuentasModel = TipoCuentasModel,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return CuentasModellist;
            }
            catch (Exception)
            {
                return CuentasModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of CuentasModel table by a given criteria.
        /// </summary>
        public List<CuentasModel> CuentasModelSelectbyUNKNOW(string aValue)
        {

            List<CuentasModel> CuentasModellist = new List<CuentasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "CuentasModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string NroCuentasModel = (string)(reader["NroCuentasModel"]);
                            bool Estado = (bool)(reader["Estado"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            decimal SobreGiro = (decimal)(reader["SobreGiro"]);
                            string TipoCuentasModel = (string)(reader["TipoCuentasModel"]);
                            short TipoMoneda = (short)(reader["TipoMoneda"]);
                            int? Id_Tarjeta = reader["Id_Tarjeta"] as int?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            int Cliente = (int)(reader["Cliente"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            CuentasModellist.Add(new CuentasModel
                            {
                                //NroCuentasModel = NroCuentasModel,
                                Estado = Estado,
                                Saldocontable = SaldoContable,
                                Saldodisponible = SaldoDisponible,
                                Sobregiro = SobreGiro,
                                //TipoCuentasModel = TipoCuentasModel,
                                Tipomoneda = TipoMoneda,
                                Id_tarjeta = Id_Tarjeta,
                                Usuario_creador = USUARIO_CREADOR,
                                Cliente = Cliente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return CuentasModellist;
            }
            catch (Exception)
            {
                return CuentasModellist;
            }
        }
        #endregion

    }

}
