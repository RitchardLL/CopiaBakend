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
    public class ManagerPersonaModel
    {
        #region Methods
        /// <summary>
        /// Saves a record to the PersonaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(PersonaModel aPersonaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 4);

                    command.Parameters.AddWithValue("@NombreUsuario", aPersonaModel.Nombreusuario);
                    command.Parameters.AddWithValue("@Pass", aPersonaModel.Pass);
                    command.Parameters.AddWithValue("@Correo", aPersonaModel.Correo == null ? (object)DBNull.Value : aPersonaModel.Correo);
                    command.Parameters.AddWithValue("@Estado", aPersonaModel.Estado);
                    command.Parameters.AddWithValue("@Nombres", aPersonaModel.Nombres);
                    command.Parameters.AddWithValue("@Apellidos", aPersonaModel.Apellidos);
                    command.Parameters.AddWithValue("@FechaNacimiento", aPersonaModel.Fechanacimiento == null ? (object)DBNull.Value : aPersonaModel.Fechanacimiento);
                    command.Parameters.AddWithValue("@Telefono", aPersonaModel.Telefono == null ? (object)DBNull.Value : aPersonaModel.Telefono);
                    command.Parameters.AddWithValue("@NroDocumento", aPersonaModel.Nrodocumento);
                    command.Parameters.AddWithValue("@TipoDocumento", aPersonaModel.Tipodocumento);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aPersonaModel.Fecha_creacion);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aPersonaModel.Usuario_creador);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_Persona";

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
        /// Updates a record to the PersonaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(PersonaModel aPersonaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 5);

                    command.Parameters.AddWithValue("@Id", aPersonaModel.Id);
                    command.Parameters.AddWithValue("@NombreUsuario", aPersonaModel.Nombreusuario);
                    command.Parameters.AddWithValue("@Pass", aPersonaModel.Pass);
                    command.Parameters.AddWithValue("@Correo", aPersonaModel.Correo == null ? (object)DBNull.Value : aPersonaModel.Correo);
                    command.Parameters.AddWithValue("@Estado", aPersonaModel.Estado);
                    command.Parameters.AddWithValue("@Nombres", aPersonaModel.Nombres);
                    command.Parameters.AddWithValue("@Apellidos", aPersonaModel.Apellidos);
                    command.Parameters.AddWithValue("@FechaNacimiento", aPersonaModel.Fechanacimiento == null ? (object)DBNull.Value : aPersonaModel.Fechanacimiento);
                    command.Parameters.AddWithValue("@Telefono", aPersonaModel.Telefono == null ? (object)DBNull.Value : aPersonaModel.Telefono);
                    command.Parameters.AddWithValue("@NroDocumento", aPersonaModel.Nrodocumento);
                    command.Parameters.AddWithValue("@TipoDocumento", aPersonaModel.Tipodocumento);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aPersonaModel.Fecha_modificacion == null ? (object)DBNull.Value : aPersonaModel.Fecha_modificacion);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aPersonaModel.Usuario_modificador == null ? (object)DBNull.Value : aPersonaModel.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_Persona";

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
        /// Deletes record to the PersonaModel table.
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

                    command.Parameters.AddWithValue("@pMode", 6);

                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_Persona";
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
        /// Selects the Single object of PersonaModel table.
        /// </summary>
        public PersonaModel GetPersonaModel(int aId)
        {
            PersonaModel PersonaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);

                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_Persona";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        int Id = (int)(reader["Id"]);
                        string NombreUsuario = (string)(reader["NombreUsuario"]);
                        string Pass = (string)(reader["Pass"]);
                        string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                        bool Estado = (bool)(reader["Estado"]);
                        string Nombres = (string)(reader["Nombres"]);
                        string Apellidos = (string)(reader["Apellidos"]);
                        DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                        string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                        string NroDocumento = (string)(reader["NroDocumento"]);
                        int TipoDocumento = (int)(reader["TipoDocumento"]);
                        DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                        DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                        string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                        string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                        PersonaModel = new PersonaModel
                        {
                            Id = Id,
                            Nombreusuario = NombreUsuario,
                            Pass = Pass,
                            Correo = Correo,
                            Estado = Estado,
                            Nombres = Nombres,
                            Apellidos = Apellidos,
                            Fechanacimiento = FechaNacimiento,
                            Telefono = Telefono,
                            Nrodocumento = NroDocumento,
                            Tipodocumento = TipoDocumento,
                            Fecha_creacion = FECHA_CREACION,
                            Fecha_modificacion = FECHA_MODIFICACION,
                            Usuario_creador = USUARIO_CREADOR,
                            Usuario_modificador = USUARIO_MODIFICADOR,
                        };
                    }
                }

                return PersonaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of PersonaModel table.
        /// </summary>
        public List<PersonaModel> PersonaModelSelectAll()
        {

            List<PersonaModel> PersonaModellist = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_Persona";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = (string)(reader["NombreUsuario"]);
                            string Pass = (string)(reader["Pass"]);
                            string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                            string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                            int TipoDocumento = (int)(reader["TipoDocumento"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (reader["USUARIO_MODIFICADOR"]) == DBNull.Value ? null : (string)(reader["USUARIO_MODIFICADOR"]);

                            PersonaModellist.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Pass = Pass,
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos,
                                Fechanacimiento = FechaNacimiento,
                                Telefono = Telefono,
                                Nrodocumento = NroDocumento,
                                Tipodocumento = TipoDocumento,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return PersonaModellist;
            }
            catch (Exception)
            {
                return PersonaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of PersonaModel table by a given criteria.
        /// </summary>
        public List<PersonaModel> PersonaModelSelectbyUNKNOW(string aValue)
        {

            List<PersonaModel> PersonaModellist = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PersonaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = (string)(reader["NombreUsuario"]);
                            string Pass = (string)(reader["Pass"]);
                            string Correo = (string)(reader["Correo"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                            string Telefono = (string)(reader["Telefono"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                            int TipoDocumento = (int)(reader["TipoDocumento"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

                            PersonaModellist.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Pass = Pass,
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos,
                                Fechanacimiento = FechaNacimiento,
                                Telefono = Telefono,
                                Nrodocumento = NroDocumento,
                                Tipodocumento = TipoDocumento,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return PersonaModellist;
            }
            catch (Exception)
            {
                return PersonaModellist;
            }
        }
        #endregion

        public bool ValidarUsuario(string usuario, string password)
        {
            int acceso = 0;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Password", password);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "ValidaUsuario";

                    SqlDataReader reader = command.ExecuteReader();
                    acceso = command.ExecuteNonQuery();
                    if (acceso > 0)
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

        public List<ComponenteModel> PermisosComponentes(int idUsuario)
        {
            List<ComponenteModel> listCom = null;
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Usuario", idUsuario);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerComponentesUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["[Descripcion]"]);
                            int? Id_aplicacion = (reader["[Id_aplicacion]"]) as int?;
                            bool Estado = (bool)(reader["[Estado]"]);
                            string Codigo = (string)(reader["[Codigo]"]);
                            int? Id_Componente = (reader["[Id_Componente]"]) as int?;
                            string USUARIO_CREADOR = (string)(reader["[USUARIO_CREADOR]"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["[FECHA_CREACION]"]);
                            string USUARIO_MODIFICADOR = (string)(reader["[USUARIO_MODIFICADOR]"]);
                            DateTime? FECHA_MODIFICACION = (reader["[FECHA_MODIFICACION]"]) as DateTime?;

                            listCom.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo ,
                                Id_componente = Id_Componente,
                                Fecha_creacion = FECHA_CREACION,
                                Fecha_modificacion = FECHA_MODIFICACION,
                                Usuario_creador = USUARIO_CREADOR,
                                Usuario_modificador = USUARIO_MODIFICADOR,

                            });
                        }
                    }
                }

                return listCom;
            }
            catch (Exception)
            {
                return listCom;
            }

        }

        public bool CambiarContraseña(string Usuario, string Password, string NewPassword)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@NewPassword", NewPassword);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spCambiarContrasena";

                    SqlDataReader reader = command.ExecuteReader();
                    int afectados = command.ExecuteNonQuery();
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


    }

}
