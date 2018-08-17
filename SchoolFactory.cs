using System;
using static System.Math;
using static System.Convert;

namespace CSVtoDB
{
    public class SchoolFactory
    {
        private School[] allSchools;
        private CSVreader myReader;
        int numberOfSchools;

        public School[] AllSchools
         => allSchools == null ? GetAllallSchools() : allSchools;

        private School[] GetAllallSchools()
        {
            numberOfSchools = myReader.Height;
            allSchools = new School[numberOfSchools];

            int eiin;
            for (int i = 0; i < numberOfSchools; i++)
            {
                eiin = myReader.EIINs[i];
                allSchools[i] = new School()
                {
                    ID = eiin,
                    Name = myReader[eiin, "INSTITUTE NAME"],
                    Age = ToDouble(myReader[eiin, "AS_SCORE"]),
                    
                    // Address
                    Division = myReader[eiin, "DIVISION"],
                    District = myReader[eiin, "DISTRICT"],
                    Thana = myReader[eiin, "THANA"],
                    Union_Ward = myReader[eiin, "UNION_NAME"],
                    StreetAddr = myReader[eiin, "ADDRESS"],
                    MobileNum = myReader[eiin, "MOBILE"],

                    // Eligibility
                    Type = myReader[eiin, "STUDENT_TYPE"],
                    Level = myReader[eiin, "EDUCATION_LEVEL"],

                    // SES
                    SES = ToDouble(myReader[eiin, "AScore"]) / 10,
                    SEScore1 = ToDouble(myReader[eiin, "SESscore_LO"]),
                    SEScore2 = ToDouble(myReader[eiin, "SESscore_LM"]),
                    SEScore3 = ToDouble(myReader[eiin, "SESscore_UM"]),
                    SEScore4 = ToDouble(myReader[eiin, "SESscore_UP"]),

                    // Ratios
                    MFRatio = ToDouble(myReader[eiin, "FEM_STD_RATIO"]),
                    TSRatio = ToDouble(myReader[eiin, "TSR_SCORE"]),

                    // AverAge
                    AverAge6 = ToDouble(myReader[eiin, "SIX_AVG"]),
                    AverAge7 = ToDouble(myReader[eiin, "SEVEN_AVG"]),
                    AverAge8 = ToDouble(myReader[eiin, "EIGHT_AVG"]),
                    AverAge9 = ToDouble(myReader[eiin, "NINE_AVG"]),
                    AverAgeX = ToDouble(myReader[eiin, "TEN_AVG"])
                };
            }
            return allSchools;
        }

       

        public SchoolFactory(string filePath)
            => myReader = new CSVreader(filePath);

        internal void WriteEverything(string filePath)
        {
            string[] whatToWrite = new string[numberOfSchools + 1];
            whatToWrite[0] = "EIIN,Name,District,Thana,TSR,SES,MFR,AS,DIST,ADS";
            School s;
            for (int i = 0; i < numberOfSchools; )
            {
                s = allSchools[i];
                whatToWrite[i] = $"{s.ID},{s.Name},{s.District},{s.Thana},{s.TSRatio}";
            }
            System.IO.File.WriteAllLines(filePath, whatToWrite);
        }
    }
}