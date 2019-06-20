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
    public class ManagerMovimientosVentanillaModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the MovimientosVentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(MovimientosVentanillaModel aMovimientosVentanillaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_Movimiento", aMovimientosVentanillaModel.Id_movimiento);
                    command.Parameters.AddWithValue("@ID_Cuenta", aMovimientosVentanillaModel.Id_cuenta);
                    command.Parameters.AddWithValue("@Monto", aMovimientosVentanillaModel.Monto);
                    command.Parameters.AddWithValue("@Moneda", aMovimientosVentanillaModel.Moneda);
                    command.Parameters.AddWithValue("@ID_TurnoUsuario", aMovimientosVentanillaModel.Id_turnousuario);
                    command.Parameters.AddWithValue("@ID_TipoMovimiento", aMovimientosVentanillaModel.Id_tipomovimiento);
                    command.Parameters.AddWithValue("@Fecha_Creacion", aMovimientosVentanillaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@Usuario_Creador", aMovimientosVentanillaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Fecha_Modificacion", aMovimientosVentanillaModel.Fecha_modificacion == null ? (object)DBNull.Value : aMovimientosVentanillaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@Usuario_Modificador", aMovimientosVentanillaModel.Usuario_modificador == null ? (object)DBNull.Value : aMovimientosVentanillaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "MovimientosVentanillaModelInsert";

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
        /// Updates a record to the MovimientosVentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(MovimientosVentanillaModel aMovimientosVentanillaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_Movimiento", aMovimientosVentanillaModel.Id_movimiento);
                    command.Parameters.AddWithValue("@ID_Cuenta", aMovimientosVentanillaModel.Id_cuenta);
                    command.Parameters.AddWithValue("@Monto", aMovimientosVentanillaModel.Monto);
                    command.Parameters.AddWithValue("@Moneda", aMovimientosVentanillaModel.Moneda);
                    command.Parameters.AddWithValue("@ID_TurnoUsuario", aMovimientosVentanillaModel.Id_turnousuario);
                    command.Parameters.AddWithValue("@ID_TipoMovimiento", aMovimientosVentanillaModel.Id_tipomovimiento);
                    command.Parameters.AddWithValue("@Fecha_Creacion", aMovimientosVentanillaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@Usuario_Creador", aMovimientosVentanillaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@Fecha_Modificacion", aMovimientosVentanillaModel.Fecha_modificacion == null ? (object)DBNull.Value : aMovimientosVentanillaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@Usuario_Modificador", aMovimientosVentanillaModel.Usuario_modificador == null ? (object)DBNull.Value : aMovimientosVentanillaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "MovimientosVentanillaModelUpdate";

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
        /// Deletes record to the MovimientosVentanillaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID_Movimiento)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@ID_Movimiento", aID_Movimiento);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "MovimientosVentanillaModelDelete";
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
        /// Selects the Single object of MovimientosVentanillaModel table.
        /// </summary>
        public MovimientosVentanillaModel GetMovimientosVentanillaModel(int aID_Movimiento)
        {
            MovimientosVentanillaModel MovimientosVentanillaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@ID_Movimiento", aID_Movimiento);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "MovimientosVentanillaModelSelect";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            int ID_Cuenta = (int)(reader["ID_Cuenta"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            string Moneda = (string)(reader["Moneda"]);
                            int ID_TurnoUsuario = (int)(reader["ID_TurnoUsuario"]);
                            int ID_TipoMovimiento = (int)(reader["ID_TipoMovimiento"]);
                            DateTime Fecha_Creacion = (DateTime)(reader["Fecha_Creacion"]);
                            string Usuario_Creador = (string)(reader["Usuario_Creador"]);
                            DateTime? Fecha_Modificacion = reader["Fecha_Modificacion"] as DateTime?;
                            string Usuario_Modificador = (string)(reader["Usuario_Modificador"]);

                            MovimientosVentanillaModel = new MovimientosVentanillaModel
                            {
                                Id_movimiento = ID_Movimiento,
                                Id_cuenta = ID_Cuenta,
                                Monto = Monto,
                                Moneda = Moneda,
                                Id_turnousuario = ID_TurnoUsuario,
                                Id_tipomovimiento = ID_TipoMovimiento,
                                Fecha_creacion = Fecha_Creacion,
                                Usuario_creador = Usuario_Creador,
                                Fecha_modificacion = Fecha_Modificacion,
                                Usuario_modificador = Usuario_Modificador,

                            };
                        }
                    }
                }

                return MovimientosVentanillaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of MovimientosVentanillaModel table.
        /// </summary>
        public List<MovimientosVentanillaModel> MovimientosVentanillaModelSelectAll()
        {

            List<MovimientosVentanillaModel> MovimientosVentanillaModellist = new List<MovimientosVentanillaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "MovimientosVentanillaModelSelectAll";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            int ID_Cuenta = (int)(reader["ID_Cuenta"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            string Moneda = (string)(reader["Moneda"]);
                            int ID_TurnoUsuario = (int)(reader["ID_TurnoUsuario"]);
                            int ID_TipoMovimiento = (int)(reader["ID_TipoMovimiento"]);
                            DateTime Fecha_Creacion = (DateTime)(reader["Fecha_Creacion"]);
                            string Usuario_Creador = (string)(reader["Usuario_Creador"]);
                            DateTime? Fecha_Modificacion = reader["Fecha_Modificacion"] as DateTime?;
                            string Usuario_Modificador = (string)(reader["Usuario_Modificador"]);

                            MovimientosVentanillaModellist.Add(new MovimientosVentanillaModel
                            {
                                Id_movimiento = ID_Movimiento,
                                Id_cuenta = ID_Cuenta,
                                Monto = Monto,
                                Moneda = Moneda,
                                Id_turnousuario = ID_TurnoUsuario,
                                Id_tipomovimiento = ID_TipoMovimiento,
                                Fecha_creacion = Fecha_Creacion,
                                Usuario_creador = Usuario_Creador,
                                Fecha_modificacion = Fecha_Modificacion,
                                Usuario_modificador = Usuario_Modificador,

                            });
                        }
                    }
                }

                return MovimientosVentanillaModellist;
            }
            catch (Exception)
            {
                return MovimientosVentanillaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of MovimientosVentanillaModel table by a given criteria.
        /// </summary>
        public List<MovimientosVentanillaModel> MovimientosVentanillaModelSelectbyUNKNOW(string aValue)
        {

            List<MovimientosVentanillaModel> MovimientosVentanillaModellist = new List<MovimientosVentanillaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "MovimientosVentanillaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID_Movimiento = (int)(reader["ID_Movimiento"]);
                            int ID_Cuenta = (int)(reader["ID_Cuenta"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            string Moneda = (string)(reader["Moneda"]);
                            int ID_TurnoUsuario = (int)(reader["ID_TurnoUsuario"]);
                            int ID_TipoMovimiento = (int)(reader["ID_TipoMovimiento"]);
                            DateTime Fecha_Creacion = (DateTime)(reader["Fecha_Creacion"]);
                            string Usuario_Creador = (string)(reader["Usuario_Creador"]);
                            DateTime? Fecha_Modificacion = reader["Fecha_Modificacion"] as DateTime?;
                            string Usuario_Modificador = (string)(reader["Usuario_Modificador"]);

                            MovimientosVentanillaModellist.Add(new MovimientosVentanillaModel
                            {
                                Id_movimiento = ID_Movimiento,
                                Id_cuenta = ID_Cuenta,
                                Monto = Monto,
                                Moneda = Moneda,
                                Id_turnousuario = ID_TurnoUsuario,
                                Id_tipomovimiento = ID_TipoMovimiento,
                                Fecha_creacion = Fecha_Creacion,
                                Usuario_creador = Usuario_Creador,
                                Fecha_modificacion = Fecha_Modificacion,
                                Usuario_modificador = Usuario_Modificador,

                            });
                        }
                    }
                }

                return MovimientosVentanillaModellist;
            }
            catch (Exception)
            {
                return MovimientosVentanillaModellist;
            }
        }
        #endregion

    }

}
