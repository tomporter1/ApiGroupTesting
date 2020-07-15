using JplApiTesting.ApiObjectModels.Fireball.DataHandling;
using JplApiTesting.ApiObjectModels.Fireball.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using static JplApiTesting.ApiObjectModels.Fireball.DataHandling.FireballModel;

namespace JplApiTesting.ApiObjectModels.Fireball.Services
{
    public class FireballService
    {
        public FireballManager fireballManager = new FireballManager();
        public FireballDTO fireballDTO = new FireballDTO();

        public string fireballReport;
        public JObject json_report;

        public FireballService(in int desiredLimit = 0)
        {
            fireballReport = fireballManager.GetReport(desiredLimit);
            fireballDTO.DeserialiseLatest(fireballReport);
            json_report = JsonConvert.DeserializeObject<JObject>(fireballReport);
        }

        public List<string> GetFields()
        {
            return fireballDTO.LatestReport.fields;
        }

        public List<List<string>> GetData()
        {
            return fireballDTO.LatestReport.data;
        }

        public List<string> GetDataElementAt(in int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return fireballDTO.LatestReport.data[index];
        }

        public string GetDataSubElementAt(in int index, in EFields field)
        {
            return GetDataElementAt(index)[(int)field];
        }

        public int GetYearAt(in int index)
        {
            const int dateIndex = 0;
            const int yearIndex = 0;
            return int.Parse(GetDataSubElementAt(index, EFields.date).Split(' ')[dateIndex].Split('-')[yearIndex]);
        }

        public int GetMonthAt(in int index)
        {
            const int dateIndex = 0;
            const int monthIndex = 1;
            return int.Parse(GetDataSubElementAt(index, EFields.date).Split(' ')[dateIndex].Split('-')[monthIndex]);
        }

        public int GetDayAt(in int index)
        {
            const int dateIndex = 0;
            const int dayIndex = 2;
            return int.Parse(GetDataSubElementAt(index, EFields.date).Split(' ')[dateIndex].Split('-')[dayIndex]);
        }

        public int GetCount()
        {
            return json_report.Value<int>("count");
        }

        public Signature GetSignature()
        {
            return fireballDTO.LatestReport.signature;
        }
    }
}