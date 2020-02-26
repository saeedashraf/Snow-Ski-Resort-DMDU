﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPoint
{
    class Program
    {
        public static string rootFolder;
        public static string avgTmpDir;
        public static string climateFolder;
        public static string[] pcpTxt;
        public static DateTime startFileDate;
        public static DateTime startPeriodDate;
        public static DateTime endPeriodDate;
        public static Dictionary<int, string[]> elevsYear;
        private static double Cperc;
        private static double Dp;
        private static string[] dSnow;
        private static string[] Fm;
        private static string[] Ipot;
        private static string[] rSnow;

        static void Main(string[] args)
        {
            elevsYear = new Dictionary<int, string[]>();
            var outputHeader = "\"DATE\",\"SnowAmount\",\"TotalSnowAmount\",\"isOverSnow\"";
            var outputYears = "\"DATE\",\"isOverSnowTotal\"";

            //var outputStaticVals = ",0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000,0.000";
            Console.WriteLine("Enter inputs folder");
            rootFolder = Console.ReadLine();

            Console.WriteLine("Enter start File Date YYYY/MM/DD");
            var startFileDate = GregorianStringToDate(Console.ReadLine());

            Console.WriteLine("Enter start Period Date YYYY/MM/DD");
            var startPeriodDate = GregorianStringToDate(Console.ReadLine());

            Console.WriteLine("Enter end Period Date YYYY/MM/DD");
            var endPeriodDate = GregorianStringToDate(Console.ReadLine());

            Console.WriteLine("Enter snowAmount (MM)");
            var snowAmount = double.Parse(Console.ReadLine());

            var climateFolder = rootFolder + "\\input\\Climate_ref\\";
            var ablationFolder = rootFolder + "\\input\\Ablation\\";
            var accumulationFolder = rootFolder + "\\input\\Accumulation\\";

            var outputDir = rootFolder + "\\Outputs";
            Directory.CreateDirectory(outputDir);



            dSnow = String.Join(",", File.ReadAllLines(accumulationFolder + "Sub_grids_Dsnow1.txt").Select(x => String.Join(",", x.Replace("\t", " ").Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))).ToList()).Split(',');
            Fm = String.Join(",", File.ReadAllLines(ablationFolder + "Sub_grids_FM1.txt").Select(x => String.Join(",", x.Replace("\t", " ").Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))).ToList()).Split(',');
            Ipot = String.Join(",", File.ReadAllLines(ablationFolder + "Sub_grids_Ipot1.txt").Select(x => String.Join(",", x.Replace("\t", " ").Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))).ToList()).Split(',');
            rSnow = String.Join(",", File.ReadAllLines(ablationFolder + "Sub_grids_Rsnow1.txt").Select(x => String.Join(",", x.Replace("\t", " ").Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries))).ToList()).Split(',');

            var Accumulation_inputs = File.ReadAllLines(accumulationFolder + "Accumulation_inputs.txt");
            Cperc = double.Parse(Accumulation_inputs[1]);
            Dp = double.Parse(Accumulation_inputs[3]);



            //var subs = new Dictionary<string, List<int>>();
            //var tmpGrids = new Dictionary<string, List<int>>();
            //var pcpGrids = new Dictionary<string, List<int>>();
            //var pcps = new Dictionary<string, string>();
            //var tmps = new Dictionary<string, string>();
            var tmpFilesExist = Directory.GetFiles(climateFolder, "*t.txt");
            //foreach(var tmpFile in tmpFilesExist)
            //{
            //    if (!File.Exists(tmpFile.Replace("t.txt", "p.txt")))
            //    {
            //        break;
            //    }
            //    var tmpLines=File.ReadAllLines(tmpFile);
            //    var endFileDate = startFileDate.AddDays(tmpLines.Length - 1);
            //    var endYear = endFileDate.Year;
            //    var startYear = startFileDate.Year;
            //    var indDay = 1;
            //    var sumYear = 0.0;
            //    var dayOfYear = 0;
            //    var currentYear = startYear;
            //    var avgYearLines = new List<string>();
            //    while (indDay< tmpLines.Length)
            //    {
            //        var cTmp = tmpLines[indDay].Split(',');
            //        var currentDay = startFileDate.AddDays(indDay - 1);
            //        if (currentYear != currentDay.Year)
            //        {
            //            //endOfCurrentYear
            //            var avgOfYear = sumYear / dayOfYear;
            //            avgYearLines.Add(currentYear + " " + avgOfYear.ToString("N3"));

            //            //start of new year
            //            currentYear++;
            //            sumYear = 0.0;
            //            dayOfYear = 0;

            //        }
            //        sumYear += (double.Parse(cTmp[0]) + double.Parse(cTmp[1])) / 2;
            //        dayOfYear++;
            //        indDay++;
            //    }
            //    File.WriteAllLines(avgTmpDir+"\\"+ tmpFile.Split('\\').LastOrDefault(), avgYearLines);
            //}

            //for (int i = 0; i < tmpGridsFile.Length; i += 2)
            //{
            //    tmpGrids.Add(tmpGridsFile[i], tmpGridsFile[i + 1].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x =>x=="*"?0: int.Parse(x)).ToList());
            //}
            //for (int i = 0; i < pcpGridsFile.Length; i += 2)
            //{
            //    pcpGrids.Add(pcpGridsFile[i], pcpGridsFile[i + 1].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(x => x == "*" ? 0 : int.Parse(x)).ToList());
            //}
            //var prevGrid= GridMinus(aleFirstElevFile, aleLastElevFile, aleBedrockElevFile, aleFirst, aleLast, startPeriodDate.Year);
            //Console.WriteLine("aletsch_dem_" + startPeriodDate.Year + " was created");
            //for (int i = startPeriodDate.Year+1; i <= endPeriodDate.Year; i++)
            //{

            //    prevGrid = GridMinus2(aleFirstElevFile, aleLastElevFile, aleBedrockElevFile, tmpGrids, pcpGrids, aleFirst, aleLast, i, prevGrid);
            //    Console.WriteLine("aletsch_dem_" + i + " was created");
            //}

            pcpTxt = File.ReadAllLines(climateFolder + "pcp.txt");
            var tmpTxt = File.ReadAllLines(climateFolder + "tmp.txt");

            var startDayIndex = (startPeriodDate - startFileDate).Days;
            var endDayIndex = (endPeriodDate - startFileDate).Days;

            foreach (var tmpFile in tmpFilesExist)
            {
                if (!File.Exists(tmpFile.Replace("t.txt", "p.txt")))
                {
                    break;
                }
                var subKey = tmpFile.Split('\\').LastOrDefault().Replace("t.txt", "");
                var cliamteRefPcp = File.ReadAllLines(climateFolder + subKey + "p.txt");
                var cliamteRefTmp = File.ReadAllLines(climateFolder + subKey + "t.txt");
                var elevRef = double.Parse(pcpTxt.SingleOrDefault(x => x.Contains(subKey)).Split(',').LastOrDefault());
                var snowYearLines = outputYears + Environment.NewLine;
                var totalLines = outputHeader + Environment.NewLine;
                var itemIndex = 1;
                var snowAmountsYear = 0;
                var currentYear = startPeriodDate.Year;
                for (int i = 0; i < dSnow.Length; i++)
                {
                    if (dSnow[i].Contains(subKey))
                    {
                        itemIndex = i + 1;
                        break;
                    }

                }
                double totalSolid = 0;
                double totalMelt = 0;
                double totalSnow = 0;
                for (int day = startDayIndex + 1; day <= endDayIndex; day++)
                {
                    var currentDay = startFileDate.AddDays(day - 1);
                    if (currentYear != currentDay.Year)
                    {
                        //write to file snowAmountsYear of the currentYear;
                        snowYearLines += currentYear + "," + snowAmountsYear + Environment.NewLine;
                        snowAmountsYear = 0;
                        currentYear = currentDay.Year;
                    }

                    var isnowAmountBreak = false;
                    if (cliamteRefPcp[day].Contains("-99") || cliamteRefTmp[day].Contains("-99"))
                    {
                        continue;
                    }
                    var pRef = double.Parse(cliamteRefPcp[day]);
                    var tRefs = cliamteRefTmp[day].Split(',');
                    var avgTmp = (double.Parse(tRefs[0]) + double.Parse(tRefs[1])) / 2;
                    var rs = avgTmp <= -1 ? 1 : avgTmp >= 1 ? 0 : ((1 - avgTmp) / 2);

                    //foreach (var item in grisItems)
                    //{
                    var elevI = elevRef;// double.Parse(currentYearElevs[item - 1]);
                    var dsnowI = double.Parse(dSnow[itemIndex]);

                    double pSolid = ((pRef * (1 + Cperc)) + (((elevI - elevRef) / 1000) * Dp)) * dsnowI * rs;
                    totalSolid += pSolid;

                    //melt

                    var fmI = double.Parse(Fm[itemIndex]);
                    var IpotI = double.Parse(Ipot[itemIndex]);
                    var rSnowI = double.Parse(rSnow[itemIndex]);

                    double MeltI = (fmI + (rSnowI * (IpotI / 100))) * avgTmp;
                    totalMelt += MeltI;
                    var solidMelt = pSolid - MeltI > 0 ? pSolid - MeltI : 0;
                    totalSnow += solidMelt;


                    if (totalSnow >= snowAmount)
                    {
                        snowAmountsYear++;
                        isnowAmountBreak = true;
                    }
                    //}
                    //write to output
                    totalLines += startFileDate.AddDays(day - 1).ToString("MM/dd/yyyy") + "," + (solidMelt) + "," + (totalSnow) + "," + isnowAmountBreak + Environment.NewLine;


                }
                snowYearLines += currentYear + "," + snowAmountsYear + Environment.NewLine;

                var outputFilesnowYear = outputDir + "\\" + "snowYear_" + subKey + ".csv";
                File.WriteAllText(outputFilesnowYear, snowYearLines);

                var outputFileTotal = outputDir + "\\" + "Total_" + subKey + ".csv";
                File.WriteAllText(outputFileTotal, totalLines);
            }

            Console.WriteLine("End!");
            Console.ReadLine();
        }




        public static DateTime GregorianStringToDate(string date)
        {

            char spiliter = '-';
            if (date.Contains("/"))
            {
                spiliter = '/';
            }
            var ymd = date.Split(spiliter);
            var Date = new DateTime(int.Parse(ymd[0]), int.Parse(ymd[1]), int.Parse(ymd[2]), 0, 0, 0);
            return Date;


        }

    }
}
