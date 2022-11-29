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
        }

        //  Pack data into dictionary
        //  - resultString = choosen option (ex. "Nagranie A"),
        //  - questionTaq = question numer (ex. "1_1" means Test 1, Question 1)
        //  - data = DataComponent object containing saved results
        public void PackData(string resultString, string questionTag, DataComponent data)
        {
            /*string result = resultString.Split(' ')[2];//.ToCharArray()[0];
            bool addResult = data.UserResults.TryAdd(questionTag, result);
            if (!addResult) { data.UserResults[questionTag] = result; }*/
            string result = resultString;
            bool addResult = data.UserResults.TryAdd(questionTag, result);
            if (!addResult) { data.UserResults[questionTag] = result; }
        }
    }
}
