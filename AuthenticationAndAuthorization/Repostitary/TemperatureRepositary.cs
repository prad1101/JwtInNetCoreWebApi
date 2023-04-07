using System.Collections.Generic;
using System;


namespace AuthenticationAndAuthorization.Repostitary
{
    public class TemperatureRepositary : ITemperatureRepositary
    {
    

        public async Task<Dictionary<string,string>> GetTemperatureCountries()
        {
            try
            { 
                Dictionary<string, string> countries = new Dictionary<string, string>(){
                {"UK", "-45"},
                {"USA", "-10000"},
                {"India", "12"}
                };
                return countries;
            }
            catch(Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {

            }

        }
        public async Task<Dictionary<string,string>> GetTemperatureStates()
        {
            try
            {
                Dictionary<string, string> states = new Dictionary<string, string>(){
                {"mumbai", "-45"},
                {"rajasthan", "-10000"},
                {"delhi", "12"}
                };
                return states;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {

            }
        }
    }
}
