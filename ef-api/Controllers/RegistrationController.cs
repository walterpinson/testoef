using System;
using System.Web.Http;
using Core.Application.Messages;
using Core.Application.Services;

namespace ef_api.Controllers
{
    [RoutePrefix("api/registrations")]
    public class RegistrationController : ApiController
    {
        private readonly IRegistrar _registrar;

        public RegistrationController(IRegistrar registrar)
        {
            _registrar = registrar;
        }

        [HttpPost, Route("")]
        public IHttpActionResult Post(NewAcceptanceMessage message)
        {
            var registration = _registrar.Rsvp(message);
            var location = $"http://{Request.RequestUri.Host}/api/registrations/{registration.Id.ToString()}";

            return Created<Object>(location, new {});
        }

        [HttpGet, Route("")]
        public IHttpActionResult Get()
        {
            // add a useless comment
            var registrations = _registrar.GetRegistrations();
            return Ok(registrations);
        }
    }
}
