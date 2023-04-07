namespace AuthenticationAndAuthorization.Repostitary
{
    public interface ITemperatureRepositary
    {
        Task<Dictionary<string,string>> GetTemperatureCountries();
        Task<Dictionary<string, string>> GetTemperatureStates();


    }
}
