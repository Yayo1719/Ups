namespace YarvizApiHospital.Clases
{
    public class Medico
    {
        public int Codigo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificaion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string EstadoUSuario { get; set; }
        public string EstadoMedico { get; set; }
        public string Especialidad { get; set; }

    }

    public class Paciente
    {
        public int Codigo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificaion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string EstadoUsuario { get; set; }
        public string EstadoPaciente { get; set; }
        public string TipoSangre { get; set; }

    }

    public class Usuario
    {
        public int Codigo { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificaion { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Estado { get; set; }

    }

    public class UsuarioSys : Usuario
    {
        public string Rol { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Usuario { get; set; }

    }
}
