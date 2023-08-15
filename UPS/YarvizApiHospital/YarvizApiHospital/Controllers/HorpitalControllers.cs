
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
                    TipoIdentificacion = "1"

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
    [Route("Pacientes")]

    public class Pacientes : Controller
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
}
