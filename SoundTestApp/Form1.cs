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
            player.Play("mrozu/probka2_forty_wokal.wav");
        }

        private void buttonTutorialB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka2_p23_wokal.wav");
        }

        //panelBadanie1

        private void badanie1NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka1_forty_gitara.wav");
        }

        private void badanie1NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka1_p23_gitara.wav");
        }

        //panelBadanie2

        private void badanie2NagranieA_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka2_forty_wokal.wav");
        }

        private void badanie2NagranieB_Click(object sender, EventArgs e)
        {
            player.Play("mrozu/probka2_p23_wokal.wav");
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






        /*private void comboBoxTest11_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(comboBoxTest11.SelectedItem.ToString(), "1_1", data);
        }

        private void comboBoxTest12_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(comboBoxTest11.SelectedItem.ToString(), "1_2", data);
        }

        private void comboBoxTest13_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.PackData(comboBoxTest11.SelectedItem.ToString(), "1_3", data);
        }*/
    }
}