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
    public class ManagerChequerasModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the ChequerasModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(ChequerasModel aChequerasModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aChequerasModel.Numero);
                    command.Parameters.AddWithValue("@Estado", aChequerasModel.Estado);
                    command.Parameters.AddWithValue("@FechaRegistro", aChequerasModel.Fecharegistro == null ? (object)DBNull.Value : aChequerasModel.Fecharegistro);
                    command.Parameters.AddWithValue("@Inicio", aChequerasModel.Inicio);
                    command.Parameters.AddWithValue("@Fin", aChequerasModel.Fin);
                    command.Parameters.AddWithValue("@Id_Cuenta", aChequerasModel.Id_cuenta == null ? (object)DBNull.Value : aChequerasModel.Id_cuenta);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aChequerasModel.Fecha_modificacion == null ? (object)DBNull.Value : aChequerasModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aChequerasModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aChequerasModel.Usuario_modificador == null ? (object)DBNull.Value : aChequerasModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aChequerasModel.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ChequerasModelInsert";

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
        /// Updates a record to the ChequerasModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(ChequerasModel aChequerasModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aChequerasModel.Numero);
                    command.Parameters.AddWithValue("@Estado", aChequerasModel.Estado);
                    command.Parameters.AddWithValue("@FechaRegistro", aChequerasModel.Fecharegistro == null ? (object)DBNull.Value : aChequerasModel.Fecharegistro);
                    command.Parameters.AddWithValue("@Inicio", aChequerasModel.Inicio);
                    command.Parameters.AddWithValue("@Fin", aChequerasModel.Fin);
                    command.Parameters.AddWithValue("@Id_Cuenta", aChequerasModel.Id_cuenta == null ? (object)DBNull.Value : aChequerasModel.Id_cuenta);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aChequerasModel.Fecha_modificacion == null ? (object)DBNull.Value : aChequerasModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aChequerasModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aChequerasModel.Usuario_modificador == null ? (object)DBNull.Value : aChequerasModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aChequerasModel.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ChequerasModelUpdate";

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
        /// Deletes record to the ChequerasModel table.
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
                    command.CommandText = "ChequerasModelDelete";
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
        /// Selects the Single object of ChequerasModel table.
        /// </summary>
        public ChequerasModel GetChequerasModel(int aNumero)
        {
            ChequerasModel ChequerasModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Numero", aNumero);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequerasModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime? FechaRegistro = reader["FechaRegistro"] as DateTime?;
                            byte Inicio = (byte)(reader["Inicio"]);
                            byte Fin = (byte)(reader["Fin"]);
                            string Id_Cuenta = (string)(reader["Id_Cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            ChequerasModel = new ChequerasModel
                            {
                                Numero = Numero,
                                Estado = Estado,
                                Fecharegistro = FechaRegistro,
                                Inicio = Inicio,
                                Fin = Fin,
                                Id_cuenta = Id_Cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            };
                        }
                    }
                }

                return ChequerasModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of ChequerasModel table.
        /// </summary>
        public List<ChequerasModel> ChequerasModelSelectAll()
        {

            List<ChequerasModel> ChequerasModellist = new List<ChequerasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequerasModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime? FechaRegistro = reader["FechaRegistro"] as DateTime?;
                            byte Inicio = (byte)(reader["Inicio"]);
                            byte Fin = (byte)(reader["Fin"]);
                            string Id_Cuenta = (string)(reader["Id_Cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            ChequerasModellist.Add(new ChequerasModel
                            {
                                Numero = Numero,
                                Estado = Estado,
                                Fecharegistro = FechaRegistro,
                                Inicio = Inicio,
                                Fin = Fin,
                                Id_cuenta = Id_Cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return ChequerasModellist;
            }
            catch (Exception)
            {
                return ChequerasModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of ChequerasModel table by a given criteria.
        /// </summary>
        public List<ChequerasModel> ChequerasModelSelectbyUNKNOW(string aValue)
        {

            List<ChequerasModel> ChequerasModellist = new List<ChequerasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ChequerasModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            string Estado = (string)(reader["Estado"]);
                            DateTime? FechaRegistro = reader["FechaRegistro"] as DateTime?;
                            byte Inicio = (byte)(reader["Inicio"]);
                            byte Fin = (byte)(reader["Fin"]);
                            string Id_Cuenta = (string)(reader["Id_Cuenta"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            ChequerasModellist.Add(new ChequerasModel
                            {
                                Numero = Numero,
                                Estado = Estado,
                                Fecharegistro = FechaRegistro,
                                Inicio = Inicio,
                                Fin = Fin,
                                Id_cuenta = Id_Cuenta,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return ChequerasModellist;
            }
            catch (Exception)
            {
                return ChequerasModellist;
            }
        }
        #endregion

    }

}
