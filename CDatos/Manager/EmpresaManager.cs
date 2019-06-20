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
    public class ManagerEmpresaModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the EmpresaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(EmpresaModel aEmpresaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_EmpresaModel", aEmpresaModel.Id_empresa);
                    command.Parameters.AddWithValue("@Nombre_EmpresaModel", aEmpresaModel.Nombre_empresa);
                    command.Parameters.AddWithValue("@Descripcion", aEmpresaModel.Descripcion);
                    command.Parameters.AddWithValue("@Nro_Cuenta", aEmpresaModel.Nro_cuenta);
                    command.Parameters.AddWithValue("@Comisiones", aEmpresaModel.Comisiones);
                    command.Parameters.AddWithValue("@EmpresaModel_Asume_Comision", aEmpresaModel.Empresa_asume_comision);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aEmpresaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aEmpresaModel.Fecha_modificacion == null ? (object)DBNull.Value : aEmpresaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aEmpresaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aEmpresaModel.Usuario_modificador == null ? (object)DBNull.Value : aEmpresaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "EmpresaModelInsert";

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
        /// Updates a record to the EmpresaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(EmpresaModel aEmpresaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_EmpresaModel", aEmpresaModel.Id_empresa);
                    command.Parameters.AddWithValue("@Nombre_EmpresaModel", aEmpresaModel.Nombre_empresa);
                    command.Parameters.AddWithValue("@Descripcion", aEmpresaModel.Descripcion);
                    command.Parameters.AddWithValue("@Nro_Cuenta", aEmpresaModel.Nro_cuenta);
                    command.Parameters.AddWithValue("@Comisiones", aEmpresaModel.Comisiones);
                    command.Parameters.AddWithValue("@EmpresaModel_Asume_Comision", aEmpresaModel.Empresa_asume_comision);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aEmpresaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aEmpresaModel.Fecha_modificacion == null ? (object)DBNull.Value : aEmpresaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aEmpresaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aEmpresaModel.Usuario_modificador == null ? (object)DBNull.Value : aEmpresaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "EmpresaModelUpdate";

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
        /// Deletes record to the EmpresaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID_EmpresaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_EmpresaModel", aID_EmpresaModel);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "EmpresaModelDelete";
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
        /// Selects the Single object of EmpresaModel table.
        /// </summary>
        public EmpresaModel GetEmpresaModel(int aID_EmpresaModel)
        {
            EmpresaModel EmpresaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID_EmpresaModel", aID_EmpresaModel);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "EmpresaModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_EmpresaModel = (int)(reader["ID_EmpresaModel"]);
                            string Nombre_EmpresaModel = (string)(reader["Nombre_EmpresaModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string Nro_Cuenta = (string)(reader["Nro_Cuenta"]);
                            decimal Comisiones = (decimal)(reader["Comisiones"]);
                            bool EmpresaModel_Asume_Comision = (bool)(reader["EmpresaModel_Asume_Comision"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            EmpresaModel = new EmpresaModel
                            {
                                Id_empresa = ID_EmpresaModel,
                                Nombre_empresa = Nombre_EmpresaModel,
                                Descripcion = Descripcion,
                                Nro_cuenta = Nro_Cuenta,
                                Comisiones = Comisiones,
                                Empresa_asume_comision = EmpresaModel_Asume_Comision,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return EmpresaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of EmpresaModel table.
        /// </summary>
        public List<EmpresaModel> EmpresaModelSelectAll()
        {

            List<EmpresaModel> EmpresaModellist = new List<EmpresaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "EmpresaModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_EmpresaModel = (int)(reader["ID_EmpresaModel"]);
                            string Nombre_EmpresaModel = (string)(reader["Nombre_EmpresaModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string Nro_Cuenta = (string)(reader["Nro_Cuenta"]);
                            decimal Comisiones = (decimal)(reader["Comisiones"]);
                            bool EmpresaModel_Asume_Comision = (bool)(reader["EmpresaModel_Asume_Comision"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            EmpresaModellist.Add(new EmpresaModel
                            {
                                Id_empresa = ID_EmpresaModel,
                                Nombre_empresa = Nombre_EmpresaModel,
                                Descripcion = Descripcion,
                                Nro_cuenta = Nro_Cuenta,
                                Comisiones = Comisiones,
                                Empresa_asume_comision = EmpresaModel_Asume_Comision,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return EmpresaModellist;
            }
            catch (Exception)
            {
                return EmpresaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of EmpresaModel table by a given criteria.
        /// </summary>
        public List<EmpresaModel> EmpresaModelSelectbyUNKNOW(string aValue)
        {

            List<EmpresaModel> EmpresaModellist = new List<EmpresaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "EmpresaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_EmpresaModel = (int)(reader["ID_EmpresaModel"]);
                            string Nombre_EmpresaModel = (string)(reader["Nombre_EmpresaModel"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            string Nro_Cuenta = (string)(reader["Nro_Cuenta"]);
                            decimal Comisiones = (decimal)(reader["Comisiones"]);
                            bool EmpresaModel_Asume_Comision = (bool)(reader["EmpresaModel_Asume_Comision"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            EmpresaModellist.Add(new EmpresaModel
                            {
                                Id_empresa = ID_EmpresaModel,
                                Nombre_empresa = Nombre_EmpresaModel,
                                Descripcion = Descripcion,
                                Nro_cuenta = Nro_Cuenta,
                                Comisiones = Comisiones,
                                Empresa_asume_comision = EmpresaModel_Asume_Comision,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return EmpresaModellist;
            }
            catch (Exception)
            {
                return EmpresaModellist;
            }
        }
        #endregion

    }

}
