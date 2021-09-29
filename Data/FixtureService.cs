using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Policy;

namespace MLFootyWebsite.Data
{
    public class FixtureService
    {
        public List<Fixture> GetPredFixtures()
        {
            List<Fixture> predFixtures = new List<Fixture>();
            //string dataFile = "Data/CombinedPredictions.csv";
            string dataFile = ($"{Directory.GetCurrentDirectory()}/wwwroot/CombinedPredictions.csv");
            //var dataFile = Server.MapPath("../App_Data/CombinedPredictions.csv");

            using (StreamReader sr = new StreamReader(dataFile)){
                while (sr.Peek() > 0){
                    string predFxLn = sr.ReadLine();
                    string[] cells = predFxLn.Split(',');
                    if (cells[0] != "league"){
                        Fixture thisFx = new Fixture();
                        thisFx.FxLeague = cells[0];
                        //thisFx.FxDate = Convert.ToDateTime(cells[1]);
                        thisFx.FxDate = DateTime.Parse(cells[1]).ToString("ddd, dd-MM-yyyy");
                        thisFx.FxHomeTeam = cells[2];
                        thisFx.FxAwayTeam = cells[3];
                        thisFx.FxHomeProb = RndFn(Convert.ToSingle(cells[4]) *100, 1) + " %";
                        thisFx.FxDrawProb = RndFn(Convert.ToSingle(cells[5]) *100, 1) + " %";
                        thisFx.FxAwayProb = RndFn(Convert.ToSingle(cells[6]) *100, 1) + " %";
                        thisFx.FxOverProb = RndFn(Convert.ToSingle(cells[7]) *100, 1) + " %";
                        thisFx.FxUnderProb = RndFn(Convert.ToSingle(cells[8]) *100, 1) + " %";
                        predFixtures.Add(thisFx);
                    }
                }
            }
            return predFixtures;
        }
        public static string RndFn(float value, int dp){
            string formatter = "{0:f" + dp + "}";
            return string.Format(formatter, value);
        }
    }
}