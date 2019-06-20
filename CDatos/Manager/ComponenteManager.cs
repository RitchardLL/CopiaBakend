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
    public class ManagerComponenteModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the ComponenteModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(ComponenteModel aComponenteModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Nombre", aComponenteModel.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", aComponenteModel.Descripcion);
                    command.Parameters.AddWithValue("@Id_aplicacion", aComponenteModel.Id_aplicacion == null ? (object)DBNull.Value : aComponenteModel.Id_aplicacion);
                    command.Parameters.AddWithValue("@Estado", aComponenteModel.Estado);
                    command.Parameters.AddWithValue("@Codigo", aComponenteModel.Codigo);
                    //command.Parameters.AddWithValue("@Id_ComponenteModel", aComponenteModel.Id_componente == null ? (object)DBNull.Value : aComponenteModel.Id_ComponenteModel);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aComponenteModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aComponenteModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aComponenteModel.Usuario_modificador == null ? (object)DBNull.Value : aComponenteModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aComponenteModel.Fecha_modificacion == null ? (object)DBNull.Value : aComponenteModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ComponenteModelInsert";

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
        /// Updates a record to the ComponenteModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(ComponenteModel aComponenteModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Id", aComponenteModel.Id);
                    command.Parameters.AddWithValue("@Nombre", aComponenteModel.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", aComponenteModel.Descripcion);
                    command.Parameters.AddWithValue("@Id_aplicacion", aComponenteModel.Id_aplicacion == null ? (object)DBNull.Value : aComponenteModel.Id_aplicacion);
                    command.Parameters.AddWithValue("@Estado", aComponenteModel.Estado);
                    command.Parameters.AddWithValue("@Codigo", aComponenteModel.Codigo);
                    //command.Parameters.AddWithValue("@Id_ComponenteModel", aComponenteModel.Id_componente == null ? (object)DBNull.Value : aComponenteModel.Id_ComponenteModel);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aComponenteModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aComponenteModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aComponenteModel.Usuario_modificador == null ? (object)DBNull.Value : aComponenteModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aComponenteModel.Fecha_modificacion == null ? (object)DBNull.Value : aComponenteModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ComponenteModelUpdate";

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
        /// Deletes record to the ComponenteModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aId)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ComponenteModelDelete";
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
        /// Selects the Single object of ComponenteModel table.
        /// </summary>
        public ComponenteModel GetComponenteModel(int aId)
        {
            ComponenteModel ComponenteModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ComponenteModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int? Id_aplicacion = reader["Id_aplicacion"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);
                            int? Id_ComponenteModel = reader["Id_ComponenteModel"] as int?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            ComponenteModel = new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo,
                                Id_componente = Id_ComponenteModel,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            };
                        }
                    }
                }

                return ComponenteModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of ComponenteModel table.
        /// </summary>
        public List<ComponenteModel> ComponenteModelSelectAll()
        {

            List<ComponenteModel> ComponenteModellist = new List<ComponenteModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ComponenteModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int? Id_aplicacion = reader["Id_aplicacion"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);
                            int? Id_ComponenteModel = reader["Id_ComponenteModel"] as int?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            ComponenteModellist.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo,
                                Id_componente = Id_ComponenteModel,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return ComponenteModellist;
            }
            catch (Exception)
            {
                return ComponenteModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of ComponenteModel table by a given criteria.
        /// </summary>
        public List<ComponenteModel> ComponenteModelSelectbyUNKNOW(string aValue)
        {

            List<ComponenteModel> ComponenteModellist = new List<ComponenteModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ComponenteModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int? Id_aplicacion = reader["Id_aplicacion"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);
                            int? Id_ComponenteModel = reader["Id_ComponenteModel"] as int?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            ComponenteModellist.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo,
                                Id_componente = Id_ComponenteModel,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return ComponenteModellist;
            }
            catch (Exception)
            {
                return ComponenteModellist;
            }
        }
        #endregion

    }

}
