using MySql.Data.MySqlClient;

namespace SoundTestApp.DataOperations
{
    internal class DataSaver
    {
        //  Data base creditials 
        private readonly string server = "sql11.freemysqlhosting.net";
        private readonly string database = "sql11524713";
        private readonly string username = "sql11524713";
        private readonly string password = "6IZVvZWxtU"; // old password

        public DataSaver(int userCode, int userAge, string userGender, string userExperience, bool userStudent, Dictionary<string, string> dane)
        {
            try
            {
                SaveToCsv(userCode, userAge, userGender, userExperience, userStudent, dane);
                //SaveLocally(userCode, userAge, userGender, userExperience, userStudent, dane);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "zapis lokalny failed");
            }
        }

        private void SaveToCsv(int userCode, int userAge, string userGender, string userExperience, bool userStudent, Dictionary<string, string> dane)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            StreamWriter sw = new StreamWriter(projectDirectory + "\\Wyniki\\wynikibadania_" + userCode + ".csv", true);
            string result = string.Empty;
            result += "Kod;Wiek;Plec;Wyksztalcenie;Student;\r\n";
            result += userCode + ";" + userAge + ";" + userGender + ";" + userExperience + ";\r\n";
            result += "Nr badania;Pytanie 1; Pytanie 2; Pytanie 3; Pytanie 4; Pytanie 5;\r\n";

            int startingNumber = 1;
            result += startingNumber.ToString() + ";";
            foreach (KeyValuePair<string, string> entry in dane)
            {
                if (!entry.Key.StartsWith(startingNumber.ToString()))
                {
                    result += "\r\n";
                    startingNumber++;
                    result += startingNumber.ToString() + ";";
                }
                result += entry.Value.ToString() + ";";
            }

            result += "\r\n";

            sw.Write(result);
            sw.Flush();
            sw.Close();
        }

        //  Save test results locally as the backup if database will fail
        private void SaveLocally(int userCode, int userAge, string userGender, string userExperience, bool userStudent, Dictionary<string, char> dane)
        {
            //  Insert data into string
            string result = "Kod," + "Wiek, " + "Plec, "+ "Wyksztalcenie muzyczne," + "Student akustki, "+ "\n";
            result += userCode.ToString() +", " + userAge.ToString() + ", " + userGender + ", " + userExperience + ", " + userStudent.ToString() + ", \n";
            result += "Kod pytania,Odpowiedz, \n";
            foreach(KeyValuePair<string, char> entry in dane)
            {
                result += entry.Key + ", " + entry.Value.ToString() + "\n";
            }

            //  Save data to file WynikBadaniaUzytkownika_{userCode}.txt located in the solution folder
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            File.WriteAllTextAsync(projectDirectory + "\\WynikBadaniaUzytkownika_" + userCode + ".txt", result);
        }

        //  Save results to database online
        private void SaveToDataBase(int userCode, Dictionary<string, char> dane)
        {
            //  Open connection with database online
            string constring = "SERVER=" + server + ";"
                + "DATABASE=" + database + ";"
                + "UID=" + username + ";"
                + "PASSWORD=" + password + ";";
            var conn = new MySqlConnection(constring);
            conn.Open();

            //  Prepare query to insert data
            string query = "INSERT INTO BadaniaWynikiTest(KodOsoby, Probka1, Probka2, Probka3) " +
                "VALUES(" + userCode.ToString() + ", " +
                "\'" + dane["1_1"] + "\', " +
                "\'" + dane["1_2"] + "\', " +
                "\'" + dane["1_3"] + "\');";

            //  Create command and run query
            var cmd = new MySqlCommand(query, conn);
            cmd.ExecuteReader();
        }
    }
}
