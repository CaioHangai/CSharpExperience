

namespace SistemaHospedagem.Models.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string menssagem) : base(menssagem)
        {

        }
    }
}
