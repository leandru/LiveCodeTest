namespace Taller.Application.Abstractions
{
    public interface ISecretProvider
    {
        string GetSecretAsync(string secretName);
    }
}
