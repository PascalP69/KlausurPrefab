using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlausurPrefab
{
    public partial class Form1 : Form
    {
        List <Car> cars = new List <Car> ();
        public Form1()
        {
            InitializeComponent();
            generateCars();
        }
        private void LoadFile()
        {
            string filename = @"..\..\data\filename.txt";
            string content = "";

            if (File.Exists(filename))
            {
                StreamReader myFile = new StreamReader(filename, System.Text.Encoding.Default);

                while (!myFile.EndOfStream)
                {
                    content = myFile.ReadLine();
                    listBox2.Items.Add(content);
                }
                myFile.Close();
            }
        }
        private void SaveFile()
        {
            string filename = @"..\..\data\filename.txt";

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Car p in cars)
                {
                    writer.WriteLine(p);
                }
            }
        }

        private void generateCars()
        {
            Random rnd = new Random();
            for(int i = 0; i < 10; i++) 
            {
                cars.Add(new Car(Color.Black, "NewCar"+i, rnd.Next(50,100),0));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Car car in cars) 
            {

                listBox2.Items.Add(car); 
            }
            
        }

        //Vergleich listen index mit listbox selected index und gibt dann den wert durch dessen get in das label über
        private void btnSelect_Click(object sender, EventArgs e)
        {
            lblBrand.Text = cars.ElementAt(listBox2.SelectedIndex).getMarke;
            lblColor.Text = cars.ElementAt(listBox2.SelectedIndex).getFarbe.ToString();
            lblHorsepower.Text = cars.ElementAt(listBox2.SelectedIndex).getPower.ToString();
            lblSpeed.Text = cars.ElementAt(listBox2.SelectedIndex).getGeschwindigkeit.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
    }
}

/*
 * 
 * 
 * 
 * 
 *  Befehl                                                              Beschreibung
    DateTime datum = new DateTime();                                    1. Instanziierung eines DateTime Objektes.

    DateTime datum = DateTime.Now;                                      2. Ausgabe des Objektes in ein Textfenster. Welches Datum wird angezeigt?
    01.01.0001 00:00:00                                                 
    
    DateTime datum = DateTime.Today;                                    3. Das heutige Datum soll gesetzt und ausgegeben werden.
    
    DateTime datum = new DateTime(2004, 03, 10, 10, 20, 30);            4. Ein beliebiges Datum/Zeit Objekt soll gesetzt und ausgegeben werden.
    
    DateTime newDatum = datum.AddDays(7);                               5. Auf dieses Datum sollen 7 Tage addiert werden.
    
    DateTime datum = new DateTime(2022, 12, 24);                        6. Der Wochentag für den 24.12.2022 soll ausgegeben werden.
    datum.DayOfWeek;  

    datum.Subtract(datumNow);                                           7. Wie viele Tage dauert es noch bis Heiligabend?
    (datum1-datum2).ToString()                                          

    a: dateTimePicker.Value;                                            8. Ein Datum soll über ein Steuerelement eingelesen werden:
                                    

    b:if (DateTime.TryParse(eingabe, out datum1))                       a. DateTimePicker
            {                                                           b. MaskedTextox
 
                Console.WriteLine($"Ergebnis Try Parse {datum1}");
            }
            else
            {
 
                Console.WriteLine($"Fehler : {eingabe}");
            }










 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
