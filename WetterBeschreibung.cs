using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WetterAppDL
{
    internal class WetterBeschreibung
    {
        private string beschreibung;
        private string temperatur;
        private string mintemperatur;
        private string maxtemperatur;
        private string windgeschwindigkeit;
        private string luftfeuchtigkeit;
        private string bewoelkung;
        private string regenmenge;

        internal void setBeschreibung(string beschreibung)
        {
            this.beschreibung = beschreibung;
        }

        internal void setTemperatur(string temperatur)
        {
            this.temperatur = temperatur;
        }
        internal void setMinTemperatur(string mintemperatur)
        {
            this.mintemperatur = mintemperatur;
        }

        internal void setMaxTemperatur(string maxtemperatur)
        {
            this.maxtemperatur = maxtemperatur;
        }

        internal void setWindGeschwindigkeit(string windgeschwindigkeit)
        {
            this.windgeschwindigkeit = windgeschwindigkeit;
        }

        internal void setLuftfeuchtigkeit(string luftfeuchtigkeit)
        {
            this.luftfeuchtigkeit = luftfeuchtigkeit;
        }

        internal void setBewoelkung(string bewoelkung)
        {
            this.bewoelkung = bewoelkung;
        }

        internal void setRegenInMMLLetzten3Stunden(string regenmenge)
        {
            this.regenmenge= regenmenge;
        }


        public override string ToString()
        {
            return "Wetter:              " + beschreibung + Environment.NewLine +
                   "Temperatur beträgt:  " + temperatur + " Grad " + Environment.NewLine +
                   "Min-Temp:            " + mintemperatur + " Grad " + Environment.NewLine +
                   "Max-Temp:            " + maxtemperatur + " Grad " + Environment.NewLine +
                   "Windgeschwindigkeit: " + windgeschwindigkeit + Environment.NewLine +
                   "Luftfeuchtigkeit:    " + luftfeuchtigkeit + " % " + Environment.NewLine +
                   "Bewölkung:           " + "zu % " + bewoelkung + Environment.NewLine +
                   "Regenmenge:          " + regenmenge + " in mm letzten 3 Std. ";
        }

    }
}
