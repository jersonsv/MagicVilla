using MagicVilla_Utilidad;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using Microsoft.Extensions.Configuration;

namespace MagicVilla_Web.Services
{
    public class UsuarioService : BaseService, IUsuarioService
    {
        private readonly IHttpClientFactory _httpCliente;
        private string _villaUrl;

        public UsuarioService(IHttpClientFactory httpCliente, IConfiguration configuration) : base(httpCliente)
        {
            _httpCliente = httpCliente;
            _villaUrl = configuration.GetValue<string>("ServiceUrls:API_URL");
        }

        public Task<T> Login<T>(LoginRequestDto dto)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                APITipo = DS.APITipo.POST,
                Datos = dto,
                Url = _villaUrl + "/api/v1/usuario/login"
            });
        }

        public Task<T> Registrar<T>(RegistroRequestDto dto)
        {
            return SendAsync<T>(new Models.APIRequest()
            {
                APITipo = DS.APITipo.POST,
                Datos = dto,
                Url = _villaUrl + "/api/v1/usuario/registrar"
            });
        }
    }
}
