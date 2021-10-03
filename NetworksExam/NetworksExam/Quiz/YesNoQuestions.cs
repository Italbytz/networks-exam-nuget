using System;
using TriviaPorts;

namespace NetworksExam.Quiz
{
    public static class YesNoQuestions
    {
        public static IQuestion[] Questions { get; } = new YesNoQuestion[] {
            new YesNoQuestion()
            {
                Text = @"Die Mindestlänge von Rahmen dient dazu, Kollisionen erkennen zu können.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Bei bekannter IP-Adresse eines Servers können wir mit dessen Prozessen kommunizieren.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"UDP ist für Videotelefonie besser geeignet als TCP.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Alle Netzwerkgeräte im gleichen physischen Netz empfangen Rahmen mit der Zieladresse FF-FF-FF-FF-FF-FF.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Die Netzwerktopologie Maschen enthält einen Single Point of Failure.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Router untersuchen Rahmen mit Prüfsummen auf Korrektheit.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Bridges vermeiden Kreise mit dem Spanning Tree Protocol.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Der Leitungscode Non-Return-To-Zero (NRZ) verursacht Probleme bei der Taktwiederherstellung.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Gateways in der Vermittlungsschicht von Computernetzen werden häufig eingesetzt.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Telnet ermöglicht die verschlüsselte Fernsteuerung von Computern.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"DHCP ermöglicht die Zuweisung der Netzwerkkonfiguration an Netzwerkgeräte.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"ICMP dient dazu, Diagnose- und Fehlermeldungen auszutauschen.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Im Ethernet-Rahmen stehen die MAC-Adressen von Sender und Empfänger.",
                Answer = true
            }
            };

        private class YesNoQuestion : IYesNoQuestion
        {
            public bool Answer { get; set; }
            public string Category { get; set; }
            public QuestionType QuestionType { get; set; }
            public Choices ChoicesType { get; set; }
            public Difficulty Difficulty { get; set; }
            public string Text { get; set; }
            public IQuestion AlternativeQuestion { get; set; }
        }

    }
}
