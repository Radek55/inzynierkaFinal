namespace SoundTestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelStart = new System.Windows.Forms.Panel();
            this.studentAkustyki = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.wyksztalcenieBadanego = new System.Windows.Forms.ComboBox();
            this.plecBadanego = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wiekBadanego = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kodBadanego = new System.Windows.Forms.TextBox();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelStartWarning = new System.Windows.Forms.Label();
            this.panelTutorial = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxTutorial3 = new System.Windows.Forms.ComboBox();
            this.comboBoxTutorial2 = new System.Windows.Forms.ComboBox();
            this.comboBoxTutorial1 = new System.Windows.Forms.ComboBox();
            this.buttonTutorialB = new System.Windows.Forms.Button();
            this.buttonTutorialA = new System.Windows.Forms.Button();
            this.labelTutorial6 = new System.Windows.Forms.Label();
            this.labelTutorial5 = new System.Windows.Forms.Label();
            this.labelTutorial4 = new System.Windows.Forms.Label();
            this.labelTutorialB = new System.Windows.Forms.Label();
            this.labelTutorialA = new System.Windows.Forms.Label();
            this.labelTutorialNumber = new System.Windows.Forms.Label();
            this.panelBadanie1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.badanie1Odpowiedz4 = new System.Windows.Forms.ComboBox();
            this.badanie1Odpowiedz3 = new System.Windows.Forms.ComboBox();
            this.badanie1Odpowiedz2 = new System.Windows.Forms.ComboBox();
            this.badanie1Odpowiedz1 = new System.Windows.Forms.ComboBox();
            this.badanie1NagranieB = new System.Windows.Forms.Button();
            this.badanie1NagranieA = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelBadanie2 = new System.Windows.Forms.Panel();
            this.badanie2Odpowiedz1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.badanie2Odpowiedz5 = new System.Windows.Forms.ComboBox();
            this.badanie2Odpowiedz4 = new System.Windows.Forms.ComboBox();
            this.badanie2Odpowiedz3 = new System.Windows.Forms.ComboBox();
            this.badanie2Odpowiedz2 = new System.Windows.Forms.ComboBox();
            this.badanie2NagranieB = new System.Windows.Forms.Button();
            this.badanie2NagranieA = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelStart.SuspendLayout();
            this.panelTutorial.SuspendLayout();
            this.panelBadanie1.SuspendLayout();
            this.panelBadanie2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1346, 981);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(150, 47);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Dalej";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1189, 981);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 47);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Wstecz";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panelStart
            // 
            this.panelStart.Controls.Add(this.studentAkustyki);
            this.panelStart.Controls.Add(this.label5);
            this.panelStart.Controls.Add(this.wyksztalcenieBadanego);
            this.panelStart.Controls.Add(this.plecBadanego);
            this.panelStart.Controls.Add(this.label4);
            this.panelStart.Controls.Add(this.label3);
            this.panelStart.Controls.Add(this.label2);
            this.panelStart.Controls.Add(this.wiekBadanego);
            this.panelStart.Controls.Add(this.label1);
            this.panelStart.Controls.Add(this.kodBadanego);
            this.panelStart.Controls.Add(this.labelStart);
            this.panelStart.Controls.Add(this.labelStartWarning);
            this.panelStart.Location = new System.Drawing.Point(11, 13);
            this.panelStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(1486, 960);
            this.panelStart.TabIndex = 2;
            // 
            // studentAkustyki
            // 
            this.studentAkustyki.AutoSize = true;
            this.studentAkustyki.Location = new System.Drawing.Point(682, 736);
            this.studentAkustyki.Margin = new System.Windows.Forms.Padding(6);
            this.studentAkustyki.Name = "studentAkustyki";
            this.studentAkustyki.Size = new System.Drawing.Size(365, 36);
            this.studentAkustyki.TabIndex = 13;
            this.studentAkustyki.Text = "Student Inżynierii Akustycznej";
            this.studentAkustyki.UseVisualStyleBackColor = true;
            this.studentAkustyki.CheckedChanged += new System.EventHandler(this.studentAkustyki_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 698);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wykształcenie muzyczne";
            // 
            // wyksztalcenieBadanego
            // 
            this.wyksztalcenieBadanego.FormattingEnabled = true;
            this.wyksztalcenieBadanego.Items.AddRange(new object[] {
            "brak",
            "samouk",
            "absolwent szkoły muzycznej 1 stopnia",
            "absolwent szkoły muzycznej 2 stopnia",
            "absolwent akademii muzycznej"});
            this.wyksztalcenieBadanego.Location = new System.Drawing.Point(93, 736);
            this.wyksztalcenieBadanego.Margin = new System.Windows.Forms.Padding(6);
            this.wyksztalcenieBadanego.Name = "wyksztalcenieBadanego";
            this.wyksztalcenieBadanego.Size = new System.Drawing.Size(488, 40);
            this.wyksztalcenieBadanego.TabIndex = 11;
            this.wyksztalcenieBadanego.SelectedIndexChanged += new System.EventHandler(this.wyksztalcenieBadanego_SelectedIndexChanged);
            // 
            // plecBadanego
            // 
            this.plecBadanego.FormattingEnabled = true;
            this.plecBadanego.Items.AddRange(new object[] {
            "kobieta",
            "mezczyzna",
            "inne/wole nie podawac"});
            this.plecBadanego.Location = new System.Drawing.Point(682, 604);
            this.plecBadanego.Margin = new System.Windows.Forms.Padding(6);
            this.plecBadanego.Name = "plecBadanego";
            this.plecBadanego.Size = new System.Drawing.Size(323, 40);
            this.plecBadanego.TabIndex = 10;
            this.plecBadanego.SelectedIndexChanged += new System.EventHandler(this.plecBadanego_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(682, 561);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Płeć";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 561);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wiek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 561);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kod";
            // 
            // wiekBadanego
            // 
            this.wiekBadanego.Location = new System.Drawing.Point(377, 604);
            this.wiekBadanego.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.wiekBadanego.Name = "wiekBadanego";
            this.wiekBadanego.Size = new System.Drawing.Size(93, 39);
            this.wiekBadanego.TabIndex = 4;
            this.wiekBadanego.TextChanged += new System.EventHandler(this.wiekBadanego_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1245, 180);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // kodBadanego
            // 
            this.kodBadanego.Location = new System.Drawing.Point(93, 604);
            this.kodBadanego.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.kodBadanego.Name = "kodBadanego";
            this.kodBadanego.Size = new System.Drawing.Size(93, 39);
            this.kodBadanego.TabIndex = 1;
            this.kodBadanego.TextChanged += new System.EventHandler(this.textboxUserCode_TextChanged);
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(41, 311);
            this.labelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(1175, 192);
            this.labelStart.TabIndex = 0;
            this.labelStart.Text = resources.GetString("labelStart.Text");
            // 
            // labelStartWarning
            // 
            this.labelStartWarning.AutoSize = true;
            this.labelStartWarning.Location = new System.Drawing.Point(1226, 909);
            this.labelStartWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartWarning.Name = "labelStartWarning";
            this.labelStartWarning.Size = new System.Drawing.Size(267, 32);
            this.labelStartWarning.TabIndex = 0;
            this.labelStartWarning.Text = "Brak kodu użytkownika!";
            // 
            // panelTutorial
            // 
            this.panelTutorial.Controls.Add(this.label7);
            this.panelTutorial.Controls.Add(this.label6);
            this.panelTutorial.Controls.Add(this.comboBox2);
            this.panelTutorial.Controls.Add(this.comboBox1);
            this.panelTutorial.Controls.Add(this.comboBoxTutorial3);
            this.panelTutorial.Controls.Add(this.comboBoxTutorial2);
            this.panelTutorial.Controls.Add(this.comboBoxTutorial1);
            this.panelTutorial.Controls.Add(this.buttonTutorialB);
            this.panelTutorial.Controls.Add(this.buttonTutorialA);
            this.panelTutorial.Controls.Add(this.labelTutorial6);
            this.panelTutorial.Controls.Add(this.labelTutorial5);
            this.panelTutorial.Controls.Add(this.labelTutorial4);
            this.panelTutorial.Controls.Add(this.labelTutorialB);
            this.panelTutorial.Controls.Add(this.labelTutorialA);
            this.panelTutorial.Controls.Add(this.labelTutorialNumber);
            this.panelTutorial.Location = new System.Drawing.Point(11, 13);
            this.panelTutorial.Margin = new System.Windows.Forms.Padding(6);
            this.panelTutorial.Name = "panelTutorial";
            this.panelTutorial.Size = new System.Drawing.Size(1486, 960);
            this.panelTutorial.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 585);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(758, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "W którym z nagrań główny wokal cechuje się większą zrozumiałością?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 503);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(642, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "W którym z nagrań perkusja sprawia wrażenie głośniejszej?";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.comboBox2.Location = new System.Drawing.Point(1124, 578);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(342, 40);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.comboBox1.Location = new System.Drawing.Point(1124, 497);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 40);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBoxTutorial3
            // 
            this.comboBoxTutorial3.FormattingEnabled = true;
            this.comboBoxTutorial3.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.comboBoxTutorial3.Location = new System.Drawing.Point(1124, 414);
            this.comboBoxTutorial3.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxTutorial3.Name = "comboBoxTutorial3";
            this.comboBoxTutorial3.Size = new System.Drawing.Size(342, 40);
            this.comboBoxTutorial3.TabIndex = 11;
            // 
            // comboBoxTutorial2
            // 
            this.comboBoxTutorial2.FormattingEnabled = true;
            this.comboBoxTutorial2.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.comboBoxTutorial2.Location = new System.Drawing.Point(1124, 331);
            this.comboBoxTutorial2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxTutorial2.Name = "comboBoxTutorial2";
            this.comboBoxTutorial2.Size = new System.Drawing.Size(342, 40);
            this.comboBoxTutorial2.TabIndex = 10;
            // 
            // comboBoxTutorial1
            // 
            this.comboBoxTutorial1.FormattingEnabled = true;
            this.comboBoxTutorial1.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.comboBoxTutorial1.Location = new System.Drawing.Point(1120, 250);
            this.comboBoxTutorial1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxTutorial1.Name = "comboBoxTutorial1";
            this.comboBoxTutorial1.Size = new System.Drawing.Size(346, 40);
            this.comboBoxTutorial1.TabIndex = 9;
            // 
            // buttonTutorialB
            // 
            this.buttonTutorialB.Location = new System.Drawing.Point(464, 145);
            this.buttonTutorialB.Margin = new System.Windows.Forms.Padding(6);
            this.buttonTutorialB.Name = "buttonTutorialB";
            this.buttonTutorialB.Size = new System.Drawing.Size(139, 49);
            this.buttonTutorialB.TabIndex = 7;
            this.buttonTutorialB.Text = "Start/stop";
            this.buttonTutorialB.UseVisualStyleBackColor = true;
            this.buttonTutorialB.Click += new System.EventHandler(this.buttonTutorialB_Click);
            // 
            // buttonTutorialA
            // 
            this.buttonTutorialA.Location = new System.Drawing.Point(93, 145);
            this.buttonTutorialA.Margin = new System.Windows.Forms.Padding(6);
            this.buttonTutorialA.Name = "buttonTutorialA";
            this.buttonTutorialA.Size = new System.Drawing.Size(139, 49);
            this.buttonTutorialA.TabIndex = 6;
            this.buttonTutorialA.Text = "Start/stop";
            this.buttonTutorialA.UseVisualStyleBackColor = true;
            this.buttonTutorialA.Click += new System.EventHandler(this.buttonTutorialA_Click);
            // 
            // labelTutorial6
            // 
            this.labelTutorial6.AutoSize = true;
            this.labelTutorial6.Location = new System.Drawing.Point(41, 420);
            this.labelTutorial6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTutorial6.Name = "labelTutorial6";
            this.labelTutorial6.Size = new System.Drawing.Size(1047, 32);
            this.labelTutorial6.TabIndex = 5;
            this.labelTutorial6.Text = "Które z nagrań brzmi bardziej selektywnie (łatwiej usłyszeć/rozróżnić poszczególn" +
    "e instrumenty)?";
            // 
            // labelTutorial5
            // 
            this.labelTutorial5.AutoSize = true;
            this.labelTutorial5.Location = new System.Drawing.Point(41, 337);
            this.labelTutorial5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTutorial5.Name = "labelTutorial5";
            this.labelTutorial5.Size = new System.Drawing.Size(1080, 32);
            this.labelTutorial5.TabIndex = 4;
            this.labelTutorial5.Text = "Które z nagrań jest bardziej przestrzenne (sprawia wrażenie nagranego w większym " +
    "pomieszczeniu)?";
            // 
            // labelTutorial4
            // 
            this.labelTutorial4.AutoSize = true;
            this.labelTutorial4.Location = new System.Drawing.Point(41, 256);
            this.labelTutorial4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTutorial4.Name = "labelTutorial4";
            this.labelTutorial4.Size = new System.Drawing.Size(312, 32);
            this.labelTutorial4.TabIndex = 3;
            this.labelTutorial4.Text = "Które z nagrań brzmi lepiej?";
            // 
            // labelTutorialB
            // 
            this.labelTutorialB.AutoSize = true;
            this.labelTutorialB.Location = new System.Drawing.Point(464, 107);
            this.labelTutorialB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTutorialB.Name = "labelTutorialB";
            this.labelTutorialB.Size = new System.Drawing.Size(132, 32);
            this.labelTutorialB.TabIndex = 1;
            this.labelTutorialB.Text = "Nagranie B";
            // 
            // labelTutorialA
            // 
            this.labelTutorialA.AutoSize = true;
            this.labelTutorialA.Location = new System.Drawing.Point(93, 107);
            this.labelTutorialA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTutorialA.Name = "labelTutorialA";
            this.labelTutorialA.Size = new System.Drawing.Size(133, 32);
            this.labelTutorialA.TabIndex = 0;
            this.labelTutorialA.Text = "Nagranie A";
            // 
            // labelTutorialNumber
            // 
            this.labelTutorialNumber.AutoSize = true;
            this.labelTutorialNumber.Location = new System.Drawing.Point(41, 36);
            this.labelTutorialNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTutorialNumber.Name = "labelTutorialNumber";
            this.labelTutorialNumber.Size = new System.Drawing.Size(253, 32);
            this.labelTutorialNumber.TabIndex = 0;
            this.labelTutorialNumber.Text = "Badanie instruktażowe";
            // 
            // panelBadanie1
            // 
            this.panelBadanie1.Controls.Add(this.label9);
            this.panelBadanie1.Controls.Add(this.badanie1Odpowiedz4);
            this.panelBadanie1.Controls.Add(this.badanie1Odpowiedz3);
            this.panelBadanie1.Controls.Add(this.badanie1Odpowiedz2);
            this.panelBadanie1.Controls.Add(this.badanie1Odpowiedz1);
            this.panelBadanie1.Controls.Add(this.badanie1NagranieB);
            this.panelBadanie1.Controls.Add(this.badanie1NagranieA);
            this.panelBadanie1.Controls.Add(this.label10);
            this.panelBadanie1.Controls.Add(this.label11);
            this.panelBadanie1.Controls.Add(this.label12);
            this.panelBadanie1.Controls.Add(this.label13);
            this.panelBadanie1.Controls.Add(this.label14);
            this.panelBadanie1.Controls.Add(this.label15);
            this.panelBadanie1.Location = new System.Drawing.Point(11, 13);
            this.panelBadanie1.Margin = new System.Windows.Forms.Padding(6);
            this.panelBadanie1.Name = "panelBadanie1";
            this.panelBadanie1.Size = new System.Drawing.Size(1486, 960);
            this.panelBadanie1.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 503);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(642, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "W którym z nagrań perkusja sprawia wrażenie głośniejszej?";
            // 
            // badanie1Odpowiedz4
            // 
            this.badanie1Odpowiedz4.FormattingEnabled = true;
            this.badanie1Odpowiedz4.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie1Odpowiedz4.Location = new System.Drawing.Point(1124, 497);
            this.badanie1Odpowiedz4.Margin = new System.Windows.Forms.Padding(6);
            this.badanie1Odpowiedz4.Name = "badanie1Odpowiedz4";
            this.badanie1Odpowiedz4.Size = new System.Drawing.Size(342, 40);
            this.badanie1Odpowiedz4.TabIndex = 12;
            this.badanie1Odpowiedz4.SelectedIndexChanged += new System.EventHandler(this.badanie1Odpowiedz4_SelectedIndexChanged);
            // 
            // badanie1Odpowiedz3
            // 
            this.badanie1Odpowiedz3.FormattingEnabled = true;
            this.badanie1Odpowiedz3.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie1Odpowiedz3.Location = new System.Drawing.Point(1124, 414);
            this.badanie1Odpowiedz3.Margin = new System.Windows.Forms.Padding(6);
            this.badanie1Odpowiedz3.Name = "badanie1Odpowiedz3";
            this.badanie1Odpowiedz3.Size = new System.Drawing.Size(342, 40);
            this.badanie1Odpowiedz3.TabIndex = 11;
            this.badanie1Odpowiedz3.SelectedIndexChanged += new System.EventHandler(this.badanie1Odpowiedz3_SelectedIndexChanged);
            // 
            // badanie1Odpowiedz2
            // 
            this.badanie1Odpowiedz2.FormattingEnabled = true;
            this.badanie1Odpowiedz2.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie1Odpowiedz2.Location = new System.Drawing.Point(1124, 331);
            this.badanie1Odpowiedz2.Margin = new System.Windows.Forms.Padding(6);
            this.badanie1Odpowiedz2.Name = "badanie1Odpowiedz2";
            this.badanie1Odpowiedz2.Size = new System.Drawing.Size(342, 40);
            this.badanie1Odpowiedz2.TabIndex = 10;
            this.badanie1Odpowiedz2.SelectedIndexChanged += new System.EventHandler(this.badanie1Odpowiedz2_SelectedIndexChanged);
            // 
            // badanie1Odpowiedz1
            // 
            this.badanie1Odpowiedz1.FormattingEnabled = true;
            this.badanie1Odpowiedz1.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie1Odpowiedz1.Location = new System.Drawing.Point(1124, 250);
            this.badanie1Odpowiedz1.Margin = new System.Windows.Forms.Padding(6);
            this.badanie1Odpowiedz1.Name = "badanie1Odpowiedz1";
            this.badanie1Odpowiedz1.Size = new System.Drawing.Size(342, 40);
            this.badanie1Odpowiedz1.TabIndex = 9;
            this.badanie1Odpowiedz1.SelectedIndexChanged += new System.EventHandler(this.badanie1Odpowiedz1_SelectedIndexChanged);
            // 
            // badanie1NagranieB
            // 
            this.badanie1NagranieB.Location = new System.Drawing.Point(464, 145);
            this.badanie1NagranieB.Margin = new System.Windows.Forms.Padding(6);
            this.badanie1NagranieB.Name = "badanie1NagranieB";
            this.badanie1NagranieB.Size = new System.Drawing.Size(139, 49);
            this.badanie1NagranieB.TabIndex = 7;
            this.badanie1NagranieB.Text = "Start/stop";
            this.badanie1NagranieB.UseVisualStyleBackColor = true;
            this.badanie1NagranieB.Click += new System.EventHandler(this.badanie1NagranieB_Click);
            // 
            // badanie1NagranieA
            // 
            this.badanie1NagranieA.Location = new System.Drawing.Point(93, 145);
            this.badanie1NagranieA.Margin = new System.Windows.Forms.Padding(6);
            this.badanie1NagranieA.Name = "badanie1NagranieA";
            this.badanie1NagranieA.Size = new System.Drawing.Size(139, 49);
            this.badanie1NagranieA.TabIndex = 6;
            this.badanie1NagranieA.Text = "Start/stop";
            this.badanie1NagranieA.UseVisualStyleBackColor = true;
            this.badanie1NagranieA.Click += new System.EventHandler(this.badanie1NagranieA_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 420);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1047, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "Które z nagrań brzmi bardziej selektywnie (łatwiej usłyszeć/rozróżnić poszczególn" +
    "e instrumenty)?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 337);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1080, 32);
            this.label11.TabIndex = 4;
            this.label11.Text = "Które z nagrań jest bardziej przestrzenne (sprawia wrażenie nagranego w większym " +
    "pomieszczeniu)?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 256);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(312, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Które z nagrań brzmi lepiej?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(464, 107);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nagranie B";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(93, 107);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 32);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nagranie A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 36);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 32);
            this.label15.TabIndex = 0;
            this.label15.Text = "Badanie nr 1: Mrozu";
            // 
            // panelBadanie2
            // 
            this.panelBadanie2.Controls.Add(this.badanie2Odpowiedz1);
            this.panelBadanie2.Controls.Add(this.label16);
            this.panelBadanie2.Controls.Add(this.label17);
            this.panelBadanie2.Controls.Add(this.badanie2Odpowiedz5);
            this.panelBadanie2.Controls.Add(this.badanie2Odpowiedz4);
            this.panelBadanie2.Controls.Add(this.badanie2Odpowiedz3);
            this.panelBadanie2.Controls.Add(this.badanie2Odpowiedz2);
            this.panelBadanie2.Controls.Add(this.badanie2NagranieB);
            this.panelBadanie2.Controls.Add(this.badanie2NagranieA);
            this.panelBadanie2.Controls.Add(this.label18);
            this.panelBadanie2.Controls.Add(this.label19);
            this.panelBadanie2.Controls.Add(this.label20);
            this.panelBadanie2.Controls.Add(this.label21);
            this.panelBadanie2.Controls.Add(this.label22);
            this.panelBadanie2.Controls.Add(this.label23);
            this.panelBadanie2.Location = new System.Drawing.Point(11, 13);
            this.panelBadanie2.Margin = new System.Windows.Forms.Padding(6);
            this.panelBadanie2.Name = "panelBadanie2";
            this.panelBadanie2.Size = new System.Drawing.Size(1486, 960);
            this.panelBadanie2.TabIndex = 17;
            // 
            // badanie2Odpowiedz1
            // 
            this.badanie2Odpowiedz1.FormattingEnabled = true;
            this.badanie2Odpowiedz1.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie2Odpowiedz1.Location = new System.Drawing.Point(1124, 250);
            this.badanie2Odpowiedz1.Margin = new System.Windows.Forms.Padding(6);
            this.badanie2Odpowiedz1.Name = "badanie2Odpowiedz1";
            this.badanie2Odpowiedz1.Size = new System.Drawing.Size(342, 40);
            this.badanie2Odpowiedz1.TabIndex = 16;
            this.badanie2Odpowiedz1.SelectedIndexChanged += new System.EventHandler(this.badanie2Odpowiedz1_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 585);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label16.Size = new System.Drawing.Size(758, 32);
            this.label16.TabIndex = 15;
            this.label16.Text = "W którym z nagrań główny wokal cechuje się większą zrozumiałością?";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 503);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(642, 32);
            this.label17.TabIndex = 14;
            this.label17.Text = "W którym z nagrań perkusja sprawia wrażenie głośniejszej?";
            // 
            // badanie2Odpowiedz5
            // 
            this.badanie2Odpowiedz5.FormattingEnabled = true;
            this.badanie2Odpowiedz5.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie2Odpowiedz5.Location = new System.Drawing.Point(1124, 578);
            this.badanie2Odpowiedz5.Margin = new System.Windows.Forms.Padding(6);
            this.badanie2Odpowiedz5.Name = "badanie2Odpowiedz5";
            this.badanie2Odpowiedz5.Size = new System.Drawing.Size(342, 40);
            this.badanie2Odpowiedz5.TabIndex = 13;
            this.badanie2Odpowiedz5.SelectedIndexChanged += new System.EventHandler(this.badanie2Odpowiedz5_SelectedIndexChanged);
            // 
            // badanie2Odpowiedz4
            // 
            this.badanie2Odpowiedz4.FormattingEnabled = true;
            this.badanie2Odpowiedz4.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie2Odpowiedz4.Location = new System.Drawing.Point(1124, 497);
            this.badanie2Odpowiedz4.Margin = new System.Windows.Forms.Padding(6);
            this.badanie2Odpowiedz4.Name = "badanie2Odpowiedz4";
            this.badanie2Odpowiedz4.Size = new System.Drawing.Size(342, 40);
            this.badanie2Odpowiedz4.TabIndex = 12;
            this.badanie2Odpowiedz4.SelectedIndexChanged += new System.EventHandler(this.badanie2Odpowiedz4_SelectedIndexChanged);
            // 
            // badanie2Odpowiedz3
            // 
            this.badanie2Odpowiedz3.FormattingEnabled = true;
            this.badanie2Odpowiedz3.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie2Odpowiedz3.Location = new System.Drawing.Point(1124, 414);
            this.badanie2Odpowiedz3.Margin = new System.Windows.Forms.Padding(6);
            this.badanie2Odpowiedz3.Name = "badanie2Odpowiedz3";
            this.badanie2Odpowiedz3.Size = new System.Drawing.Size(342, 40);
            this.badanie2Odpowiedz3.TabIndex = 11;
            this.badanie2Odpowiedz3.SelectedIndexChanged += new System.EventHandler(this.badanie2Odpowiedz3_SelectedIndexChanged);
            // 
            // badanie2Odpowiedz2
            // 
            this.badanie2Odpowiedz2.FormattingEnabled = true;
            this.badanie2Odpowiedz2.Items.AddRange(new object[] {
            "Zdecydowanie Nagranie A",
            "Raczej Nagranie A",
            "Nie slychac roznicy",
            "Raczej Nagranie B",
            "Zdecydowanie Nagranie B"});
            this.badanie2Odpowiedz2.Location = new System.Drawing.Point(1124, 331);
            this.badanie2Odpowiedz2.Margin = new System.Windows.Forms.Padding(6);
            this.badanie2Odpowiedz2.Name = "badanie2Odpowiedz2";
            this.badanie2Odpowiedz2.Size = new System.Drawing.Size(342, 40);
            this.badanie2Odpowiedz2.TabIndex = 10;
            this.badanie2Odpowiedz2.SelectedIndexChanged += new System.EventHandler(this.badanie2Odpowiedz2_SelectedIndexChanged);
            // 
            // badanie2NagranieB
            // 
            this.badanie2NagranieB.Location = new System.Drawing.Point(464, 145);
            this.badanie2NagranieB.Margin = new System.Windows.Forms.Padding(6);
            this.badanie2NagranieB.Name = "badanie2NagranieB";
            this.badanie2NagranieB.Size = new System.Drawing.Size(139, 49);
            this.badanie2NagranieB.TabIndex = 7;
            this.badanie2NagranieB.Text = "Start/stop";
            this.badanie2NagranieB.UseVisualStyleBackColor = true;
            this.badanie2NagranieB.Click += new System.EventHandler(this.badanie2NagranieB_Click);
            // 
            // badanie2NagranieA
            // 
            this.badanie2NagranieA.Location = new System.Drawing.Point(93, 145);
            this.badanie2NagranieA.Margin = new System.Windows.Forms.Padding(6);
            this.badanie2NagranieA.Name = "badanie2NagranieA";
            this.badanie2NagranieA.Size = new System.Drawing.Size(139, 49);
            this.badanie2NagranieA.TabIndex = 6;
            this.badanie2NagranieA.Text = "Start/stop";
            this.badanie2NagranieA.UseVisualStyleBackColor = true;
            this.badanie2NagranieA.Click += new System.EventHandler(this.badanie2NagranieA_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 420);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1047, 32);
            this.label18.TabIndex = 5;
            this.label18.Text = "Które z nagrań brzmi bardziej selektywnie (łatwiej usłyszeć/rozróżnić poszczególn" +
    "e instrumenty)?";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 337);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(1080, 32);
            this.label19.TabIndex = 4;
            this.label19.Text = "Które z nagrań jest bardziej przestrzenne (sprawia wrażenie nagranego w większym " +
    "pomieszczeniu)?";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 256);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(312, 32);
            this.label20.TabIndex = 3;
            this.label20.Text = "Które z nagrań brzmi lepiej?";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(464, 107);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 32);
            this.label21.TabIndex = 1;
            this.label21.Text = "Nagranie B";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(93, 107);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 32);
            this.label22.TabIndex = 0;
            this.label22.Text = "Nagranie A";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(41, 36);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(229, 32);
            this.label23.TabIndex = 0;
            this.label23.Text = "Badanie nr 2: Mrozu";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 1045);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.panelBadanie2);
            this.Controls.Add(this.panelBadanie1);
            this.Controls.Add(this.panelTutorial);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.Text = "Test słuchowy";
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelTutorial.ResumeLayout(false);
            this.panelTutorial.PerformLayout();
            this.panelBadanie1.ResumeLayout(false);
            this.panelBadanie1.PerformLayout();
            this.panelBadanie2.ResumeLayout(false);
            this.panelBadanie2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonNext;
        private Button buttonBack;
        private Panel panelStart;
        private TextBox kodBadanego;
        private Label labelStart;
        private Label labelStartWarning;
        private Panel panelTutorial;
        private Label labelTutorial6;
        private Label labelTutorial5;
        private Label labelTutorial4;
        private Label labelTutorialB;
        private Label labelTutorialA;
        private Label labelTutorialNumber;
        private Button buttonTutorialB;
        private Button buttonTutorialA;
        private ComboBox comboBoxTutorial3;
        private ComboBox comboBoxTutorial2;
        private ComboBox comboBoxTutorial1;
        private Label label1;
        private Label label2;
        private TextBox wiekBadanego;
        private Label label3;
        private CheckBox studentAkustyki;
        private Label label5;
        private ComboBox wyksztalcenieBadanego;
        private ComboBox plecBadanego;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Label label7;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Panel panelBadanie1;
        private Label label9;
        private ComboBox badanie1Odpowiedz4;
        private ComboBox badanie1Odpowiedz3;
        private ComboBox badanie1Odpowiedz2;
        private ComboBox badanie1Odpowiedz1;
        private Button badanie1NagranieB;
        private Button badanie1NagranieA;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Panel panelBadanie2;
        private Label label16;
        private Label label17;
        private ComboBox badanie2Odpowiedz5;
        private ComboBox badanie2Odpowiedz4;
        private ComboBox badanie2Odpowiedz3;
        private ComboBox badanie2Odpowiedz2;
        private Button badanie2NagranieB;
        private Button badanie2NagranieA;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private ComboBox badanie2Odpowiedz1;
    }
}