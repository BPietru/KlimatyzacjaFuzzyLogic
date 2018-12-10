using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klimatyzacja

{


    class Logic
    {
        public static Term Temperature = new Term();
        public static Term HeatOutput = new Term();


        public static double Fuzz(List<TermValues> activators, int input)
        {
            return activators.Where(x => x.Value == input)
                .Select(x => x.Level)
                .FirstOrDefault();
        }

        public static List<TermValues> Conclude(double level, List<TermValues> activators)
        {
            var output = new List<TermValues>();
            output.AddRange(activators);
            output.ForEach(x => x.Level = Math.Min(x.Level, level));

            return output;
        }

        public static List<TermValues> Aggregate(params List<TermValues>[] activators)
        {
            var output = activators.First();

            activators.Skip(1).ToList().ForEach(list =>
            {
                output = output.Join(list, a => a.Value, b => b.Value, (a, b) => a.Level > b.Level ? a : b).ToList();
            });

            return output;
        }

        public static double Sharpen(List<TermValues> activator)
        {
            double sum = activator.Sum(x => x.Level * x.Value);
            double divider = activator.Sum(x => x.Level);

            if (divider == 0 || sum == 0)
                return 0;

            return sum / divider;
        }

        public static double[] Process(int temperature)
        {
            double[] results = new double[1];

            double verylowLevel;
            double lowLevel;
            double zeroLevel;
            double mediumLevel;
            double highLevel;

            List<TermValues> fuzzVeryLow;
            List<TermValues> fuzzLow;
            List<TermValues> fuzzZero;
            List<TermValues> fuzzMedium;
            List<TermValues> fuzzHigh;

            List<TermValues> output;

            #region Temperature->HeatOutput

            verylowLevel = Fuzz(Temperature.Values["Very_Low"], temperature);
            lowLevel = Fuzz(Temperature.Values["Low"], temperature);
            zeroLevel = Fuzz(Temperature.Values["Zero"], temperature);
            mediumLevel = Fuzz(Temperature.Values["Medium"], temperature);
            highLevel = Fuzz(Temperature.Values["High"], temperature);


            fuzzVeryLow = Conclude(highLevel, HeatOutput.Values["Very_Low"]);
            fuzzLow = Conclude(mediumLevel, HeatOutput.Values["Low"]);
            fuzzZero = Conclude(zeroLevel, HeatOutput.Values["Zero"]);
            fuzzMedium = Conclude(lowLevel, HeatOutput.Values["Medium"]);
            fuzzHigh = Conclude(verylowLevel, HeatOutput.Values["High"]);

            output = Aggregate(fuzzVeryLow, fuzzLow, fuzzZero, fuzzMedium, fuzzHigh);

            results[0] = Sharpen(output);

            #endregion

            return results;
        }

        public static void GenerateValues()         // INPUT czyli różnica temperatur ( jak w pokoju jest 30 stopni i użytkownik chce 10 to różnica = 20)
        {
            Temperature.Values["Very_Low"] = new List<TermValues>();
            Temperature.Values["Low"] = new List<TermValues>();
            Temperature.Values["Zero"] = new List<TermValues>();
            Temperature.Values["Medium"] = new List<TermValues>();
            Temperature.Values["High"] = new List<TermValues>();

            for (int i = -20; i <= 20; i++)
            {
                var a = new TermValues(0, i);

                if (i >= -20 && i < -15)
                {
                    a.Level = 1;
                }
                else if (i >= -15 && i <= -10)
                {
                    a.Level = (-10 - (float)i) / (-10 + 15);   //(-(-15))
                }
                else
                {
                    a.Level = 0;
                }
                Temperature.Values["Very_Low"].Add(a);
            }

            for (int i = -20; i <= 20; i++)
            {
                var a = new TermValues(0, i);

                if (i >= -13 && i < -9)
                {
                    a.Level = ((float)i + 13) / (-9 + 13);
                }
                else if (i >= -9 && i <= -4)
                {
                    a.Level = 1;
                }
                else if (i > -4 && i <= 0)
                {
                    a.Level = (0 - (float)i) / (0 + 4);
                }
                else
                {
                    a.Level = 0;
                }
                Temperature.Values["Low"].Add(a);
            }

            for (int i = -20; i <= 20; i++)
            {
                var a = new TermValues(0, i);

                if (i >= -1 && i < 0)
                {
                    a.Level = ((float)i + 1) / (0 + 1);
                }
                else if (i >= 0 && i <= 1)
                {
                    a.Level = (1 - (float)i) / (1 - 0);
                }
                else
                {
                    a.Level = 0;
                }
                Temperature.Values["Zero"].Add(a);
            }

            for (int i = -20; i <= 20; i++)
            {
                var a = new TermValues(0, i);

                if (i >= 0 && i < 4)
                {
                    a.Level = ((float)i - 0) / (4 - 0);
                }
                else if (i >= 4 && i <= 9)
                {
                    a.Level = 1;
                }
                else if (i > 9 && i <= 13)
                {
                    a.Level = (13 - (float)i) / (13 - 9);
                }
                else
                {
                    a.Level = 0;
                }
                Temperature.Values["Medium"].Add(a);
            }

            for (int i = -20; i <= 20; i++)
            {
                var a = new TermValues(0, i);

                if (i >= 10 && i < 15)
                {
                    a.Level = ((float)i - 10) / (15 - 10);
                }
                else if (i >= 15 && i <= 20)
                {
                    a.Level = 1;
                }
                else
                {
                    a.Level = 0;
                }
                Temperature.Values["High"].Add(a);
            }

            // Output 
            HeatOutput.Values["Very_Low"] = new List<TermValues>();
            HeatOutput.Values["Low"] = new List<TermValues>();
            HeatOutput.Values["Zero"] = new List<TermValues>();
            HeatOutput.Values["Medium"] = new List<TermValues>();
            HeatOutput.Values["High"] = new List<TermValues>();



            for (int i = -75; i <= 75; i++)
            {
                var a = new TermValues(0, i);

                if (i >= -75 && i < -60)
                {
                    a.Level = ((float)i + 75) / (-60 + 75);
                }
                else if (i >= -60 && i < -35)
                {
                    a.Level = 1;
                }
                else if (i >= -35 && i < -25)
                {
                    a.Level = (-25 - (float)i) / (-25 + 35);
                }
                else
                {
                    a.Level = 0;
                }
                HeatOutput.Values["Very_Low"].Add(a);
            }
            for (int i = -75; i <= 75; i++)
            {
                var a = new TermValues(0, i);

                if (i >= -35 && i <= -25)
                {
                    a.Level = ((float)i + 35) / (-25 + 35);
                }
                else if (i > -25 && i <= -15)
                {
                    a.Level = 1;
                }
                else if (i > -15 && i <= 0)
                {
                    a.Level = (0 - (float)i) / (0 + 15);
                }
                else
                {
                    a.Level = 0;
                }
                HeatOutput.Values["Low"].Add(a);
            }
            for (int i = -75; i <= 75; i++)
            {
                var a = new TermValues(0, i);

                if (i >= -5 && i < 0)
                {
                    a.Level = ((float)i + 5) / (0 + 5);
                }
                else if (i >= 0 && i <= 5)
                {
                    a.Level = (5 - (float)i) / (5 - 0);
                }
                else
                {
                    a.Level = 0;
                }
                HeatOutput.Values["Zero"].Add(a);
            }
            for (int i = -75; i <= 75; i++)
            {
                var a = new TermValues(0, i);

                if (i > 0 && i <= 15)
                {
                    a.Level = ((float)i - 0) / (15 - 0);
                }
                else if (i >= 15 && i < 25)
                {
                    a.Level = 1;
                }
                else if (i >= 25 && i < 35)
                {
                    a.Level = (35 - (float)i) / (35 - 25);
                }
                else
                {
                    a.Level = 0;
                }
                HeatOutput.Values["Medium"].Add(a);
            }
            for (int i = -75; i <= 75; i++)
            {
                var a = new TermValues(0, i);

                if (i > 25 && i <= 35)
                {
                    a.Level = ((float)i - 25) / (35 - 25);
                }
                else if (i > 35 && i <= 60)
                {
                    a.Level = 1;
                }
                else if (i > 60 && i <= 75)
                {
                    a.Level = (75 - (float)i) / (75 - 60);
                }
                else
                {
                    a.Level = 0;
                }
                HeatOutput.Values["High"].Add(a);
            }
        }
    }


}