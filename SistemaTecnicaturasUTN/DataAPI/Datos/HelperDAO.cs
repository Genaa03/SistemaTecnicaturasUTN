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

        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }

        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable consulta(string nombreSP, List<Parametro> lista)
        {
            DataTable tabla = new DataTable();
            conectar();
            comando.Parameters.Clear();

            comando.CommandText = nombreSP;
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Clave, p.Valor);
            }
            tabla.Load(comando.ExecuteReader());

            comando.Parameters.Clear();

            desconectar();
            return tabla;
        }

        public DataTable consultaSinParametros(string nombreSP)
        {
            DataTable tabla = new DataTable();
            conectar();

            comando.Parameters.Clear();
            comando.CommandText = nombreSP;

            tabla.Load(comando.ExecuteReader());

            desconectar();
            return tabla;
        }

        public int ConsultaNumero(string nombreSP, string paramSalida)
        {
            SqlParameter pOut = new SqlParameter(paramSalida, SqlDbType.Int);

            conectar();
            comando.Parameters.Clear();
            comando.CommandText = nombreSP;

            pOut.Direction = ParameterDirection.Output;
            comando.Parameters.Add(pOut);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

            desconectar();

            return (int)pOut.Value;
        }

        public int modificacionBD(string nombreSP, List<Parametro> lista)
        {
            int filasAfectadas;
            conectar();
            comando.CommandText = nombreSP;
            comando.Parameters.Clear();
            // CARGA PARAMETROS
            foreach (Parametro p in lista)
            {
                comando.Parameters.AddWithValue(p.Clave,p.Valor);
            }

            filasAfectadas = comando.ExecuteNonQuery();
            desconectar();
            comando.Parameters.Clear();

            return filasAfectadas;
        }

        public bool ejecutarMD(string spMaestro, string spDetalle, Examen examen)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;

                // MAESTRO
                comando.Parameters.Clear();
                comando.CommandText = spMaestro;
                // CARGA PARAMETROS
                
                comando.Parameters.AddWithValue("@tipo_examen",examen.tipo_examen);
                comando.Parameters.AddWithValue("@materia", examen.materia);
                comando.Parameters.AddWithValue("@fecha", examen.fecha);

                SqlParameter pOut = new SqlParameter("@id", SqlDbType.Int);
                pOut.Direction = ParameterDirection.Output;
                comando.Parameters.Add(pOut);

                comando.ExecuteNonQuery();
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

                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
                t.Commit();

                control = true;
            }
            catch (Exception)
            {
                if (t != null)
                {
                    t.Rollback();
                }
                control = false;
            }
            finally
            {
                desconectar();
            }
            return control;
        }

        public bool InsertarAlumno(Alumno a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "CREAR_ALUMNO";
                
                // PARAMETROS 

                comando.Parameters.AddWithValue("@nombre", a.nombre);
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

                comando.ExecuteNonQuery();
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
                    desconectar();
            }
            return control;
        }

        public bool ModificarAlumno(Alumno2 a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "MODIFICAR_ALUMNO";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", a.id_alumno);
                comando.Parameters.AddWithValue("@nombre", a.nombre);
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

                comando.ExecuteNonQuery();
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
                    desconectar();
            }
            return control;
        }

        public bool EliminarAlumno(int id, string nombre, string apellido)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "ELIMINAR_ALUMNO";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);

                comando.ExecuteNonQuery();
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
                    desconectar();
            }
            return control;
        }


        public bool InsertarProfesor(Profesor a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "CREAR_PROFESOR";

                // PARAMETROS 

                comando.Parameters.AddWithValue("@nombre", a.nombre);
                comando.Parameters.AddWithValue("@apellido", a.apellido);
                comando.Parameters.AddWithValue("@tipo_dni", a.tipo_dni);
                comando.Parameters.AddWithValue("@nro_dni", a.nro_dni);
                comando.Parameters.AddWithValue("@fec_nac", a.fecha_nac);
                comando.Parameters.AddWithValue("@estado_civil", a.estado_civil);
                comando.Parameters.AddWithValue("@barrio", a.barrio);
                comando.Parameters.AddWithValue("@direccion", a.direccion);
                comando.Parameters.AddWithValue("@titulo", a.titulo_universitario);

                comando.ExecuteNonQuery();
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
                    desconectar();
            }
            return control;
        }

        public bool ModificarProfesor(Profesor a)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "MODIFICAR_PROFESOR";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", a.id_profesor);
                comando.Parameters.AddWithValue("@nombre", a.nombre);
                comando.Parameters.AddWithValue("@apellido", a.apellido);
                comando.Parameters.AddWithValue("@tipo_dni", a.tipo_dni);
                comando.Parameters.AddWithValue("@nro_dni", a.nro_dni);
                comando.Parameters.AddWithValue("@fec_nac", a.fecha_nac);
                comando.Parameters.AddWithValue("@estado_civil", a.estado_civil);
                comando.Parameters.AddWithValue("@barrio", a.barrio);
                comando.Parameters.AddWithValue("@direccion", a.direccion);
                comando.Parameters.AddWithValue("@titulo", a.titulo_universitario);

                comando.ExecuteNonQuery();
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
                    desconectar();
            }
            return control;
        }

        public bool EliminarProfesor(int id, string nombre, string apellido)
        {
            bool control = true;
            SqlTransaction t = null;

            try
            {
                conectar();
                t = conexion.BeginTransaction();
                comando.Transaction = t;
                comando.CommandText = "ELIMINAR_PROFESOR";

                // PARAMETROS 
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);

                comando.ExecuteNonQuery();
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
                    desconectar();
            }
            return control;
        }
    }
}
