using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Klimatyzacja
{
    class SecondThreadConcern
    {
        private static int RoomT;
        private static int DesiredT;
        private static int[] OutsideT = new int[1440];
        private static double MaterialQ;
        private static int AirConT;
        private static int Heating;

        private static bool DoNutUpdate = false;
        

        private static bool staph = false;
        public static void LongWork(IProgress<string> s0, string s1, string s2, string s3, IProgress<int> roomT, int roomTi, IProgress<string> roomTbox, IProgress<int> desiredT, int desiredTi, IProgress<int> heating,int heatingi, int[] outsideT, IProgress<string> outsidebox, IProgress<int> airconT, int airconTi, IProgress<string> airconbox, double materialQ)
        {
            staph = true;
            int roomTin = roomTi;
            int desiredTin = desiredTi;
            int heatingin = heatingi;
            int airconTin = airconTi;
            int[] outsidein = outsideT;
            int looper = -1;
            int loopertest = -20;
            int diff;
            int change;
            int fiveloop = 0;
            bool roomupdate = false;
            bool airupdate = true;
            int stan = 1;

            // Perform a long running work...
            while (staph)
            {
               

                diff = roomTin - desiredTin;

                looper = looper + 1;

                if(looper == 1440)
                {
                    looper = 0;
                }

                Logic.GenerateValues();
                var results = Logic.Process(diff);

                if (fiveloop == 4)
                {
                    if (stan == 1)
                    {
                        //ustwienie temperatury aircon w zaleznosci od wychylenia heating
                        if ((int)results[0] > 40)
                        {
                            airconTin = roomTin + 5;
                        }
                        else if ((int)results[0] > 25)
                        {
                            airconTin = roomTin + 3;
                        }
                        else if ((int)results[0] > 15)
                        {
                            airconTin = roomTin + 2;

                        }
                        else if ((int)results[0] > 0)
                        {
                            airconTin = roomTin + 1;

                        }
                        else if ((int)results[0] == 0)
                        {
                            airconTin = roomTin;

                        }
                        else if ((int)results[0] < 0 && (int)results[0] > 15)
                        {
                            airconTin = roomTin - 1;

                        }
                        else if ((int)results[0] <= -15 && (int)results[0] > -25)
                        {
                            airconTin = roomTin - 2;

                        }
                        else if ((int)results[0] <= -25 && (int)results[0] > -40)
                        {
                            airconTin = roomTin - 3;

                        }
                        else if ((int)results[0] <= -40)
                        {
                            airconTin = roomTin - 5;

                        }
                        stan = 2;
                        airconbox.Report(airconTin.ToString());
                    }


                    if (stan == 3)
                    {
                        change = airconTin - roomTin;
                        //zmiana temperatury room w zaleznosci od roznicy meidzy airconT a roomT
                        if (change == -5)
                        {
                            roomTin = roomTin - 3;
                        }
                        else if (change == -4)
                        {
                            roomTin = roomTin - 2;
                        }
                        else if (change == -3)
                        {
                            roomTin = roomTin - 2;
                        }
                        else if (change == -2)
                        {
                            roomTin = roomTin - 1;
                        }
                        else if (change == -1)
                        {
                            roomTin = roomTin - 1;
                        }
                        else if (change == 0)
                        {
                            roomTin = roomTin + 0;
                        }
                        else if (change == 1)
                        {
                            roomTin = roomTin + 1;
                        }
                        else if (change == 2)
                        {
                            roomTin = roomTin + 1;
                        }
                        else if (change == 3)
                        {
                            roomTin = roomTin + 2;
                        }
                        else if (change == 4)
                        {
                            roomTin = roomTin + 2;
                        }
                        else if (change == 5)
                        {
                            roomTin = roomTin + 3;
                        }

                        stan = 1;
                    }

                    if(stan == 2)
                    {
                        stan = 3;
                    }

                    roomT.Report(roomTin);
                    desiredT.Report(desiredTin);
                    roomTbox.Report(roomTin.ToString());
                    outsidebox.Report(outsidein[looper].ToString());
                    if (looper < 5)
                    {
                        s0.Report("Outside: " + outsidein[looper].ToString() + " Inside: " + roomTin.ToString() + " Conditioning: OFF" + " Time: " + (int)looper / 60 + ":0" + (looper % 60 + 1) + "\n");
                    }
                    else if (looper % 60 < 9)
                    {
                        s0.Report("Outside: " + outsidein[looper].ToString() + " Inside: " + roomTin.ToString() + " Conditioning: " + airconTin.ToString() + " Time: " + (int)looper / 60 + ":0" + (looper % 60 + 1) + "\n");
                    }
                    else
                        s0.Report("Outside: " + outsidein[looper].ToString() + " Inside: " + roomTin.ToString() + " Conditioning: " + airconTin.ToString() + " Time: " + (int)looper / 60 + ":" + (looper % 60 + 1) + "\n");

                    fiveloop = 0;

                }
                else
                {
                    fiveloop = fiveloop + 1;
                }


               
                
                Console.WriteLine("Wychylenie to " + results[0]);
                heating.Report((int)(results[0]));
                Task.Delay(1000).Wait();
                DoNutUpdate = false;
            }
        }

        public static void Staph()
        {
            staph = false;
        }

        public static void setRoomT(int roomT)
        {
            DoNutUpdate = true;
            RoomT = roomT;
        }

        public static void setDesiredT(int desiredT)
        {
            DoNutUpdate = true;
            DesiredT = desiredT;
        }

        public static void setOutsideT(int[] outsideT)
        {
            DoNutUpdate = true;
            OutsideT = outsideT;
        }

        public static void setMaterialQ(double materialQ)
        {
            DoNutUpdate = true;
            MaterialQ = materialQ;
        }

        public static void setAirConT(int airconT)
        {
            DoNutUpdate = true;
            AirConT = airconT;
        }

        public static void setHeating(int heating)
        {
            DoNutUpdate = true;
            Heating = heating;
        }

    }
}
