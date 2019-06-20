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
    public class ManagerPrestamosModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the PrestamosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(PrestamosModel aPrestamosModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aPrestamosModel.Id);
                    //command.Parameters.AddWithValue("@FechaPrestamosModel", aPrestamosModel.FechaPrestamosModel);
                    //command.Parameters.AddWithValue("@MontoPrestamosModel", aPrestamosModel.MontoPrestamosModel);
                    command.Parameters.AddWithValue("@Moneda", aPrestamosModel.Moneda);
                    command.Parameters.AddWithValue("@PlazoMeses", aPrestamosModel.Plazomeses);
                    command.Parameters.AddWithValue("@Porcentaje_Interes", aPrestamosModel.Porcentaje_interes);
                    command.Parameters.AddWithValue("@Seguro", aPrestamosModel.Seguro);
                    command.Parameters.AddWithValue("@Cuenta", aPrestamosModel.Cuenta);
                    command.Parameters.AddWithValue("@Interes_Moratorio", aPrestamosModel.Interes_moratorio == null ? (object)DBNull.Value : aPrestamosModel.Interes_moratorio);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aPrestamosModel.Fecha_modificacion == null ? (object)DBNull.Value : aPrestamosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aPrestamosModel.Usuario_creador == null ? (object)DBNull.Value : aPrestamosModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aPrestamosModel.Usuario_modificador == null ? (object)DBNull.Value : aPrestamosModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PrestamosModelInsert";

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
        /// Updates a record to the PrestamosModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(PrestamosModel aPrestamosModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID", aPrestamosModel.Id);
                    //command.Parameters.AddWithValue("@FechaPrestamosModel", aPrestamosModel.FechaPrestamosModel);
                    //command.Parameters.AddWithValue("@MontoPrestamosModel", aPrestamosModel.MontoPrestamosModel);
                    command.Parameters.AddWithValue("@Moneda", aPrestamosModel.Moneda);
                    command.Parameters.AddWithValue("@PlazoMeses", aPrestamosModel.Plazomeses);
                    command.Parameters.AddWithValue("@Porcentaje_Interes", aPrestamosModel.Porcentaje_interes);
                    command.Parameters.AddWithValue("@Seguro", aPrestamosModel.Seguro);
                    command.Parameters.AddWithValue("@Cuenta", aPrestamosModel.Cuenta);
                    command.Parameters.AddWithValue("@Interes_Moratorio", aPrestamosModel.Interes_moratorio == null ? (object)DBNull.Value : aPrestamosModel.Interes_moratorio);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aPrestamosModel.Fecha_modificacion == null ? (object)DBNull.Value : aPrestamosModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aPrestamosModel.Usuario_creador == null ? (object)DBNull.Value : aPrestamosModel.Usuario_creador);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aPrestamosModel.Usuario_modificador == null ? (object)DBNull.Value : aPrestamosModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "PrestamosModelUpdate";

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
        /// Deletes record to the PrestamosModel table.
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
                    command.CommandText = "PrestamosModelDelete";
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
        /// Selects the Single object of PrestamosModel table.
        /// </summary>
        public PrestamosModel GetPrestamosModel(int aID)
        {
            PrestamosModel PrestamosModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PrestamosModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime FechaPrestamosModel = (DateTime)(reader["FechaPrestamosModel"]);
                            decimal MontoPrestamosModel = (decimal)(reader["MontoPrestamosModel"]);
                            short Moneda = (short)(reader["Moneda"]);
                            short PlazoMeses = (short)(reader["PlazoMeses"]);
                            decimal Porcentaje_Interes = (decimal)(reader["Porcentaje_Interes"]);
                            int Seguro = (int)(reader["Seguro"]);
                            string Cuenta = (string)(reader["Cuenta"]);
                            decimal? Interes_Moratorio = reader["Interes_Moratorio"] as decimal?;
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            int? USUARIO_CREADOR = reader["USUARIO_CREADOR"] as int?;
                            int? USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as int?;

                            PrestamosModel = new PrestamosModel
                            {
                                Id = ID,
                                //FechaPrestamosModel = FechaPrestamosModel,
                                //MontoPrestamosModel = MontoPrestamosModel,
                                Moneda = Moneda,
                                Plazomeses = PlazoMeses,
                                Porcentaje_interes = Porcentaje_Interes,
                                Seguro = Seguro,
                                Cuenta = Cuenta,
                                Interes_moratorio = Interes_Moratorio,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            };
                        }
                    }
                }

                return PrestamosModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of PrestamosModel table.
        /// </summary>
        public List<PrestamosModel> PrestamosModelSelectAll()
        {

            List<PrestamosModel> PrestamosModellist = new List<PrestamosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PrestamosModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime FechaPrestamosModel = (DateTime)(reader["FechaPrestamosModel"]);
                            decimal MontoPrestamosModel = (decimal)(reader["MontoPrestamosModel"]);
                            short Moneda = (short)(reader["Moneda"]);
                            short PlazoMeses = (short)(reader["PlazoMeses"]);
                            decimal Porcentaje_Interes = (decimal)(reader["Porcentaje_Interes"]);
                            int Seguro = (int)(reader["Seguro"]);
                            string Cuenta = (string)(reader["Cuenta"]);
                            decimal? Interes_Moratorio = reader["Interes_Moratorio"] as decimal?;
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            int? USUARIO_CREADOR = reader["USUARIO_CREADOR"] as int?;
                            int? USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as int?;

                            PrestamosModellist.Add(new PrestamosModel
                            {
                                Id = ID,
                                //FechaPrestamosModel = FechaPrestamosModel,
                                //MontoPrestamosModel = MontoPrestamosModel,
                                Moneda = Moneda,
                                Plazomeses = PlazoMeses,
                                Porcentaje_interes = Porcentaje_Interes,
                                Seguro = Seguro,
                                Cuenta = Cuenta,
                                Interes_moratorio = Interes_Moratorio,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return PrestamosModellist;
            }
            catch (Exception)
            {
                return PrestamosModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of PrestamosModel table by a given criteria.
        /// </summary>
        public List<PrestamosModel> PrestamosModelSelectbyUNKNOW(string aValue)
        {

            List<PrestamosModel> PrestamosModellist = new List<PrestamosModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PrestamosModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            DateTime FechaPrestamosModel = (DateTime)(reader["FechaPrestamosModel"]);
                            decimal MontoPrestamosModel = (decimal)(reader["MontoPrestamosModel"]);
                            short Moneda = (short)(reader["Moneda"]);
                            short PlazoMeses = (short)(reader["PlazoMeses"]);
                            decimal Porcentaje_Interes = (decimal)(reader["Porcentaje_Interes"]);
                            int Seguro = (int)(reader["Seguro"]);
                            string Cuenta = (string)(reader["Cuenta"]);
                            decimal? Interes_Moratorio = reader["Interes_Moratorio"] as decimal?;
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            int? USUARIO_CREADOR = reader["USUARIO_CREADOR"] as int?;
                            int? USUARIO_MODIFICADOR = reader["USUARIO_MODIFICADOR"] as int?;

                            PrestamosModellist.Add(new PrestamosModel
                            {
                                Id = ID,
                                //FechaPrestamosModel = FechaPrestamosModel,
                                //MontoPrestamosModel = MontoPrestamosModel,
                                Moneda = Moneda,
                                Plazomeses = PlazoMeses,
                                Porcentaje_interes = Porcentaje_Interes,
                                Seguro = Seguro,
                                Cuenta = Cuenta,
                                Interes_moratorio = Interes_Moratorio,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return PrestamosModellist;
            }
            catch (Exception)
            {
                return PrestamosModellist;
            }
        }
        #endregion

    }

}
