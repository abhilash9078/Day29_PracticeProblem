﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using IndianStatesCensusAnalyser.POCO;
using Newtonsoft.Json;

namespace IndianStatesCensusAnalyser
{
    public  class CensusAnalyser
    {
        /// <summary>
        /// Enum for Country
        /// </summary>
        public enum Country
        {
            INDIA , US, BRAZIL
        }
        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataHeaders)
        {   
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}
