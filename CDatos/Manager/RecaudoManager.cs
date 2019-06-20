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
    public class ManagerRecaudosModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the RecaudosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(RecaudosModel aRecaudosModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Nro_Contrato", aRecaudosModel.Nro_contrato);
                    command.Parameters.AddWithValue("@Monto", aRecaudosModel.Monto);
                    command.Parameters.AddWithValue("@Fecha_Vencimiento", aRecaudosModel.Fecha_vencimiento);
                    //command.Parameters.AddWithValue("@Estado_RecaudosModel", aRecaudosModel.Estado_RecaudosModel);
                    command.Parameters.AddWithValue("@ID_Empresa", aRecaudosModel.Id_empresa);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aRecaudosModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aRecaudosModel.Fecha_modificacion == null ? (object)DBNull.Value : aRecaudosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aRecaudosModel.Usuario_modificador == null ? (object)DBNull.Value : aRecaudosModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aRecaudosModel.Usuario_creador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "RecaudosModelInsert";

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
        /// Updates a record to the RecaudosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(RecaudosModel aRecaudosModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Nro_Contrato", aRecaudosModel.Nro_contrato);
                    command.Parameters.AddWithValue("@Monto", aRecaudosModel.Monto);
                    command.Parameters.AddWithValue("@Fecha_Vencimiento", aRecaudosModel.Fecha_vencimiento);
                    //command.Parameters.AddWithValue("@Estado_RecaudosModel", aRecaudosModel.Estado_RecaudosModel);
                    command.Parameters.AddWithValue("@ID_Empresa", aRecaudosModel.Id_empresa);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aRecaudosModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aRecaudosModel.Fecha_modificacion == null ? (object)DBNull.Value : aRecaudosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aRecaudosModel.Usuario_modificador == null ? (object)DBNull.Value : aRecaudosModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aRecaudosModel.Usuario_creador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "RecaudosModelUpdate";

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
        /// Deletes record to the RecaudosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aNro_Contrato)
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


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "RecaudosModelDelete";
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
        /// Selects the Single object of RecaudosModel table.
        /// </summary>
        public RecaudosModel GetRecaudosModel(int aNro_Contrato)
        {
            RecaudosModel RecaudosModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Nro_Contrato", aNro_Contrato);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "RecaudosModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Nro_Contrato = (int)(reader["Nro_Contrato"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            DateTime Fecha_Vencimiento = (DateTime)(reader["Fecha_Vencimiento"]);
                            bool Estado_RecaudosModel = (bool)(reader["Estado_RecaudosModel"]);
                            int ID_Empresa = (int)(reader["ID_Empresa"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);

                            RecaudosModel = new RecaudosModel
                            {
                                Nro_contrato = Nro_Contrato,
                                Monto = Monto,
                                Fecha_vencimiento = Fecha_Vencimiento,
                                //Estado_RecaudosModel = Estado_RecaudosModel,
                                Id_empresa = ID_Empresa,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Usuario_creador = USUARIO_CREADOR,

                            };
                        }
                    }
                }

                return RecaudosModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of RecaudosModel table.
        /// </summary>
        public List<RecaudosModel> RecaudosModelSelectAll()
        {

            List<RecaudosModel> RecaudosModellist = new List<RecaudosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "RecaudosModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Nro_Contrato = (int)(reader["Nro_Contrato"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            DateTime Fecha_Vencimiento = (DateTime)(reader["Fecha_Vencimiento"]);
                            bool Estado_RecaudosModel = (bool)(reader["Estado_RecaudosModel"]);
                            int ID_Empresa = (int)(reader["ID_Empresa"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);

                            RecaudosModellist.Add(new RecaudosModel
                            {
                                Nro_contrato = Nro_Contrato,
                                Monto = Monto,
                                Fecha_vencimiento = Fecha_Vencimiento,
                                //Estado_RecaudosModel = Estado_RecaudosModel,
                                Id_empresa = ID_Empresa,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Usuario_creador = USUARIO_CREADOR,

                            });
                        }
                    }
                }

                return RecaudosModellist;
            }
            catch (Exception)
            {
                return RecaudosModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of RecaudosModel table by a given criteria.
        /// </summary>
        public List<RecaudosModel> RecaudosModelSelectbyUNKNOW(string aValue)
        {

            List<RecaudosModel> RecaudosModellist = new List<RecaudosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "RecaudosModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Nro_Contrato = (int)(reader["Nro_Contrato"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            DateTime Fecha_Vencimiento = (DateTime)(reader["Fecha_Vencimiento"]);
                            bool Estado_RecaudosModel = (bool)(reader["Estado_RecaudosModel"]);
                            int ID_Empresa = (int)(reader["ID_Empresa"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);

                            RecaudosModellist.Add(new RecaudosModel
                            {
                                Nro_contrato = Nro_Contrato,
                                Monto = Monto,
                                Fecha_vencimiento = Fecha_Vencimiento,
                                //Estado_RecaudosModel = Estado_RecaudosModel,
                                Id_empresa = ID_Empresa,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Usuario_creador = USUARIO_CREADOR,

                            });
                        }
                    }
                }

                return RecaudosModellist;
            }
            catch (Exception)
            {
                return RecaudosModellist;
            }
        }
        #endregion

    }

}
