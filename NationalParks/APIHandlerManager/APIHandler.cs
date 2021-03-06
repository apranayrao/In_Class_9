﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using NationalParks.Models;

namespace NationalParks.APIHandlerManager
{
    public class APIHandler
    {
        // Obtaining the API key is easy. The same key should be usable across the entire
        // data.gov developer network, i.e. all data sources on data.gov.
        // https://www.nps.gov/subjects/developer/get-started.htm

        //  static string BASE_URL = "?api_key=Uyij4Wif5gsZEfW4IrxqZ3nltyJeuu0EN1uxBhSO";
        static string BASE_URL = "https://api.fda.gov/animalandveterinary/event.json?api_key=S9Sr7PhD9sy9uuZ9YmAkkJ47KpRaaBeiEMIRsBVV";
        static string API_KEY = "S9Sr7PhD9sy9uuZ9YmAkkJ47KpRaaBeiEMIRsBVV"; //Add your API key here inside ""
        HttpClient httpClient;

        /// <summary>
        ///  Constructor to initialize the connection to the data source
        /// </summary>
        public APIHandler()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Method to receive data from API end point as a collection of objects
        /// 
        /// JsonConvert parses the JSON string into classes
        /// </summary>
        /// <returns></returns>
        public Parks GetData()
        {
            string DRUG_PATH = BASE_URL + "&limit=100";
            string resutlsdata = "";

            Parks results = null;

            httpClient.BaseAddress = new Uri(DRUG_PATH);

            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(DRUG_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    resutlsdata = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!resutlsdata.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    results = JsonConvert.DeserializeObject<Parks>(resutlsdata);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return results;
        }
    }
}