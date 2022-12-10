namespace SoundTestApp.DataOperations
{
    internal class DataComponent
    {
        private static Dictionary<string, string>? userResults;

        //  Invidual user code
        public int UserCode
        { get; set; }

        public int UserAge
        { get; set; }

        public string UserGender
        { get; set; }

        public string UserExperience
        { get; set; }

        public bool UserStudent
        { get; set; }

        //  Dictionary containing test results
        public Dictionary<string, string> UserResults
        {
            get => userResults;
            set => userResults = value;
        }

        public DataComponent()
        {
            UserCode = 0;
            UserResults = new Dictionary<string, string>();
            UserResults.Clear();
            UserResults.Add("1_1", "");
            UserResults.Add("1_2", "");
            UserResults.Add("1_3", "");
            UserResults.Add("1_4", "");
            UserResults.Add("1_5", "");
            UserResults.Add("1_6", "");
            UserResults.Add("2_1", "");
            UserResults.Add("2_2", "");
            UserResults.Add("2_3", "");
            UserResults.Add("2_4", "");
            UserResults.Add("2_5", "");
            UserResults.Add("2_6", "");
            UserResults.Add("3_1", "");
            UserResults.Add("3_2", "");
            UserResults.Add("3_3", "");
            UserResults.Add("3_4", "");
            UserResults.Add("3_5", "");
            UserResults.Add("3_6", "");
            UserResults.Add("4_1", "");
            UserResults.Add("4_2", "");
            UserResults.Add("4_3", "");
            UserResults.Add("4_4", "");
            UserResults.Add("4_5", "");
            UserResults.Add("4_6", "");
            UserResults.Add("5_1", "");
            UserResults.Add("5_2", "");
            UserResults.Add("5_3", "");
            UserResults.Add("5_4", "");
            UserResults.Add("5_5", "");
            UserResults.Add("5_6", "");
            UserResults.Add("6_1", "");
            UserResults.Add("6_2", "");
            UserResults.Add("6_3", "");
            UserResults.Add("6_4", "");
            UserResults.Add("6_5", "");
            UserResults.Add("6_6", "");
            UserResults.Add("7_1", "");
            UserResults.Add("7_2", "");
            UserResults.Add("7_3", "");
            UserResults.Add("7_4", "");
            UserResults.Add("7_5", "");
            UserResults.Add("7_6", ""); 
            UserResults.Add("8_1", "");
            UserResults.Add("8_2", "");
            UserResults.Add("8_3", "");
            UserResults.Add("8_4", "");
            UserResults.Add("8_5", "");
            UserResults.Add("8_6", ""); 
            UserResults.Add("9_1", "");
            UserResults.Add("9_2", "");
            UserResults.Add("9_3", "");
            UserResults.Add("9_4", "");
            UserResults.Add("9_5", "");
            UserResults.Add("9_6", ""); 
            UserResults.Add("10_1", "");
            UserResults.Add("10_2", "");
            UserResults.Add("10_3", "");
            UserResults.Add("10_4", "");
            UserResults.Add("10_5", "");
            UserResults.Add("10_6", "");
        }

        //  Pack data into dictionary
        public void PackData(string resultString, string questionTag, DataComponent data)
        {
            string result = resultString;
            data.UserResults[questionTag] = result;
        }
    }
}
