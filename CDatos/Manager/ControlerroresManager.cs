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
    public class ManagerControlErroresModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the ControlErroresModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(ControlErroresModel aControlErroresModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Usuario", aControlErroresModel.Usuario);
                    command.Parameters.AddWithValue("@Fecha", aControlErroresModel.Fecha);
                    command.Parameters.AddWithValue("@Componente", aControlErroresModel.Componente);
                    command.Parameters.AddWithValue("@Descripcion", aControlErroresModel.Descripcion == null ? (object)DBNull.Value : aControlErroresModel.Descripcion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ControlErroresModelInsert";

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
        /// Updates a record to the ControlErroresModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(ControlErroresModel aControlErroresModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@Id", aControlErroresModel.Id);
                    command.Parameters.AddWithValue("@Usuario", aControlErroresModel.Usuario);
                    command.Parameters.AddWithValue("@Fecha", aControlErroresModel.Fecha);
                    command.Parameters.AddWithValue("@Componente", aControlErroresModel.Componente);
                    command.Parameters.AddWithValue("@Descripcion", aControlErroresModel.Descripcion == null ? (object)DBNull.Value : aControlErroresModel.Descripcion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ControlErroresModelUpdate";

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
        /// Deletes record to the ControlErroresModel table.
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
                    command.CommandText = "ControlErroresModelDelete";
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
        /// Selects the Single object of ControlErroresModel table.
        /// </summary>
        public ControlErroresModel GetControlErroresModel(int aId)
        {
            ControlErroresModel ControlErroresModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ControlErroresModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Usuario = (string)(reader["Usuario"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            string Componente = (string)(reader["Componente"]);
                            byte[] Descripcion = (byte[])(reader["Descripcion"]);

                            ControlErroresModel = new ControlErroresModel
                            {
                                Id = Id,
                                Usuario = Usuario,
                                Fecha = Fecha,
                                Componente = Componente,
                                Descripcion = Descripcion,

                            };
                        }
                    }
                }

                return ControlErroresModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of ControlErroresModel table.
        /// </summary>
        public List<ControlErroresModel> ControlErroresModelSelectAll()
        {

            List<ControlErroresModel> ControlErroresModellist = new List<ControlErroresModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ControlErroresModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Usuario = (string)(reader["Usuario"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            string Componente = (string)(reader["Componente"]);
                            byte[] Descripcion = (byte[])(reader["Descripcion"]);

                            ControlErroresModellist.Add(new ControlErroresModel
                            {
                                Id = Id,
                                Usuario = Usuario,
                                Fecha = Fecha,
                                Componente = Componente,
                                Descripcion = Descripcion,

                            });
                        }
                    }
                }

                return ControlErroresModellist;
            }
            catch (Exception)
            {
                return ControlErroresModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of ControlErroresModel table by a given criteria.
        /// </summary>
        public List<ControlErroresModel> ControlErroresModelSelectbyUNKNOW(string aValue)
        {

            List<ControlErroresModel> ControlErroresModellist = new List<ControlErroresModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ControlErroresModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Usuario = (string)(reader["Usuario"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            string Componente = (string)(reader["Componente"]);
                            byte[] Descripcion = (byte[])(reader["Descripcion"]);

                            ControlErroresModellist.Add(new ControlErroresModel
                            {
                                Id = Id,
                                Usuario = Usuario,
                                Fecha = Fecha,
                                Componente = Componente,
                                Descripcion = Descripcion,

                            });
                        }
                    }
                }

                return ControlErroresModellist;
            }
            catch (Exception)
            {
                return ControlErroresModellist;
            }
        }
        #endregion

    }

}
