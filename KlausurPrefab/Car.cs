using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace KlausurPrefab
{
    public class Car
    {
        private Color farbe;
        private string marke;
        private int power;
        private int geschwindigkeit;

        public Car(Color pFarbe, string pMarke, int pPower, int pGeschwindigkeit) 
        {
            farbe = pFarbe;
            marke = pMarke;
            power = pPower;
            geschwindigkeit = pGeschwindigkeit;
        
        }

        public Car()
        {
            farbe = Color.White;
            marke = "Mercedes";
            power = 500;
            geschwindigkeit = 0;
        }

        public Color getFarbe
        {
            get
            {
                return farbe;
            }
        }

        public string getMarke
        {
            get
            {
                return marke;
            }
        }

        public int getPower
        {
            get
            {
                return power;
            }
        }

        public int getGeschwindigkeit
        {
            get
            {
                return geschwindigkeit;
            }
        }

        public void Beschleunigen()
        {
            geschwindigkeit+=10;
        }

        public void Bremsen()
        {
            geschwindigkeit-=10;
        }

        public override string ToString()
        {
            return "Marke: " + marke + " Farbe: " + farbe + " Power: " + power + " Geschwindigkeit: " + geschwindigkeit;
        }
    }
}