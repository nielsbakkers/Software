using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IronPdf;
using System.Media;

namespace Memory
{
    public partial class Memory : Form
    {
        //string team gemaakt om de gekozen team op te slaan
        string team;
        //string seizoen gemaakt om het gekozen seizoen op te slaan
        string seizoen;
        //int zetten gemaakt om de zetten op te slaan
        int zetten;
        public Memory()
        {
            InitializeComponent();
            hideMessage();
        }

        //maak niewe random variable
        Random random = new Random();

        //list players met alle spelers die worden geselecteerd
        List<string> players = new List<string>{ "00", "00", "01", "01", "02", "02", "03", "03", "04",
                                                 "04", "05", "05", "06", "06", "07", "07", "08", "08",
                                                 "09", "09", "10", "10", "11", "11", "12", "12", "13",
                                                 "13", "14", "14", "15", "15", "16", "16", "17", "17"};

        List<string> results = new List<string>{ };

        //picturebox aangemaakt om de aangeklikte picture in op te slaan
        PictureBox pictureClickFirst = null;
        PictureBox pictureClickSecond = null;
        int playersIn = 36;


        private void SetPictures()
        {
            //loop door alle controls om een speler te plaatsen
            foreach (Control control in playField.Controls)
            {
                PictureBox picture = control as PictureBox;
                if (picture != null)
                {
                    //kies een random getal 
                    int randomPlace = random.Next(players.Count);
                    //maak string path van het gekozen team en seizoen
                    string path = team + @"\" + seizoen;
                    //plak de path in the string waar de spelerafbeeldingen staan
                    picture.Tag = @"Teams\" + path + @"\image-0000" + players[randomPlace] + ".jpg";
                    //enable de afbeeldingen om aan te klikken
                    picture.Enabled = true;
                    //geef het logo van het gekozen team weer
                    picture.ImageLocation = @"Teams\" + team + @"\Background\logo.png";
                    //verwijder de speler uit de list
                    players.RemoveAt(randomPlace);
                    //verwijder de backgroundimagelayout
                    picture.BackgroundImageLayout = ImageLayout.None;
                }
            }
        }
        private void box_clicked(object sender, EventArgs e)
        {
            //sla de geklikte speler op in clickedPicture
            PictureBox clickedPicture = sender as PictureBox;

            //controleer of de tweede speler is geselecteerd
            if (pictureClickSecond != null)
                return;

            //controleer of de eerste speler is geselecteerd
            if (clickedPicture != null)
            {
                //controleer of de afbeelding het logo is
                if (clickedPicture.ImageLocation != @"Teams\" + team + @"\Background\logo.png")
                    return;
                //controleer of er nog geen eerste speler is geselecteerd
                if (pictureClickFirst == null)
                {
                    //sla de geselecteerde spelersafbeelding op in de picturebox pictureClickFirst
                    pictureClickFirst = clickedPicture;
                    //zet de afbeelding locatie als de waarde die is opgeslagen in de Tag
                    pictureClickFirst.ImageLocation = (string)pictureClickFirst.Tag;
                    return;
                }

                //sla de tweede geselecteerde op in pictureClickSecond
                pictureClickSecond = clickedPicture;
                //zet de afbeelding locatie als de waarde die is opgeslagen in de Tag
                pictureClickSecond.ImageLocation = (string)pictureClickSecond.Tag;

                //voer de methode checkZetten() uit
                checkZetten();
                //voer de methode checkField() uit
                checkField();

                //controlleer of de twee geselecteerde spelers overeen komen
                if (pictureClickFirst.Tag.Equals(pictureClickSecond.Tag))
                {
                    //zoja maak de storage leeg
                    pictureClickFirst = null;
                    pictureClickSecond = null;
                    //playersIn -= 2;
                    return;
                }

                //start de timer
                timer.Start();
            }
        }

        private void checkZetten()
        {
            //controleer of de zetten 0 zijn
            if (zetten == 1)
            {
                //geef de message groupbox weer
                gbMessage.Visible = true;
                //geef de string text weer in de message label
                lblMessage.Text = "Je hebt geen zetten " + "\n" + "meer over! Reset de" + "\n" + "game om opnieuw te" + "\n" + "spelen.";
                //hide de restart button
                btnRestart.Visible = false;
                btnOpen.Visible = false;
                //haal een zet eraf van het totaal zetten
                zetten = zetten - 1;
                //pas de label zetten aan naar het nieuwe totaal zetten
                lblZetten.Text = zetten.ToString();
                //disable alle labels zodat je niet verder kunt spelen wanneer de zetten op zijn
                foreach (Control control in playField.Controls)
                {
                    PictureBox picture = control as PictureBox;
                    picture.Enabled = false;
                }
            }
            else
            {
                //haal een zet eraf van het totaal zetten
                zetten = zetten - 1;
                //pas de label zetten aan naar het nieuwe totaal zetten
                lblZetten.Text = zetten.ToString();
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            //stop de timer
            timer.Stop();

            //pas de afbeeldingen aan naar het team logo
            pictureClickFirst.ImageLocation = @"Teams\" + team + @"\Background\logo.png";
            pictureClickSecond.ImageLocation = @"Teams\" + team + @"\Background\logo.png";
            //maak de storage leeg
            pictureClickFirst = null;
            pictureClickSecond = null;
        }

        int psvWon;
        int ajaxWon;
        int willem2Won;
        int feyenoordWon;
        int totaalZetten;

        private void checkField()
        {
            //controleer alle controls in het speelveld
            foreach (Control control in playField.Controls)
            {
                PictureBox picture = control as PictureBox;

                //controleer alle pictures in het speelveld
                if (picture != null)
                {
                    //controleer of de afbeelding het team logo is
                    if (picture.ImageLocation == @"Teams\" + team + @"\Background\logo.png")
                        return;
                }
            }

            if (team == "PSV")
            {
                psvWon++;
            }else if (team == "Ajax")
            {
                ajaxWon++;
            }else if (team == "Feyenoord")
            {
                feyenoordWon++;
            }else if (team == "WillemII")
            {
                willem2Won++;
            }
            totaalZetten += zetten;

            SoundPlayer sound = new SoundPlayer(@"Sound\Clapping.wav");
            sound.Play();

            //geef de messagebox weer
            gbMessage.Visible = true;
            //geef de string message weer in de label
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text = "Goed gedaan, " + "\n" + "je hebt alle spelers" + "\n" + "gematched!";
            //geef de restart button weer
            btnRestart.Visible = true;
            btnOpen.Visible = false;
            //voeg in de played games de resultaten weer
            lbPlayedGames.Items.Add("Team: " + team + " Seizoen: " + seizoen + " Aantal zetten over: " + zetten);
            results.Add("Team: " + team + " Seizoen: " + seizoen + " Aantal zetten over: " + zetten);
        }



        private void startButton_click(object sender, EventArgs e)
        {
            //run methode checkComboBoxes()
            if (checkComboBoxes())
            {
                //disable cTeam, cSeizoen, cDifficulty
                cTeam.Enabled = false;
                cSeizoen.Enabled = false;
                cDifficulty.Enabled = false;

                //sla het gekozen team en seizoen op in de variable
                team = cTeam.SelectedItem.ToString();
                seizoen = cSeizoen.SelectedItem.ToString();

                //run de methode setPictures()
                SetPictures();

                //disable de start button;
                btnStart.Enabled = false;

                SoundPlayer sound = new SoundPlayer(@"Sound\Whistle.wav");
                sound.Play();

                //controleer de gekozen difficulty en pas het aantal zetten aan op de gekozen difficulty
                if (cDifficulty.SelectedIndex == 0)
                {
                    zetten = 70;
                    lblZetten.Text = zetten.ToString();
                }
                else if (cDifficulty.SelectedIndex == 1)
                {
                    zetten = 65;
                    lblZetten.Text = zetten.ToString();
                }
                else if (cDifficulty.SelectedIndex == 2)
                {
                    zetten = 60;
                    lblZetten.Text = zetten.ToString();
                }
            }
        }


        private bool checkComboBoxes()
        {
            //controleer of de combobox keuze -1 is
            if (cTeam.SelectedIndex.Equals(-1))
            {
                //geef het message box weer
                gbMessage.Visible = true;
                //geef de message string weer in de message label
                lblMessage.Text = "ERROR: Selecteer " + "\n" + "een Team voordat je " + "\n" + "verder gaat!";
                //pas de forecolor aan naar rood
                lblMessage.ForeColor = Color.Red;
                //hide de restart button
                btnRestart.Visible = false;
                btnOpen.Visible = false;
                SoundPlayer sound = new SoundPlayer(@"Sound\Error.wav");
                sound.Play();
                //return de waarde false
                return false;
            }
            //controleer of de combobox keuze -1 is
            else if (cSeizoen.SelectedIndex.Equals(-1))
            {
                gbMessage.Visible = true;
                lblMessage.Text = "ERROR: Selecteer " + "\n" + "een Seizoen voordat " + "\n" + "je verder gaat!";
                lblMessage.ForeColor = Color.Red;
                btnRestart.Visible = false;
                btnOpen.Visible = false;
                SoundPlayer sound = new SoundPlayer(@"Sound\Error.wav");
                sound.Play();
                return false;
            }
            else if (cDifficulty.SelectedIndex.Equals(-1))
            {
                gbMessage.Visible = true;
                lblMessage.Text = "ERROR: Selecteer " + "\n" + "een Moeilijkheidsgraat" + "\n" + "voordat je verder gaat!";
                lblMessage.ForeColor = Color.Red;
                btnRestart.Visible = false;
                btnOpen.Visible = false;
                SoundPlayer sound = new SoundPlayer(@"Sound\Error.wav");
                sound.Play();
                return false;
            }
            return true;
        }

        private void resetGame_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            //enable de start button
            btnStart.Enabled = true;
            //enable de combobox Team
            cTeam.Enabled = true;
            //enable de combobox Seizoen
            cSeizoen.Enabled = true;
            //enable de combobox Difficulty
            cDifficulty.Enabled = true;
            //Zet de combobox op "--Select--"
            cTeam.SelectedIndex = -1;
            cSeizoen.SelectedIndex = -1;
            cDifficulty.SelectedIndex = -1;
            cTeam.Text = "--Select--";
            cSeizoen.Text = "--Select--";
            cDifficulty.Text = "--Select--";

            //Maak alle velden leeg
            foreach (Control control in playField.Controls)
            {
                PictureBox picture = control as PictureBox;
                picture.Tag = "";
                picture.ImageLocation = "";
            }
            //refill de list players opnieuw
            players = new List<string>{ "00", "00", "01", "01", "02", "02", "03", "03", "04",
                                        "04", "05", "05", "06", "06", "07", "07", "08", "08",
                                        "09", "09", "10", "10", "11", "11", "12", "12", "13",
                                        "13", "14", "14", "15", "15", "16", "16", "17", "17"};

            //run the method hideMessage()
            hideMessage();
            //zet de zetten op 0
            zetten = 0;
            //laat het aantal zetten zien in de label Zetten
            lblZetten.Text = zetten.ToString();
        }

        private void hideMessage()
        {
            //hide the message box 
            gbMessage.Visible = false;
        }

        private void comboboxChanged(object sender, EventArgs e)
        {
            //hide the message box 
            gbMessage.Visible = false;
        }

        private void startNew_click(object sender, EventArgs e)
        {
            //run the method resetGame()
            resetGame();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            solveGame();
        }

        PictureBox solveClickOne = null;
        PictureBox solveClickTwo = null;

        Random rdm = new Random();
        int storage = 0;
        int solvePlayers = 36;


        private void solveGame()
        {
            //int rdmi = rdm.Next(solvePlayers.Count());
            int rdmi = rdm.Next(solvePlayers);
            //int rdmi = rdm.Next(playersIn);
            if(playersIn <= 2)
            {
                playersIn = 36;
                return;
            }
            while (rdmi == storage)
            {
                //rdmi = rdm.Next(solvePlayers.Count());
                rdmi = rdm.Next(solvePlayers);
            }
            storage = rdmi;
            PictureBox clickedPicture = playField.Controls[rdmi] as PictureBox;

            //controleer of de tweede speler is geselecteerd
            if (solveClickTwo != null)
                return;

            //controleer of de eerste speler is geselecteerd
            if (clickedPicture != null)
            {
                //controleer of de afbeelding het logo is
                if (clickedPicture.ImageLocation != @"Teams\" + team + @"\Background\logo.png")
                {
                    solveGame();
                    return;
                }
                //controleer of er nog geen eerste speler is geselecteerd
                if (solveClickOne == null)
                {
                    //sla de geselecteerde spelersafbeelding op in de picturebox pictureClickFirst
                    solveClickOne = clickedPicture;
                    //zet de afbeelding locatie als de waarde die is opgeslagen in de Tag
                    solveClickOne.ImageLocation = (string)solveClickOne.Tag;
                    solveGame();
                    return;
                }
                //sla de tweede geselecteerde op in pictureClickSecond
                solveClickTwo = clickedPicture;
                //zet de afbeelding locatie als de waarde die is opgeslagen in de Tag
                solveClickTwo.ImageLocation = (string)solveClickTwo.Tag;
                solveGame();

                //voer de methode checkField() uit
                checkField();

                //controlleer of de twee geselecteerde spelers overeen komen
                if (solveClickOne.Tag.Equals(solveClickTwo.Tag))
                {
                    solveClickOne = null;
                    solveClickTwo = null;
                    playersIn -= 2;
                    solveGame();
                    return;
                }

                //start de timer
                timerSolve.Start();
            }
        }

        private void timerTickSolve(object sender, EventArgs e)
        {
            //stop de timer
            timerSolve.Stop();

            //pas de afbeeldingen aan naar het team logo
            solveClickOne.ImageLocation = @"Teams\" + team + @"\Background\logo.png";
            solveClickTwo.ImageLocation = @"Teams\" + team + @"\Background\logo.png";
            //maak de storage leeg
            solveClickOne = null;
            solveClickTwo = null;
            solveGame();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            if (results.Count <= 0)
            {
                SoundPlayer sound = new SoundPlayer(@"Sound\Error.wav");
                sound.Play();
                gbMessage.Visible = true;
                lblMessage.Text = "ERROR: Je moet eerst " + "\n" + "een game oplossen" + "\n" + "voordat je de resultaten" + "\n" + "kan opvragen.";
                lblMessage.ForeColor = Color.Red;
                btnRestart.Visible = false;
                btnOpen.Visible = false;
            }
            else
            {
                SoundPlayer sound = new SoundPlayer(@"Sound\Loading.wav");
                sound.Play();

                var htmlToPdf = new HtmlToPdf();
                var html = @"<style>* {text-align: center;box-sizing: border-box;}h1 {font-size: 72px;color: rgb(127, 168, 38);}h2 {font-size: 36px;color: rgb(127, 168, 38);}p {font-size: 20px;}img {width: 100px;}.box {float: left;width: 25%;padding: 20px;}</style>
                             <h1>Memory game results</h1>
                             <h2>Statistieken:</h2>";

                html += "<p>Je hebt " + results.Count + " memory games opgelost!</p>" +
                        "<div class='view'>" +
                        "<div class='box'><img src='Teams\\PSV\\Background\\logo.png' style='width:120px;'><p>Je hebt " + psvWon + " keer een PSV memory opgelost.</p></div>" +
                        "<div class='box'><img src='Teams\\Ajax\\Background\\logo.png'><p>Je hebt " + ajaxWon + " keer een Ajax memory opgelost.</p></div>" +
                        "<div class='box'><img src='Teams\\Feyenoord\\Background\\logo.png'><p>Je hebt " + feyenoordWon + " keer een Feyenoord memory opgelost.</p></div>" +
                        "<div class='box'><img src='Teams\\WillemII\\Background\\logo.png'><p>Je hebt " + willem2Won + " keer een Willem II memory opgelost.</p></div>" +
                        "</div>" +
                        "<h2>Resultaten:</h2>";

                for (int i = 0; i < results.Count; i++)
                {
                    html += "<p>" + results[i] + "</p>";
                }

                var pdf = htmlToPdf.RenderHtmlAsPdf(html);

                pdf.SaveAs(@"Results\results.pdf");

                gbMessage.Visible = true;
                lblMessage.Text = "SUCCES: Het exporteren " + "\n" + "van de resultaten is gelukt!" + "\n" + "Klik op de button om naar" + "\n" + "de locatie te gaan.";
                lblMessage.ForeColor = Color.Black;
                btnRestart.Visible = false;
                btnOpen.Visible = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"Results\results.pdf");
        }

    }
}
