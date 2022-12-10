using Newtonsoft.Json;
using Soundistica.DataOperations;
using SoundTestApp.DataOperations;
using SoundTestApp.SoundOperations;

namespace SoundTestApp
{
    public partial class Form1 : Form
    {
        private PlaySound player;
        private List<Panel> panelList = new List<Panel>();
        private int index;
        internal DataComponent data;
        string nagranieAsciezka;
        string nagranieBsciezka;
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        MetadataObject metadataObject = new MetadataObject();
        int IloscBadan;
        public Form1()
        {
            InitializeComponent();

            //  Setup temp file with questions and recording names
            string path = projectDirectory + @"\metadata.json";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path)) ;
            }
            else
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    MetadataObject metadataObject = JsonConvert.DeserializeObject<MetadataObject>(File.ReadAllText(path));

                    badanie0Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie1Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie2Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie3Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie4Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie5Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie6Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie7Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie8Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie9Pytanie1.Text = metadataObject?.Pytanie1;
                    badanie10Pytanie1.Text = metadataObject?.Pytanie1;

                    badanie0Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie1Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie2Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie3Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie4Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie5Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie6Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie7Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie8Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie9Pytanie2.Text = metadataObject?.Pytanie2;
                    badanie10Pytanie2.Text = metadataObject?.Pytanie2;

                    badanie0Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie1Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie2Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie3Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie4Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie5Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie6Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie7Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie8Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie9Pytanie3.Text = metadataObject?.Pytanie3;
                    badanie10Pytanie3.Text = metadataObject?.Pytanie3;

                    badanie0Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie1Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie2Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie3Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie4Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie5Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie6Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie7Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie8Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie9Pytanie4.Text = metadataObject?.Pytanie4;
                    badanie10Pytanie4.Text = metadataObject?.Pytanie4;

                    badanie0Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie1Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie2Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie3Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie4Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie5Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie6Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie7Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie8Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie9Pytanie5.Text = metadataObject?.Pytanie5;
                    badanie10Pytanie5.Text = metadataObject?.Pytanie5;

                    pytanie1.Text = metadataObject?.Pytanie1;
                    pytanie2.Text = metadataObject?.Pytanie2;
                    pytanie3.Text = metadataObject?.Pytanie3;
                    pytanie4.Text = metadataObject?.Pytanie4;
                    pytanie5.Text = metadataObject?.Pytanie5;

                    trescTytulu.Text = metadataObject?.Tytul;
                    trescInstrukcja.Text = metadataObject?.Instrukcja;

                    nagranieAsciezka = metadataObject?.NagranieA;
                    nagranieBsciezka = metadataObject?.NagranieB;

                    sciezkaNagranieA.Text = nagranieAsciezka;
                    sciezkaNagranieB.Text = nagranieBsciezka;

                    IloscBadan = metadataObject.IloscBadan;
                    iloscBadan.Text = IloscBadan.ToString();
                }
            }

            //  Setup panels list
            panelList.Add(panelStart);
            panelList.Add(panelTutorial);
            panelList.Add(panelBadanie1);
            if (IloscBadan >= 2) { panelList.Add(panelBadanie2); }
            if (IloscBadan >= 3) { panelList.Add(panelBadanie3); }
            if (IloscBadan >= 4) { panelList.Add(panel4Badanie2); }
            if (IloscBadan >= 5) { panelList.Add(panelBadanie5); }
            if (IloscBadan >= 6) { panelList.Add(panelBadanie6); }
            if (IloscBadan >= 7) { panelList.Add(panelBadanie7); }
            if (IloscBadan >= 8) { panelList.Add(panelBadanie8); }
            if (IloscBadan >= 9) { panelList.Add(panelBadanie9); }
            if (IloscBadan >= 10) { panelList.Add(panelBadanie10); }
            panelList.Add(panelZakonczenie);

            //  Hide all panels except start
            foreach (Panel p in panelList)
            {
                p.Hide();
            }
            panelStart.Show();

            //  Hide for first form
            buttonBack.Hide();
            labelStartWarning.Hide();

            //  Setup Admin Panel
            panelAdmin.Hide();


            //initialize new player and component objects
            player = new PlaySound();
            data = new DataComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index >= panelList.Count - 2)
            {
                buttonNext.Text = "Zapisz wynik";
            }
            //  Save results if it's last panel
            if (index == panelList.Count-1)
            {
                //  Save - przenies to na koniec po zakonczeniu! - Dodaj pasek ³adowania z 10/15 sekundami odczekania zeby przeszlo wrzucanie do bazy
                _ = new DataSaver(data.UserCode, data.UserAge, data.UserGender, data.UserExperience, data.UserStudent, data.UserResults);
            }
            //  Normal work scheule
            else
            {
                //  If user code has been specified as int
                if (Int32.TryParse(kodBadanego.Text, out int num))
                {
                    //  Hide warning in case if it was previously opened
                    labelStartWarning.Hide();

                    //  Go to the next panel
                    if (index < panelList.Count - 1)
                    {
                        panelList[++index].Show();
                        panelList[index].BringToFront();
                        player.Stop();
                    }
                    //  Show next button if it's other form that start
                    if (index > 0)
                    {
                        buttonBack.Show();
                    }
                }
                //  Show warning for wrong or missing user code
                else
                {
                    labelStartWarning.Show();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                panelList[index].Hide();
                panelList[--index].Show();
                panelList[index].BringToFront();
                player.Stop();
            }
            if(index == 0)
            {
                buttonBack.Hide();
            }
            if(index <= panelList.Count - 2)
            {
                buttonNext.Text = "Dalej";
            }
        }

        //panelStart section
        private void textboxUserCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data.UserCode = Int32.Parse(kodBadanego.Text);
            }
            catch (Exception es)
            {
                //add logging
            }
        }

        private void wiekBadanego_TextChanged(object sender, EventArgs e)
        {
            data.UserAge = Int32.Parse(wiekBadanego.Text);
        }

        private void plecBadanego_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.UserGender = plecBadanego.Text;
        }

        private void wyksztalcenieBadanego_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.UserExperience = wyksztalcenieBadanego.Text;
        }

        //panelTutorial section
        private void buttonTutorialA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_0.wav");
        }

        private void buttonTutorialB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_0.wav");
        }

        //panelBadanie1==================================================================

        private void badanie1NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_1.wav");
        }

        private void badanie1NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_1.wav");
        }

        private void badanie1Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie1Odpowiedz1.SelectedItem.ToString(), "1_1", data);
        }

        private void badanie1Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie1Odpowiedz2.SelectedItem.ToString(), "1_2", data);
        }

        private void badanie1Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie1Odpowiedz3.SelectedItem.ToString(), "1_3", data);
        }

        private void badanie1Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie1Odpowiedz4.SelectedItem.ToString(), "1_4", data);
        }
        private void badanie1Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie1Odpowiedz6.SelectedItem.ToString(), "1_5", data);
        }

        //panelBadanie2==================================================================
        private void badanie2NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_2.wav");
        }

        private void badanie2NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_2.wav");
        }

        private void badanie2Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie2Odpowiedz1.SelectedItem.ToString(), "2_1", data);
        }

        private void badanie2Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie2Odpowiedz2.SelectedItem.ToString(), "2_2", data);
        }

        private void badanie2Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie2Odpowiedz3.SelectedItem.ToString(), "2_3", data);
        }

        private void badanie2Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie2Odpowiedz4.SelectedItem.ToString(), "2_4", data);
        }

        private void badanie2Odpowiedz5_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie2Odpowiedz5.SelectedItem.ToString(), "2_5", data);
        }

        //panelBadanie3==================================================================
        private void badanie3NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_3.wav");
        }

        private void badanie3NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_3.wav");
        }

        private void badanie3Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie3Odpowiedz1.SelectedItem.ToString(), "3_1", data);
        }

        private void badanie3Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie3Odpowiedz2.SelectedItem.ToString(), "3_2", data);
        }

        private void badanie3Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie3Odpowiedz3.SelectedItem.ToString(), "3_3", data);
        }

        private void badanie3Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie3Odpowiedz4.SelectedItem.ToString(), "3_4", data);
        }

        private void badanie3Odpowiedz5_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie3Odpowiedz5.SelectedItem.ToString(), "3_5", data);
        }

        //panelBadanie4==================================================================
        private void badanie4NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_4.wav");
        }

        private void badanie4NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_4.wav");
        }

        private void badanie4Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie4Odpowiedz1.SelectedItem.ToString(), "4_1", data);
        }

        private void badanie4Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie4Odpowiedz2.SelectedItem.ToString(), "4_2", data);
        }

        private void badanie4Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie4Odpowiedz3.SelectedItem.ToString(), "4_3", data);
        }

        private void badanie4Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie4Odpowiedz4.SelectedItem.ToString(), "4_4", data);
        }

        private void badanie4Odpowiedz5_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie4Odpowiedz5.SelectedItem.ToString(), "4_5", data);
        }

        //panelBadanie5==================================================================
        private void badanie5NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_5.wav");
        }

        private void badanie5NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_5.wav");
        }

        private void badanie5Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie5Odpowiedz1.SelectedItem.ToString(), "5_1", data);
        }

        private void badanie5Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie5Odpowiedz2.SelectedItem.ToString(), "5_2", data);
        }

        private void badanie5Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie5Odpowiedz3.SelectedItem.ToString(), "5_3", data);
        }

        private void badanie5Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie5Odpowiedz4.SelectedItem.ToString(), "5_4", data);
        }

        private void badanie5Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie5Odpowiedz6.SelectedItem.ToString(), "5_5", data);
        }


        //panelBadanie6==================================================================


        private void badanie6NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_6.wav");
        }

        private void badanie6NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_6.wav");
        }

        private void badanie6Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie6Odpowiedz1.SelectedItem.ToString(), "6_1", data);
        }

        private void badanie6Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie6Odpowiedz2.SelectedItem.ToString(), "6_2", data);
        }

        private void badanie6Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie6Odpowiedz3.SelectedItem.ToString(), "6_3", data);
        }

        private void badanie6Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie6Odpowiedz4.SelectedItem.ToString(), "6_4", data);
        }

        private void badanie6Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie6Odpowiedz5.SelectedItem.ToString(), "6_5", data);
        }

        //panelBadanie7==================================================================

        private void badanie7NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_7.wav");
        }

        private void badanie7NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_7.wav");
        }

        private void Badanie7Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(Badanie7Odpowiedz1.SelectedItem.ToString(), "7_1", data);
        }

        private void Badanie7Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(Badanie7Odpowiedz2.SelectedItem.ToString(), "7_2", data);
        }

        private void Badanie7Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(Badanie7Odpowiedz3.SelectedItem.ToString(), "7_3", data);
        }

        private void Badanie7Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(Badanie7Odpowiedz4.SelectedItem.ToString(), "7_4", data);
        }

        private void Badanie7Odpowiedz5_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(Badanie7Odpowiedz5.SelectedItem.ToString(), "7_5", data);
        }


        //panelBadanie8==================================================================
        private void badanie8NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_8.wav");
        }

        private void badanie8NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_8.wav");
        }

        private void badanie8Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie8Odpowiedz1.SelectedItem.ToString(), "8_1", data);
        }

        private void badanie8Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie8Odpowiedz2.SelectedItem.ToString(), "8_2", data);
        }

        private void badanie8Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie8Odpowiedz3.SelectedItem.ToString(), "8_3", data);
        }

        private void badanie8Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie8Odpowiedz4.SelectedItem.ToString(), "8_4", data);
        }

        private void badanie8Odpowiedz5_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie8Odpowiedz5.SelectedItem.ToString(), "8_5", data);
        }

        //panelBadanie9==================================================================
        private void badanie9NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_9.wav");
        }

        private void badanie9NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_9.wav");
        }

        private void badanie9Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie9Odpowiedz1.SelectedItem.ToString(), "9_1", data);
        }

        private void badanie9Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie9Odpowiedz2.SelectedItem.ToString(), "9_2", data);
        }

        private void badanie9Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie9Odpowiedz3.SelectedItem.ToString(), "9_3", data);
        }

        private void badanie9Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie9Odpowiedz4.SelectedItem.ToString(), "9_4", data);
        }

        private void badanie9Odpowiedz5_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie9Odpowiedz5.SelectedItem.ToString(), "9_5", data);
        }


        //panelBadanie10==================================================================
        private void badanie10NagranieA_Click(object sender, EventArgs e)
        {
            player.Play(nagranieAsciezka + "_10.wav");
        }

        private void badanie10NagranieB_Click(object sender, EventArgs e)
        {
            player.Play(nagranieBsciezka + "_10.wav");
        }

        private void badanie10Odpowiedz1_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie10Odpowiedz1.SelectedItem.ToString(), "10_1", data);
        }

        private void badanie10Odpowiedz2_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie10Odpowiedz2.SelectedItem.ToString(), "10_2", data);
        }

        private void badanie10Odpowiedz3_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie10Odpowiedz3.SelectedItem.ToString(), "10_3", data);
        }

        private void badanie10Odpowiedz4_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie10Odpowiedz4.SelectedItem.ToString(), "10_4", data);
        }

        private void badanie10Odpowiedz5_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie10Odpowiedz5.SelectedItem.ToString(), "10_5", data);
        }

        //panelAdmin======================================================================
        private void pytanie1_TextChanged(object sender, EventArgs e)
        {
            badanie0Pytanie1.Text = pytanie1.Text;
            badanie1Pytanie1.Text = pytanie1.Text;
            badanie2Pytanie1.Text = pytanie1.Text;
            badanie3Pytanie1.Text = pytanie1.Text;
            badanie4Pytanie1.Text = pytanie1.Text;
            badanie5Pytanie1.Text = pytanie1.Text;
            badanie6Pytanie1.Text = pytanie1.Text;
            badanie7Pytanie1.Text = pytanie1.Text;
            badanie8Pytanie1.Text = pytanie1.Text;
            badanie9Pytanie1.Text = pytanie1.Text;
            badanie10Pytanie1.Text = pytanie1.Text;

            metadataObject.Pytanie1 = pytanie1.Text;
        }

        private void pytanie2_TextChanged(object sender, EventArgs e)
        {
            badanie0Pytanie2.Text = pytanie2.Text;
            badanie1Pytanie2.Text = pytanie2.Text;
            badanie2Pytanie2.Text = pytanie2.Text;
            badanie3Pytanie2.Text = pytanie2.Text;
            badanie4Pytanie2.Text = pytanie2.Text;
            badanie5Pytanie2.Text = pytanie2.Text;
            badanie6Pytanie2.Text = pytanie2.Text;
            badanie7Pytanie2.Text = pytanie2.Text;
            badanie8Pytanie2.Text = pytanie2.Text;
            badanie9Pytanie2.Text = pytanie2.Text;
            badanie10Pytanie2.Text = pytanie2.Text;

            metadataObject.Pytanie2 = pytanie2.Text;
        }

        private void pytanie3_TextChanged(object sender, EventArgs e)
        {
            badanie0Pytanie3.Text = pytanie3.Text;
            badanie1Pytanie3.Text = pytanie3.Text;
            badanie2Pytanie3.Text = pytanie3.Text;
            badanie3Pytanie3.Text = pytanie3.Text;
            badanie4Pytanie3.Text = pytanie3.Text;
            badanie5Pytanie3.Text = pytanie3.Text;
            badanie6Pytanie3.Text = pytanie3.Text;
            badanie7Pytanie3.Text = pytanie3.Text;
            badanie8Pytanie3.Text = pytanie3.Text;
            badanie9Pytanie3.Text = pytanie3.Text;
            badanie10Pytanie3.Text = pytanie3.Text;

            metadataObject.Pytanie3 = pytanie3.Text;
        }

        private void pytanie4_TextChanged(object sender, EventArgs e)
        {
            badanie0Pytanie4.Text = pytanie4.Text;
            badanie1Pytanie4.Text = pytanie4.Text;
            badanie2Pytanie4.Text = pytanie4.Text;
            badanie3Pytanie4.Text = pytanie4.Text;
            badanie4Pytanie4.Text = pytanie4.Text;
            badanie5Pytanie4.Text = pytanie4.Text;
            badanie6Pytanie4.Text = pytanie4.Text;
            badanie7Pytanie4.Text = pytanie4.Text;
            badanie8Pytanie4.Text = pytanie4.Text;
            badanie9Pytanie4.Text = pytanie4.Text;
            badanie10Pytanie4.Text = pytanie4.Text;

            metadataObject.Pytanie4 = pytanie4.Text;
        }

        private void pytanie5_TextChanged(object sender, EventArgs e)
        {
            badanie0Pytanie5.Text = pytanie5.Text;
            badanie1Pytanie5.Text = pytanie5.Text;
            badanie2Pytanie5.Text = pytanie5.Text;
            badanie3Pytanie5.Text = pytanie5.Text;
            badanie4Pytanie5.Text = pytanie5.Text;
            badanie5Pytanie5.Text = pytanie5.Text;
            badanie6Pytanie5.Text = pytanie5.Text;
            badanie7Pytanie5.Text = pytanie5.Text;
            badanie8Pytanie5.Text = pytanie5.Text;
            badanie9Pytanie5.Text = pytanie5.Text;
            badanie10Pytanie5.Text = pytanie5.Text;

            metadataObject.Pytanie5 = pytanie5.Text;
        }

        private void zapisMetadanych_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(metadataObject);

            string path = projectDirectory + @"\metadata.json";
            File.WriteAllTextAsync(path, json);

        }

        private void wyjscieAdmin_Click(object sender, EventArgs e)
        {
            panelAdmin.Hide();
            buttonNext.Show();
        }

        private void sciezkaNagranieA_TextChanged(object sender, EventArgs e)
        {
            metadataObject.NagranieA = sciezkaNagranieA.Text;
        }

        private void sciezkaNagranieB_TextChanged(object sender, EventArgs e)
        {
            metadataObject.NagranieB = sciezkaNagranieB.Text;
        }

        private void adminPanelOtworz_Click(object sender, EventArgs e)
        {
            panelAdmin.Show();
            panelAdmin.BringToFront();
            buttonNext.Hide();
        }

        private void trescTytulu_TextChanged(object sender, EventArgs e)
        {
            tytulTestu.Text = trescTytulu.Text;

            metadataObject.Tytul = trescTytulu.Text;
        }

        private void trescInstrukcja_TextChanged(object sender, EventArgs e)
        {
            instrukcjaTestu.Text = trescInstrukcja.Text;

            metadataObject.Instrukcja = instrukcjaTestu.Text;
        }

        private void iloscBadan_TextChanged(object sender, EventArgs e)
        {
            IloscBadan = Int32.TryParse(iloscBadan.Text, out int num) ? num : 3;
            if (IloscBadan < 1) { IloscBadan = 1; }
            if (IloscBadan > 10) { IloscBadan = 10; }

            metadataObject.IloscBadan = IloscBadan;
        }
    }
}