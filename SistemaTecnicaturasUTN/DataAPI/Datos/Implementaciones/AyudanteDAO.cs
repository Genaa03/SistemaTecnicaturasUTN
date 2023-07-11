using DataAPI.Dominio;
using System.Data;
using DataAPI.Datos.Interfaces;

namespace DataAPI.Datos.Implementaciones
{
    public class AyudanteDAO : IAyudanteDAO
    {
        public async Task<DataTable> Ingreso()
        {
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros("INGRESO");
            return tabla;
        }

        public async Task<List<Alumno>> GetAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            string sp = "OBTENER_ALUMNOS";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_alumno"].ToString());
                string nombre = a["Nombre"].ToString();
                string apellido = a["apellido"].ToString();
                int tipo_dni = Convert.ToInt32(a["id_tipo_dni"].ToString());
                string nro_dni = a["nro_dni"].ToString();
                int tecnicatura = Convert.ToInt32(a["id_tecnicatura"].ToString());
                DateTime fecha_nac = Convert.ToDateTime(a["fec_nac"].ToString());
                int estado_civil = Convert.ToInt32(a["id_estado_civil"].ToString());
                int situacion_laboral = Convert.ToInt32(a["id_situacion_laboral"].ToString());
                int situacion_habitacional = Convert.ToInt32(a["id_situacion_habitacional"].ToString());
                int barrio = Convert.ToInt32(a["id_barrio"].ToString());
                string direccion = a["direccion"].ToString();

                Alumno alu = new Alumno(id,nombre,apellido,tipo_dni,nro_dni,tecnicatura,fecha_nac,estado_civil,situacion_laboral,situacion_habitacional,barrio,direccion);
                alumnos.Add(alu);

            }

            return alumnos;
        }

        public async Task<List<Alumno2>> GetAlumnosConAlta()
        {
            List<Alumno2> alumnos = new List<Alumno2>();

            string sp = "OBTENER_ALUMNOS_CON_ALTA";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_alumno"].ToString());
                string nombreCompleto = a["nombreCompleto"].ToString();
                string nombre = a["Nombre"].ToString();
                string apellido = a["apellido"].ToString();
                int tipo_dni = Convert.ToInt32(a["id_tipo_dni"].ToString());
                string nro_dni = a["nro_dni"].ToString();
                int tecnicatura = Convert.ToInt32(a["id_tecnicatura"].ToString());
                DateTime fecha_nac = Convert.ToDateTime(a["fec_nac"].ToString());
                int estado_civil = Convert.ToInt32(a["id_estado_civil"].ToString());
                int situacion_laboral = Convert.ToInt32(a["id_situacion_laboral"].ToString());
                int situacion_habitacional = Convert.ToInt32(a["id_situacion_habitacional"].ToString());
                int barrio = Convert.ToInt32(a["id_barrio"].ToString());
                string direccion = a["direccion"].ToString();

                Alumno2 alu = new Alumno2(id, nombreCompleto,nombre, apellido, tipo_dni, nro_dni, tecnicatura, fecha_nac, estado_civil, situacion_laboral, situacion_habitacional, barrio, direccion);
                alumnos.Add(alu);

            }

            return alumnos;
        }




        public async Task<List<Barrio>> GetBarrios()
        {
            List<Barrio> lst = new List<Barrio>();

            string sp = "OBTENER_BARRIOS";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_barrio"].ToString());
                string barrio = a["barrio"].ToString();

                Barrio aux = new Barrio(id,barrio);
                
                lst.Add(aux);

            }

            return lst;
        }

        public async Task<List<EstadoCivil>> GetEstadosCivil()
        {
            List<EstadoCivil> lst = new List<EstadoCivil>();

            string sp = "OBTENER_ESTADOS_CIVIL";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_estado_civil"].ToString());
                string nombre = a["descripcion"].ToString();

                EstadoCivil aux = new EstadoCivil(id, nombre);

                lst.Add(aux);

            }

            return lst;
        }

        public async Task<int> GetProximoAlumno()
        {
            return await HelperDAO.ObtenerInstancia().ConsultaNumero("PROXIMO_ALUMNO","@next");
        }

        public async Task<List<SituacionHab>> GetSituacionHab()
        {
            List<SituacionHab> lst = new List<SituacionHab>();

            string sp = "OBTENER_SITUACION_HAB";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_situacion_habitacional"].ToString());
                string nombre = a["descripcion"].ToString();

                SituacionHab aux = new SituacionHab(id, nombre);

                lst.Add(aux);

            }

            return lst;
        }


        public async Task<List<SituacionLab>> GetSituacionLab()
        {
            List<SituacionLab> lst = new List<SituacionLab>();

            string sp = "OBTENER_SITUACION_LAB";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_situacion_laboral"].ToString());
                string nombre = a["descripcion"].ToString();

                SituacionLab aux = new SituacionLab(id, nombre);

                lst.Add(aux);

            }

            return lst;
        }

        public async Task<List<Tecnicatura>> GetTecnicaturas()
        {
            List<Tecnicatura> lst = new List<Tecnicatura>();

            string sp = "OBTENER_TECNICATURAS";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_tecnicatura"].ToString());
                string nombre = a["descripcion"].ToString();

                Tecnicatura aux = new Tecnicatura(id, nombre);

                lst.Add(aux);

            }

            return lst;
        }

        public async Task<List<TipoDNI>> GetTiposDNI()
        {
            List<TipoDNI> lst = new List<TipoDNI>();

            string sp = "OBTENER_TIPOS_DNI";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_tipo_dni"].ToString());
                string nombre = a["descripcion"].ToString();

                TipoDNI aux = new TipoDNI(id, nombre);

                lst.Add(aux);

            }

            return lst;
        }


        public async Task<List<AlumnoAltaBaja>> GetAlumnosAlta()
        {
            List<AlumnoAltaBaja> lst = new List<AlumnoAltaBaja>();

            string sp = "LISTA_ALUMNOS";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                string nombre = a["Nombre"].ToString();
                string apellido = a["apellido"].ToString();

                AlumnoAltaBaja aux = new AlumnoAltaBaja(apellido,nombre);

                lst.Add(aux);

            }

            return lst;
        }

        public async Task<List<AlumnoAltaBaja>> GetAlumnosBaja()
        {
            List<AlumnoAltaBaja> lst = new List<AlumnoAltaBaja>();

            string sp = "LISTA_ALUMNOS_BAJA";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                string nombre = a["Nombre"].ToString();
                string apellido = a["apellido"].ToString();

                AlumnoAltaBaja aux = new AlumnoAltaBaja(apellido, nombre);

                lst.Add(aux);

            }

            return lst;
        }

        public async Task<int> AlumnoDarBaja(string apellido, string nombre)
        {
            int filas;
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@apellido", apellido));
            lista.Add(new Parametro("@Nombre", nombre));

            string sp = "SP_BAJA_ALUMNO";
            filas = await HelperDAO.ObtenerInstancia().ModificacionBD(sp,lista);

            lista.Clear();
            return filas;
        }

        public async Task<int> AlumnoDarAlta(string apellido, string nombre)
        {
            int filas;
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@apellido", apellido));
            lista.Add(new Parametro("@Nombre", nombre));

            string sp = "SP_ALTA_ALUMNO";
            filas = await HelperDAO.ObtenerInstancia().ModificacionBD(sp, lista);

            lista.Clear();
            return filas;
        }


        public async Task<bool> CrearAlumno(Alumno alumno)
        {
            return await HelperDAO.ObtenerInstancia().InsertarAlumno(alumno);
        }

        public async Task<bool> ModificarAlumno(Alumno2 alumno)
        {
            return await HelperDAO.ObtenerInstancia().ModificarAlumno(alumno);
        }

        public async Task<bool> EliminarAlumno(int id)
        {
            return await HelperDAO.ObtenerInstancia().EliminarAlumno(id);
        }

        // **************************************************************************************************
        // FORM EXAMENES
        // **************************************************************************************************

        public async Task<bool> CrearExamen(Examen examen)
        {
            return await HelperDAO.ObtenerInstancia().EjecutarMD("CREAR_EXAMEN", "CREAR_DETALLE_EXAMEN", examen);
        }

        public async Task<List<Materia>> GetMaterias()
        {
            List<Materia> lst = new List<Materia>();

            string sp = "OBTENER_MATERIAS";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_materia"].ToString());
                string nombre = a["nombre_materia"].ToString();
                int tecnicatura = Convert.ToInt32(a["id_tecnicatura"].ToString());

                Materia aux = new Materia(id, nombre, tecnicatura);

                lst.Add(aux);

            }

            return lst;
        }

        public async Task<List<TipoExamen>> GetTipoExamenes()
        {
            List<TipoExamen> lst = new List<TipoExamen>();

            string sp = "OBTENER_TIPOS_EXAMEN";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_tipo_examen"].ToString());
                string nombre = a["descripcion"].ToString();

                TipoExamen aux = new TipoExamen(id, nombre);

                lst.Add(aux);

            }

            return lst;
        }

        public async Task<int> GetProximoExamen()
        {
            return await HelperDAO.ObtenerInstancia().ConsultaNumero("PROXIMO_EXAMEN", "@next");
        }

        // **************************************************************************************************
        // FORM PROFESORES
        // **************************************************************************************************

        public async Task<List<Profesor>> GetProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();

            string sp = "OBTENER_PROFESORES";
            DataTable tabla = await HelperDAO.ObtenerInstancia().ConsultaSinParametros(sp);

            foreach (DataRow a in tabla.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
                int id = Convert.ToInt32(a["id_profesor"].ToString());
                string nombreCompleto = a["nombreCompleto"].ToString();
                string nombre = a["Nombre"].ToString();
                string apellido = a["apellido"].ToString();
                int tipo_dni = Convert.ToInt32(a["id_tipo_dni"].ToString());
                string nro_dni = a["nro_dni"].ToString();
                DateTime fecha_nac = Convert.ToDateTime(a["fec_nac"].ToString());
                int estado_civil = Convert.ToInt32(a["id_estado_civil"].ToString());
                int barrio = Convert.ToInt32(a["id_barrio"].ToString());
                string direccion = a["direccion"].ToString();
                string titulo = a["titulo_univ"].ToString();

                Profesor prof = new Profesor(id, nombreCompleto, nombre, apellido, tipo_dni, nro_dni, fecha_nac, estado_civil, barrio, direccion, titulo);
                profesores.Add(prof);

            }

            return profesores;
        }
        public async Task<int> GetProximoProfesor()
        {
            return await HelperDAO.ObtenerInstancia().ConsultaNumero("PROXIMO_PROFESOR", "@next");
        }
        public async Task<bool> CrearProfesor(Profesor profesor)
        {
            return await HelperDAO.ObtenerInstancia().InsertarProfesor(profesor);
        }

    public async Task<bool> ModificarProfesor(Profesor profesor)
        {
            return await HelperDAO.ObtenerInstancia().ModificarProfesor(profesor);
        }

public async Task<bool> EliminarProfesor(int id, string nombre, string apellido)
        {
            return await HelperDAO.ObtenerInstancia().EliminarProfesor(id, nombre, apellido);
        }


    }
}
