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

        private const char DateTimeSeparator = ' ';
        private const char DateSeparator = '-';
        private const char TimeSeparator = ':';

        private const int DateIndex = 0;
        private const int TimeIndex = 1;

        private const int YearIndex = 0;
        private const int MonthIndex = 1;
        private const int DayIndex = 2;

        private const int HourIndex = 0;
        private const int MinuteIndex = 1;
        private const int SecondIndex = 2;

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
            return int.Parse(GetDataSubElementAt(index, EFields.date)
                .Split(DateTimeSeparator)[DateIndex]
                .Split(DateSeparator)[YearIndex]);
        }

        public int GetMonthAt(in int index)
        {
            return int.Parse(GetDataSubElementAt(index, EFields.date)
                .Split(DateTimeSeparator)[DateIndex]
                .Split(DateSeparator)[MonthIndex]);
        }

        public int GetDayAt(in int index)
        {
            return int.Parse(
                GetDataSubElementAt(index, EFields.date)
                .Split(DateTimeSeparator)[DateIndex]
                .Split(DateSeparator)[DayIndex]);
        }

        public int GetHourAt(in int index)
        {
            return int.Parse(
                GetDataSubElementAt(index, EFields.date)
                .Split(DateTimeSeparator)[TimeIndex]
                .Split(TimeSeparator)[HourIndex]);
        }

        public int GetMinuteAt(int index)
        {
            return int.Parse(
                GetDataSubElementAt(index, EFields.date)
                .Split(DateTimeSeparator)[TimeIndex]
                .Split(TimeSeparator)[MinuteIndex]);
        }

        public int GetSecondAt(int index)
        {
            return int.Parse(
                GetDataSubElementAt(index, EFields.date)
                .Split(DateTimeSeparator)[TimeIndex]
                .Split(TimeSeparator)[SecondIndex]);
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