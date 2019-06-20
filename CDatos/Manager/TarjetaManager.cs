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
    public class ManagerTarjetasModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the TarjetasModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(TarjetasModel aTarjetasModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aTarjetasModel.Numero);
                    command.Parameters.AddWithValue("@Password", aTarjetasModel.Password == null ? (object)DBNull.Value : aTarjetasModel.Password);
                    command.Parameters.AddWithValue("@CodControl", aTarjetasModel.Codcontrol);
                    command.Parameters.AddWithValue("@FechaVencimiento", aTarjetasModel.Fechavencimiento == null ? (object)DBNull.Value : aTarjetasModel.Fechavencimiento);
                    command.Parameters.AddWithValue("@FechaVinculacion", aTarjetasModel.Fechavinculacion);
                    command.Parameters.AddWithValue("@Estado", aTarjetasModel.Estado);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTarjetasModel.Fecha_modificacion == null ? (object)DBNull.Value : aTarjetasModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTarjetasModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTarjetasModel.Usuario_modificador == null ? (object)DBNull.Value : aTarjetasModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTarjetasModel.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TarjetasModelInsert";

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
        /// Updates a record to the TarjetasModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(TarjetasModel aTarjetasModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Numero", aTarjetasModel.Numero);
                    command.Parameters.AddWithValue("@Password", aTarjetasModel.Password == null ? (object)DBNull.Value : aTarjetasModel.Password);
                    command.Parameters.AddWithValue("@CodControl", aTarjetasModel.Codcontrol);
                    command.Parameters.AddWithValue("@FechaVencimiento", aTarjetasModel.Fechavencimiento == null ? (object)DBNull.Value : aTarjetasModel.Fechavencimiento);
                    command.Parameters.AddWithValue("@FechaVinculacion", aTarjetasModel.Fechavinculacion);
                    command.Parameters.AddWithValue("@Estado", aTarjetasModel.Estado);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aTarjetasModel.Fecha_modificacion == null ? (object)DBNull.Value : aTarjetasModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aTarjetasModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aTarjetasModel.Usuario_modificador == null ? (object)DBNull.Value : aTarjetasModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aTarjetasModel.Fecha_creacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TarjetasModelUpdate";

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
        /// Deletes record to the TarjetasModel table.
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
                    command.CommandText = "TarjetasModelDelete";
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
        /// Selects the Single object of TarjetasModel table.
        /// </summary>
        public TarjetasModel GetTarjetasModel(int aNumero)
        {
            TarjetasModel TarjetasModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Numero", aNumero);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TarjetasModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            short? Password = reader["Password"] as short?;
                            byte CodControl = (byte)(reader["CodControl"]);
                            DateTime? FechaVencimiento = reader["FechaVencimiento"] as DateTime?;
                            DateTime FechaVinculacion = (DateTime)(reader["FechaVinculacion"]);
                            bool Estado = (bool)(reader["Estado"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            int USUARIO_CREADOR = (int)(reader["USUARIO_CREADOR"]);
                            int? USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            TarjetasModel = new TarjetasModel
                            {
                                Numero = Numero,
                                Password = Password,
                                Codcontrol = CodControl,
                                Fechavencimiento = FechaVencimiento,
                                Fechavinculacion = FechaVinculacion,
                                Estado = Estado,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            };
                        }
                    }
                }

                return TarjetasModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of TarjetasModel table.
        /// </summary>
        public List<TarjetasModel> TarjetasModelSelectAll()
        {

            List<TarjetasModel> TarjetasModellist = new List<TarjetasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TarjetasModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            short? Password = reader["Password"] as short?;
                            byte CodControl = (byte)(reader["CodControl"]);
                            DateTime? FechaVencimiento = reader["FechaVencimiento"] as DateTime?;
                            DateTime FechaVinculacion = (DateTime)(reader["FechaVinculacion"]);
                            bool Estado = (bool)(reader["Estado"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            int USUARIO_CREADOR = (int)(reader["USUARIO_CREADOR"]);
                            int? USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            TarjetasModellist.Add(new TarjetasModel
                            {
                                Numero = Numero,
                                Password = Password,
                                Codcontrol = CodControl,
                                Fechavencimiento = FechaVencimiento,
                                Fechavinculacion = FechaVinculacion,
                                Estado = Estado,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return TarjetasModellist;
            }
            catch (Exception)
            {
                return TarjetasModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of TarjetasModel table by a given criteria.
        /// </summary>
        public List<TarjetasModel> TarjetasModelSelectbyUNKNOW(string aValue)
        {

            List<TarjetasModel> TarjetasModellist = new List<TarjetasModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TarjetasModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Numero = (int)(reader["Numero"]);
                            short? Password = reader["Password"] as short?;
                            byte CodControl = (byte)(reader["CodControl"]);
                            DateTime? FechaVencimiento = reader["FechaVencimiento"] as DateTime?;
                            DateTime FechaVinculacion = (DateTime)(reader["FechaVinculacion"]);
                            bool Estado = (bool)(reader["Estado"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            int USUARIO_CREADOR = (int)(reader["USUARIO_CREADOR"]);
                            int? USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as int?;
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);

                            TarjetasModellist.Add(new TarjetasModel
                            {
                                Numero = Numero,
                                Password = Password,
                                Codcontrol = CodControl,
                                Fechavencimiento = FechaVencimiento,
                                Fechavinculacion = FechaVinculacion,
                                Estado = Estado,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_creacion = FECHA_CREACION,

                            });
                        }
                    }
                }

                return TarjetasModellist;
            }
            catch (Exception)
            {
                return TarjetasModellist;
            }
        }
        #endregion

    }

}
