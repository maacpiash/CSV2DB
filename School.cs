namespace CSVtoDB
{
    public class School
    {
        private string mobilenum;
        public string MobileNum
        {
            get => mobilenum;
            set => mobilenum = value.Contains("+880") ? (value) : (value.StartsWith("0") ? "+88" + value : "+880" + value);
        }

        // Must-have
        
        public int ID { get; set; }

        private string name;
        public string Name { get => name; set => name = value; }
        
        // AS

        private double age;
        public double Age { get => age; set => age = value; }

        // Location

        private string union_ward;
        public string Union_Ward { get => union_ward; set => union_ward = value; }
        
        public string thana;
        public string Thana { get => thana; set => thana = value; }
        
        public string district;
        public string District { get => district; set => district = value; }
        
        public string division;
        public string Division { get => division; set => division = value; }

        private double distance;
        public double Distance { get => distance; set => distance = value; }

        private string streetaddr;
        public string StreetAddr { get => streetaddr; set => streetaddr = value; }
        
        // Attributes of eligibility

        private string type; // boys'/girls'/co-ed
        public string Type { get => type; set => type = value; }

        private string level; // ju-sec/sec/hi-sec
        public string Level { get => level; set => level = value; }

        // AverAge

        private double averAge6;
        public double AverAge6 { get => averAge6; set => averAge6 = value; }

        private double averAge7;
        public double AverAge7 { get => averAge7; set => averAge7 = value; }

        private double averAge8;
        public double AverAge8 { get => averAge8; set => averAge8 = value; }

        private double averAge9;
        public double AverAge9 { get => averAge9; set => averAge9 = value; }
        
        private double averAgeX;
        public double AverAgeX { get => averAgeX; set => averAgeX = value; }

        // Ratio

        private double smfRatio;
        public double MFRatio { get => smfRatio; set => smfRatio = value; }

        private double tsRatio;
        public double TSRatio { get => tsRatio; set => tsRatio = value; }
        
        // SES

        private double seScore1;
        public double SEScore1{ get => seScore1; set => seScore1 = value; }
        private double seScore2;
        public double SEScore2 { get => seScore2; set => seScore2 = value; }
        private double seScore3;
        public double SEScore3 { get => seScore3; set => seScore3 = value; }
        private double seScore4;
        public double SEScore4 { get => seScore4; set => seScore4 = value; }

        private double ses;
        public double SES { get => ses; set => ses = value; }
        
    }
}