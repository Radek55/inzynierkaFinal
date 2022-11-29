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

        public Form1()
        {
            InitializeComponent();
            
            //  Setup panels list
            panelList.Add(panelStart);
            panelList.Add(panelTutorial);
            panelList.Add(panelBadanie1);
            panelList.Add(panelBadanie2);
            panelList.Add(panelBadanie3);
            panelList.Add(panelBadanie4);
            panelList.Add(panelBadanie5);
            panelList.Add(panelBadanie6);
            panelList.Add(panelBadanie7);
            panelList.Add(panelBadanie8);
            panelList.Add(panelBadanie9);
            panelList.Add(panelBadanie10);
            panelList.Add(panelZakonczenie);
            //add new panels here

            //  Hide all panels except start
            foreach (Panel p in panelList)
            {
                p.Hide();
            }
            panelStart.Show();

            //  Hide for first form
            buttonBack.Hide();
            labelStartWarning.Hide();


            //initialize new player and component objects
            player = new PlaySound();
            data = new DataComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
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

        private void studentAkustyki_CheckedChanged(object sender, EventArgs e)
        {
            data.UserStudent = studentAkustyki.Checked;
        }

        //panelTutorial section
        private void buttonTutorialA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probkawprowadzenie_forty.wav");
        }

        private void buttonTutorialB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probkawprowadzenie_p23.wav");
        }

        //panelBadanie1==================================================================

        private void badanie1NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka1_p23_gitara.wav");
        }

        private void badanie1NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka1_forty_gitara.wav");
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
            data.PackData(badanie1Odpowiedz6.SelectedItem.ToString(), "1_6", data);
        }

        //panelBadanie2==================================================================
        private void badanie2NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka2_p23_wokal.wav");
        }

        private void badanie2NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka2_forty_wokal.wav");
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

        private void badanie2Odpowiedz7_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie2Odpowiedz7.SelectedItem.ToString(), "2_7", data);
        }

        //panelBadanie3==================================================================
        private void badanie3NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka3_forty_wokal.wav");
        }

        private void badanie3NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka3_p23_wokal.wav");
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

        private void badanie3Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie3Odpowiedz6.SelectedItem.ToString(), "3_6", data);
        }

        //panelBadanie4==================================================================
        private void badanie4NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka4_p23_wokal.wav");
        }

        private void badanie4NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka4_forty_wokal.wav");
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

        private void badanie4Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie4Odpowiedz6.SelectedItem.ToString(), "4_6", data);
        }

        //panelBadanie5==================================================================
        private void badanie5NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka5_forty_gitara.wav");
        }

        private void badanie5NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka5_p23_gitara.wav");
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
            data.PackData(badanie5Odpowiedz6.SelectedItem.ToString(), "5_6", data);
        }


        //panelBadanie6==================================================================


        private void badanie6NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka1paon_gitara.wav");
        }

        private void badanie6NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka1oliwa_gitara.wav");
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
            data.PackData(badanie6Odpowiedz6.SelectedItem.ToString(), "6_6", data);
        }

        //panelBadanie7==================================================================

        private void badanie7NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka2paon_wokal.wav");
        }

        private void badanie7NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka2oliwa_wokal.wav");
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

        private void Badanie7Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(Badanie7Odpowiedz6.SelectedItem.ToString(), "7_6", data);
        }


        //panelBadanie8==================================================================
        private void badanie8NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka3oliwa_wokal.wav");
        }

        private void badanie8NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka3paon_wokal.wav");
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

        private void badanie8Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie8Odpowiedz6.SelectedItem.ToString(), "8_6", data);
        }

        //panelBadanie9==================================================================
        private void badanie9NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka4oliwa_wokal.wav");
        }

        private void badanie9NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka4paon_wokal.wav");
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

        private void badanie9Odpowiedz6_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(badanie9Odpowiedz6.SelectedItem.ToString(), "9_6", data);
        }


        //panelBadanie10==================================================================
        private void badanie10NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka5paon_gitara.wav");
        }

        private void badanie10NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("highsanity/probka5oliwa_gitara.wav");
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
    }
}