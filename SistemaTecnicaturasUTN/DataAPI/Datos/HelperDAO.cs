using System.Data;
using System.Data.SqlClient;
using DataAPI.Dominio;

namespace DataAPI.Datos
{
    internal class HelperDAO
    {
        private static HelperDAO instancia;
        private SqlConnection conexion;
        private SqlCommand comando = new SqlCommand();


        private HelperDAO()
        {
            conexion = new SqlConnection(@"Data Source=localhost;Initial Catalog=TPI_PROGRAMACION;Integrated Security=True"); //SE CAMBIO BD
        }

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        private void Conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public async Task<DataTable> Consulta(string nombreSP, List<Parametro> lista)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.Parameters.Clear();

            comando.CommandText = nombreSP;
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Clave, p.Valor);
            }
            tabla.Load(await comando.ExecuteReaderAsync());

            comando.Parameters.Clear();

            Desconectar();
            return tabla;
        }

        public async Task<DataTable> ConsultaSinParametros(string nombreSP)
        {
            DataTable tabla = new DataTable();
            Conectar();

            comando.Parameters.Clear();
            comando.CommandText = nombreSP;

            tabla.Load(await comando.ExecuteReaderAsync());

            Desconectar();
            return tabla;
        }

        public async Task<int> ConsultaNumero(string nombreSP, string paramSalida)
        {
            SqlParameter pOut = new SqlParameter(paramSalida, SqlDbType.Int);

            Conectar();
            comando.Parameters.Clear();
            comando.CommandText = nombreSP;

            pOut.Direction = ParameterDirection.Output;
            comando.Parameters.Add(pOut);
            await comando.ExecuteNonQueryAsync();
            comando.Parameters.Clear();

            Desconectar();

            return (int)pOut.Value;
        }

        public async Task<int> ModificacionBD(string nombreSP, List<Parametro> lista)
        {
            int filasAfectadas;
            Conectar();
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            // CARGA PARAMETROS
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Clave,p.Valor);
            }

            filasAfectadas = await comando.ExecuteNonQueryAsync();
            Desconectar();
            comando.Parameters.Clear();

            return filasAfectadas;
        }

        public async Task<bool> EjecutarMD(string spMaestro, string spDetalle, Examen examen)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;

                // MAESTRO
                comando.Parameters.Clear();
                comando.CommandText = spMaestro;
                // CARGA PARAMETROS
                
                comando.Parameters.AddWithValue("@tipo_examen",examen.tipo_examen);
                comando.Parameters.AddWithValue("@materia", examen.materia);
                comando.Parameters.AddWithValue("@fecha", examen.fecha);

                SqlParameter pOut = new SqlParameter("@Id", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                comando.Parameters.Add(pOut);

                await comando.ExecuteNonQueryAsync();
                int id = (int)pOut.Value;
                comando.Parameters.Clear();

                // DETALLE


                foreach (DetalleExamen detalle in examen.examenes)
                {
                    comando.CommandText = spDetalle;

                    // CARGA PARAMETROS
                    comando.Parameters.AddWithValue("@id_examen", id);
                    comando.Parameters.AddWithValue("@id_alumno", detalle.alumno.id_alumno);
                    comando.Parameters.AddWithValue("@nota", detalle.nota);

                    await comando.ExecuteNonQueryAsync();
                    comando.Parameters.Clear();
                }
                t.Commit();

                control = true;
            }
            catch
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                Desconectar();
            }
            return control;
        }

        public async Task<bool> InsertarAlumno(Alumno a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "CREAR_ALUMNO";
                
                // PARAMETROS 

                comando.Parameters.AddWithValue("@Nombre", a.Nombre);
                comando.Parameters.AddWithValue("@apellido", a.Apellido);
                comando.Parameters.AddWithValue("@tipo_dni", a.Tipo_dni);
                comando.Parameters.AddWithValue("@nro_dni", a.Nro_dni);
                comando.Parameters.AddWithValue("@tecnicatura", a.Tecnicatura);
                comando.Parameters.AddWithValue("@fec_nac", a.Fecha_nac);
                comando.Parameters.AddWithValue("@estado_civil", a.Estado_civil);
                comando.Parameters.AddWithValue("@situacion_lab", a.Situacion_laboral);
                comando.Parameters.AddWithValue("@situacion_hab", a.Situacion_habitacional);
                comando.Parameters.AddWithValue("@barrio", a.Barrio);
                comando.Parameters.AddWithValue("@direccion", a.Direccion);

                await comando.ExecuteNonQueryAsync();
                comando.Parameters.Clear();

                t.Commit();
                control = true;
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    Desconectar();
            }
            return control;
        }

        public async Task<bool> ModificarAlumno(Alumno2 a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "MODIFICAR_ALUMNO";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id", a.id_alumno);
                comando.Parameters.AddWithValue("@Nombre", a.nombre);
                comando.Parameters.AddWithValue("@apellido", a.apellido);
                comando.Parameters.AddWithValue("@tipo_dni", a.tipo_dni);
                comando.Parameters.AddWithValue("@nro_dni", a.nro_dni);
                comando.Parameters.AddWithValue("@tecnicatura", a.tecnicatura);
                comando.Parameters.AddWithValue("@fec_nac", a.fecha_nac);
                comando.Parameters.AddWithValue("@estado_civil", a.estado_civil);
                comando.Parameters.AddWithValue("@situacion_lab", a.situacion_laboral);
                comando.Parameters.AddWithValue("@situacion_hab", a.situacion_habitacional);
                comando.Parameters.AddWithValue("@barrio", a.barrio);
                comando.Parameters.AddWithValue("@direccion", a.direccion);

                await comando.ExecuteNonQueryAsync();
                comando.Parameters.Clear();

                t.Commit();
                control = true;
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    Desconectar();
            }
            return control;
        }

        public async Task<bool> EliminarAlumno(int id)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "ELIMINAR_ALUMNO2";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", id);

                await comando.ExecuteNonQueryAsync();
                comando.Parameters.Clear();

                t.Commit();
                control = true;
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    Desconectar();
            }
            return control;
        }


        public async Task<bool> InsertarProfesor(Profesor a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "CREAR_PROFESOR";

                // PARAMETROS 

                comando.Parameters.AddWithValue("@Nombre", a.nombre);
                comando.Parameters.AddWithValue("@apellido", a.apellido);
                comando.Parameters.AddWithValue("@tipo_dni", a.tipo_dni);
                comando.Parameters.AddWithValue("@nro_dni", a.nro_dni);
                comando.Parameters.AddWithValue("@fec_nac", a.fecha_nac);
                comando.Parameters.AddWithValue("@estado_civil", a.estado_civil);
                comando.Parameters.AddWithValue("@barrio", a.barrio);
                comando.Parameters.AddWithValue("@direccion", a.direccion);
                comando.Parameters.AddWithValue("@titulo", a.titulo_universitario);

                await comando.ExecuteNonQueryAsync();
                comando.Parameters.Clear();

                t.Commit();
                control = true;
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    Desconectar();
            }
            return control;
        }

        public async Task<bool> ModificarProfesor(Profesor a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "MODIFICAR_PROFESOR";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id", a.id_profesor);
                comando.Parameters.AddWithValue("@Nombre", a.nombre);
                comando.Parameters.AddWithValue("@apellido", a.apellido);
                comando.Parameters.AddWithValue("@tipo_dni", a.tipo_dni);
                comando.Parameters.AddWithValue("@nro_dni", a.nro_dni);
                comando.Parameters.AddWithValue("@fec_nac", a.fecha_nac);
                comando.Parameters.AddWithValue("@estado_civil", a.estado_civil);
                comando.Parameters.AddWithValue("@barrio", a.barrio);
                comando.Parameters.AddWithValue("@direccion", a.direccion);
                comando.Parameters.AddWithValue("@titulo", a.titulo_universitario);

                await comando.ExecuteNonQueryAsync();
                comando.Parameters.Clear();

                t.Commit();
                control = true;
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    Desconectar();
            }
            return control;
        }

        public async Task<bool> EliminarProfesor(int id, string nombre, string apellido)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                Conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "ELIMINAR_PROFESOR";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);

                await comando.ExecuteNonQueryAsync();
                comando.Parameters.Clear();

                t.Commit();
                control = true;
            }
            catch (SqlException)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    Desconectar();
            }
            return control;
        }
    }
}
