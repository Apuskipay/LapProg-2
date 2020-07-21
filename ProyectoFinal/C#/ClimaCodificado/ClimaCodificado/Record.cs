using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace ClimaCodificado
{
    class Record
    {
        //64b
        public string dateAndTime;

        public string YYYY;//Year
        public string MM;//Month
        public string dd;//Day
        
        public string HH24;//24h format
        public string mm;//Minute
        public string ss;//Seconds
        public string fff;//Miliseconds
        public string GMT_Symbol; // + -
        public string GMTH;//Global TimeZone hour
        public string GMTM;//Global TimeZone minutes

        //32b 
        public string climate;

        public string minTemp;
        public string maxTemp;
        public string precipitation;

        public static Record FromCsv(string csvLine)
        {
            char[] dateAndTimeArray;

            string[] values = csvLine.Split(',');
            Record record = new Record();

            record.dateAndTime = values[0];
            dateAndTimeArray = record.dateAndTime.ToCharArray();

            record.YYYY = Convert.ToString(dateAndTimeArray[0]) + Convert.ToString(dateAndTimeArray[1]) + Convert.ToString(dateAndTimeArray[2]) + Convert.ToString(dateAndTimeArray[3]);
            record.MM = Convert.ToString(dateAndTimeArray[5]) + Convert.ToString(dateAndTimeArray[6]);
            record.dd = Convert.ToString(dateAndTimeArray[8]) + Convert.ToString(dateAndTimeArray[9]);

            record.HH24 = Convert.ToString(dateAndTimeArray[11]) + Convert.ToString(dateAndTimeArray[12]);
            record.mm = Convert.ToString(dateAndTimeArray[14]) + Convert.ToString(dateAndTimeArray[15]);
            record.ss = Convert.ToString(dateAndTimeArray[17]) + Convert.ToString(dateAndTimeArray[18]);
            record.fff = Convert.ToString(dateAndTimeArray[20]) + Convert.ToString(dateAndTimeArray[21]) + Convert.ToString(dateAndTimeArray[22]);

            record.GMT_Symbol = Convert.ToString(dateAndTimeArray[23]);

            record.GMTH = Convert.ToString(dateAndTimeArray[24]) + Convert.ToString(dateAndTimeArray[25]);
            record.GMTM = Convert.ToString(dateAndTimeArray[27]) + Convert.ToString(dateAndTimeArray[28]);
            
            record.minTemp = values[1];
            record.maxTemp = values[2];
            record.precipitation = values[3];

            return record;
        }
        public static void Encode(string encodeInput, string encodeOutput)
        {
            if (!File.Exists(encodeOutput))
            {
                using (StreamWriter file = new StreamWriter("EncodeOutput.csv", true))
                {
                    file.WriteLine("DateAndTime,Climate");
                }
            }
            List<Record> RecordList = File.ReadAllLines(encodeInput).Skip(1).Select(v => Record.FromCsv(v)).ToList();
            foreach (Record record in RecordList)
            {
                //64b
                record.YYYY = ToBinary(record.YYYY, 12);
                record.MM = ToBinary(record.MM, 4);
                record.dd = ToBinary(record.dd, 5);
                record.HH24 = ToBinary(record.HH24, 5);
                record.mm = ToBinary(record.mm, 6);
                record.ss = ToBinary(record.ss, 6);
                record.fff = ToBinary(record.fff, 10);
                if (record.GMT_Symbol == "+")
                {
                    record.GMT_Symbol = "1";
                }
                else if (record.GMT_Symbol == "-")
                {
                    record.GMT_Symbol = "0";
                }
                else
                {
                    Console.WriteLine("Error en el formato de la fecha");
                }
                record.GMTH = ToBinary(record.GMTH, 5);
                record.GMTM = ToBinary(record.GMTM, 6);

                record.dateAndTime = record.YYYY + record.MM + record.dd + record.HH24 + record.mm + record.ss + record.fff + record.GMT_Symbol + record.GMTH + record.GMTM;

                record.dateAndTime = ToDecimal(record.dateAndTime);

                //32b
                record.minTemp = ToBinary(record.minTemp, 7);
                record.maxTemp = ToBinary(record.maxTemp, 7);
                record.precipitation = ToBinary(record.precipitation, 7);

                record.climate = record.minTemp + record.maxTemp + record.precipitation;
                record.climate = ToDecimal(record.climate);

                //Registro
                using (StreamWriter file = new StreamWriter(encodeOutput, true))
                {
                    file.WriteLine(record.dateAndTime + "," + record.climate);
                }
            }
        }
        public static void Decode(string decodeInput, string decodeOutput)
        {
            if (!File.Exists(decodeOutput))
            {
                using (StreamWriter file = new StreamWriter(decodeOutput, true))
                {
                    file.WriteLine("DateAndTime,MinTemp,MaxTemp,Precipitation");
                }
            }


            string[] records = File.ReadAllLines(decodeInput);
            for (int i = 1; i < records.Length - 1; i++)
            {
                Record record = new Record();

                string[] fields = records[i].Split(',');

                fields[0] = ToBinary(fields[0], 60);

                char[] date = fields[0].ToCharArray();

                for (int x = 0; x < 12; x++)//year
                {
                    record.YYYY = record.YYYY + date[x];
                }
                for (int x = 12; x < 16; x++)//month
                {
                    record.MM = record.MM + date[x];
                }
                for (int x = 16; x < 21; x++)//day
                {
                    record.dd = record.dd + date[x];
                }
                for (int x = 21; x < 26; x++)//hour
                {
                    record.HH24 = record.HH24 + date[x];
                }
                for (int x = 26; x < 32; x++)//minute
                {
                    record.mm = record.mm + date[x];
                }
                for (int x = 32; x < 38; x++)//second
                {
                    record.ss = record.ss + date[x];
                }
                for (int x = 38; x < 48; x++)//millisecond
                {
                    record.fff = record.fff + date[x];
                }
                if (date[48] == '0')
                {
                    record.GMT_Symbol = "-";
                }
                else if (date[48] == '1')
                {
                    record.GMT_Symbol = "+";
                }
                for (int x = 49; x < 54; x++)//tz hour
                {
                    record.GMTH = record.GMTH + date[x];
                }
                for (int x = 54; x < 60; x++)//tz minute
                {
                    record.GMTM = record.GMTM + date[x];
                }

                record.YYYY = ToDecimal(record.YYYY);
                record.MM = ToDecimal(record.MM);
                record.dd = ToDecimal(record.dd);
                record.HH24 = ToDecimal(record.HH24);
                record.mm = ToDecimal(record.mm);
                record.ss = ToDecimal(record.ss);
                record.fff = ToDecimal(record.fff);
                record.GMTH = ToDecimal(record.GMTH);
                record.GMTM = ToDecimal(record.GMTM);

                record.dateAndTime = record.YYYY + "-" + record.MM + "-" + record.dd + "T" + record.HH24 + ":" + record.mm + ":" + record.ss + "." + record.fff + record.GMT_Symbol + record.GMTH + ":" + record.GMTM;

                fields[1] = ToBinary(fields[1], 21);
                char[] climate = fields[1].ToCharArray();

                for (int x = 0; x < 7; x++)
                {
                    record.minTemp = record.minTemp + climate[x];
                }
                for (int x = 7; x < 14; x++)
                {
                    record.maxTemp = record.maxTemp + climate[x];
                }
                for (int x = 14; x < 21; x++)
                {
                    record.precipitation = record.precipitation + climate[x];
                }

                record.minTemp = ToDecimal(record.minTemp);
                record.maxTemp = ToDecimal(record.maxTemp);
                record.precipitation = ToDecimal(record.precipitation);

                using (StreamWriter file = new StreamWriter(decodeOutput, true))
                {
                    file.WriteLine(record.dateAndTime + "," + record.minTemp + "," + record.maxTemp + "," + record.precipitation);
                }
            }
            Console.WriteLine("Los registros han sido decodificados");
        }
        public static string ToBinary(string dec, int size)
        {
            string binary = null;
            long num = Convert.ToInt64(dec);

            for (int i = size - 1; i >= 0; i--)
            {
                long k = num >> i;
                if ((k & 1) > 0)
                {
                    binary = binary + 1;
                }
                else
                {
                    binary = binary + 0;
                }
            }
            return binary;
        }
        public static string ToDecimal(string bin)
        {
            BigInteger result = 0;
            foreach (var c in bin)
            {
                result <<= 1;
                result += (c - '0');
            }
            if (result < 10)
            {
                return Convert.ToString("0" + result);
            }
            else
                return Convert.ToString(result);
        }
    }
}
