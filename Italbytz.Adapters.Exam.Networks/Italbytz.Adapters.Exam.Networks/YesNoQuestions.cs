using System;
using Italbytz.Ports.Trivia;

namespace Italbytz.Adapters.Exam.Networks
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
                Text = @"Die Mindestlänge von Rahmen reicht um Kollisionen zu vermeiden.",
                Answer = false
            },
            new YesNoQuestion()
            {
                Text = @"Bei bekannter IP-Adresse eines Servers können wir mit dessen Prozessen kommunizieren.",
                Answer = false,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Bei bekannter IP-Adresse eines Webservers können wir Webseiten anfragen.",
                    Answer = true
                }
            },
            new YesNoQuestion()
            {
                Text = @"UDP ist für Videotelefonie besser geeignet als TCP.",
                Answer = true,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"TCP ist für Videotelefonie besser geeignet als UDP.",
                    Answer = false
                }
            },
            new YesNoQuestion()
            {
                Text = @"Alle Netzwerkgeräte im gleichen physischen Netz empfangen Rahmen mit der Zieladresse FF-FF-FF-FF-FF-FF.",
                Answer = true
            },
            new YesNoQuestion()
            {
                Text = @"Die Netzwerktopologie Maschen enthält einen Single Point of Failure.",
                Answer = false,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Die Netzwerktopologie Bus enthält einen Single Point of Failure.",
                    Answer = true
                }
            },
            new YesNoQuestion()
            {
                Text = @"Router untersuchen Rahmen mit Prüfsummen auf Korrektheit.",
                Answer = false,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Bridges untersuchen Rahmen mit Prüfsummen auf Korrektheit.",
                    Answer = true
                }
            },
            new YesNoQuestion()
            {
                Text = @"Bridges vermeiden Kreise mit dem Spanning Tree Protocol.",
                Answer = true,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Router vermeiden Kreise mit dem Spanning Tree Protocol.",
                    Answer = false
                }
            },
            new YesNoQuestion()
            {
                Text = @"Der Leitungscode Non-Return-To-Zero (NRZ) verursacht Probleme bei der Taktwiederherstellung.",
                Answer = true,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Der Leitungscode Manchester verursacht Probleme bei der Taktwiederherstellung.",
                    Answer = false
                }
            },
            new YesNoQuestion()
            {
                Text = @"Gateways in der Vermittlungsschicht von Computernetzen werden häufig eingesetzt.",
                Answer = false,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Gateways in der Vermittlungsschicht von Computernetzen sind heutzutage selten nötig.",
                    Answer = true
                }
            },
            new YesNoQuestion()
            {
                Text = @"Telnet ermöglicht die verschlüsselte Fernsteuerung von Computern.",
                Answer = false,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Telnet ermöglicht die unverschlüsselte Fernsteuerung von Computern.",
                    Answer = true
                }
            },
            new YesNoQuestion()
            {
                Text = @"DHCP ermöglicht die Zuweisung der Netzwerkkonfiguration an Netzwerkgeräte.",
                Answer = true,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"ICMP ermöglicht die Zuweisung der Netzwerkkonfiguration an Netzwerkgeräte.",
                    Answer = false
                }
            },
            new YesNoQuestion()
            {
                Text = @"ICMP dient dazu, Diagnose- und Fehlermeldungen auszutauschen.",
                Answer = true,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"DHCP dient dazu, Diagnose- und Fehlermeldungen auszutauschen.",
                    Answer = false
                }
            },
            new YesNoQuestion()
            {
                Text = @"Im Ethernet-Rahmen stehen die MAC-Adressen von Sender und Empfänger.",
                Answer = true,
                AlternativeQuestion = new YesNoQuestion()
                {
                    Text = @"Im Ethernet-Rahmen stehen die IP-Adressen von Sender und Empfänger.",
                    Answer = false
                }
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
