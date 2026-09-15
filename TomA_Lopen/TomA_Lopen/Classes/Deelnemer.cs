using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TomA_Lopen
{
    internal class Deelnemer
    {
        // Tom Adriaens 
        // 11/09/2026
        // Project Lopen

        // Velden + Properties 
        String _naam { get; set; } = "";
        int _afstand { get; set; } = 0;
        bool _betaald { get; set; } = false;



        // Functies
        // neemt alle gegevens en zet deze om naar een tekst
        public String AlleGegevens()
        {
            String antwoord = "";

            antwoord = $"Deelnemer: {_naam}, loopt {_afstand}km, ";
            if(_betaald)
            {
                antwoord += $"en heeft betaald";
            }
            else
            {
                antwoord += $"en heeft NIET betaald";
            }

            return antwoord;
        }

        // Toont welke afstand een bepaald loper heeft en of hij betaald heeft
        public String AfstEnBetaald()
        {
            String antwoord = "";

            antwoord = $"De gekozen afstand {_afstand}km, ";
            if (_betaald)
            {
                antwoord += $"heeft betaald";
            }
            else
            {
                antwoord += $"heeft NIET betaald";
            }

            return antwoord;
        }

        // Constructors
        // Default contstructor
        public Deelnemer() { }
        public Deelnemer(string ontvNaam, int ontvAfst, bool ontvBetaald) 
        {
            _naam = ontvNaam;
            _afstand = ontvAfst;
            _betaald = ontvBetaald;
        }

    }
}
