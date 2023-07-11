# SistemaTecnicaturasUTN
Sistema Académico para las Tecnicaturas de la UTN FRC
Este proyecto es un sistema académico desarrollado en C# utilizando Windows Forms. El sistema interactúa con una API hecha en C# y una base de datos en SQL Server (TransactSQL). Su objetivo principal es gestionar la información de alumnos y profesores, así como realizar el registro de exámenes y notas.

Características principales

• Login

• Inscripción, Modificación y Alta/Baja de Alumnos

• Inscripción y Modificación de Profesores

• Registro de Exámenes y Notas: El sistema ofrece la posibilidad de dar de alta un examen, estableciendo la relación maestro-detalle. El maestro representa el examen en sí, mientras que el detalle contiene la lista de alumnos y sus respectivas notas para ese examen.

• Patrones de Diseño Implementados: El proyecto ha incorporado los siguientes patrones de diseño:
  - DAO (Data Access Object)
  - Singleton
  - Factory

• Métodos Asíncronos: Todos los métodos del sistema se implementan de forma asíncrona, lo que mejora la eficiencia y la capacidad de respuesta del sistema en situaciones donde se realicen operaciones que puedan tomar tiempo, como la conexión a la API o la consulta a la base de datos.
