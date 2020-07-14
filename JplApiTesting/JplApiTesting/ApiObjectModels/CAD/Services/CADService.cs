﻿using JplApiTesting.ApiObjectModels.CAD.DataHandling;
using JplApiTesting.ApiObjectModels.CAD.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JplApiTesting.ApiObjectModels.CAD.Services
{
    //https://ssd-api.jpl.nasa.gov/doc/cad.html
    public abstract class CADService
    {
        public CadLatestCallManager callManager = new CadLatestCallManager();
        public CadLatestDTO dto = new CadLatestDTO();
        public string liveCurrent;
        public JObject json_current;

        public CADService()
        {            
        }

        protected void Setup()
        {
            dto.DeserializeLatestCAD(liveCurrent);
            json_current = JsonConvert.DeserializeObject<JObject>(liveCurrent);
        }       

        internal bool AllDataItemsHaveSameNumOfFields(int numOfFields)
        {
            foreach(List<string> dataItem in dto.LatestCAD.data)
            {
                if (dataItem.Count != numOfFields)
                    return false;
            }
            return true;
        }        
    }
}