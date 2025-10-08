using Taller.Application.Abstractions;

namespace Taller.Infrastructure
{
    public class SecretProvider : ISecretProvider
    {
        public string GetSecretAsync(string secretName)
        {
            return "@\"Server=localhost\\SQLEXPRESS;Database=Taller;Trusted_Connection=True;ConnectRetryCount=0";
        }
    }
}
