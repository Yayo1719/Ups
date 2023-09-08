
using Microsoft.AspNetCore.Mvc;
using YarvizApiHospital.Clases;

namespace YarvizApiHospital.Controllers
{
    [ApiController]
    [Route("Medicos")]

    public class Medicos : Controller
    {
        [HttpGet]
        [Route("Listar")]

        public dynamic Listar()
        {


            List<Medico> list = new List<Medico>
            {
                new Medico
                {
                    Codigo = 1,
                    TipoIdentificacion = "1",
                    Identificaion = "Cedula",
                    PrimerNombre = "Juan",
                    SegundoNombre = "Carlos",
                    PrimerApellido = "Teran",
                    SegundoApellido = "echeverria",
                    Telefono = "0983365228",
                    FechaNacimiento = "1990-02-09",
                    EstadoUSuario = "activo",
                    EstadoMedico = "Activo",
                    Especialidad = "Dermatologo"

                }
            };

            return list;

            //Medico Medico1 = new Medico


            //{
            //    Codigo = 1,
            //    TipoIdentificacion = "1"

            //};


            //return 1;
        }

        [HttpPost]
        [Route("Nuevo")]

        public dynamic GuardarMedico([FromBody] Medicos json)
        {
            List<Medico> list = new List<Medico>
            {
                new Medico
                {
                    Codigo = 1,
                    TipoIdentificacion = "1"

                }
            };

            return list;
        }
    }

    [ApiController]
    [Route("Pacientes")]

    public class Pacientes : Controller
    {
        [HttpGet]
        [Route("Listar")]

        public dynamic Listar()
        {
            List<Paciente> list = new List<Paciente>
            {
                new Paciente
                {
                    Codigo = 1,
                    TipoIdentificacion = "1",
                    Identificaion = "Cedula",
                    PrimerNombre = "Juan",
                    SegundoNombre = "Carlos",
                    PrimerApellido = "Teran",
                    SegundoApellido = "echeverria",
                    Telefono = "0983365228",
                    FechaNacimiento = "1990-02-09",
                    EstadoPaciente = "activo",
                    EstadoUsuario = "Activo",
                    TipoSangre = "Dermatologo"

                }
            };

            return list;
        }

        [HttpGet]
        [Route("Nuevo")]

        public dynamic GuardarMedico()
        {
            List<Medico> list = new List<Medico>
            {
                new Medico
                {
                    Codigo = 1,
                    TipoIdentificacion = "1"

                }
            };

            return list;
        }
    }

    [ApiController]
    [Route("Citas")]

    public class Citas : Controller
    {
        [HttpGet]
        [Route("Listar")]

        public dynamic Listar()
        {
            List<Medico> list = new List<Medico>
            {
                new Medico
                {
                    Codigo = 1,
                    TipoIdentificacion = "1"

                }
            };

            return list;
        }

        [HttpGet]
        [Route("Nuevo")]

        public dynamic GuardarMedico()
        {
            List<Medico> list = new List<Medico>
            {
                new Medico
                {
                    Codigo = 1,
                    TipoIdentificacion = "1"

                }
            };

            return list;
        }
    }

    [ApiController]
    [Route("Usuarios")]

    public class Usuarios : Controller
    {
        [HttpGet]
        [Route("Listar")]

        public dynamic Listar()
        {
            List<UsuarioSys> list = new List<UsuarioSys>
            {
                new UsuarioSys
                {
                    Codigo = 1,
                    TipoIdentificacion = "1",
                    Identificaion = "Cedula",
                    PrimerNombre = "Juan",
                    SegundoNombre = "Carlos",
                    PrimerApellido = "Teran",
                    SegundoApellido = "echeverria",
                    Telefono = "0983365228",
                    FechaNacimiento = "1990-02-09",
                    Estado = "activo",
                    Clave = "12345",
                    Correo = "atoro1@est.ups.edu.ec",
                    Rol = "Administrador"

                }
            };

            return list;
        }

        [HttpPost]
        [Route("Nuevo")]

        public dynamic GuardarMedico()
        {
            List<Medico> list = new List<Medico>
            {
                new Medico
                {
                    Codigo = 1,
                    TipoIdentificacion = "1"

                }
            };

            return list;
        }
    }
}
