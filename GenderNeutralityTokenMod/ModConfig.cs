using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNMTokens
{
    class ModConfig
    {
        public bool Singular { get; set; } = false;
        public string SubjectivePronoun { get; set; } = "They";
        public string ObjectivePronoun { get; set; } = "Them";
        public string PosessivePronoun { get; set; } = "Their";
        public string Title { get; set; } = "Mx.";
        public string Adjective { get; set; } = "Gorgeous";
        public string SpouseNoun { get; set; } = "Partner";
        public string GenericNoun { get; set; } = "Person";
        public string AdultAntiquatedNoun { get; set; } = "Folk";
        public string AdultFamilialNoun { get; set; } = "Kid";
        public string AdultInformalNoun { get; set; } = "Person";
        public string ElderAntiquatedNoun { get; set; } = "Kid";
        public string ElderInformalNoun { get; set; } = "Kid";
        public string ElderFamilialNoun { get; set; } = "Child";
        public string ChildFamilialNoun { get; set; } = "Cousin";
        public string ServiceFormalNoun { get; set; } = "Esteemed Patron";
        public string TraderNoun { get; set; } = "Traveller";
        public string ParentalNoun { get; set; } = "Parent";
    }
}
