﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPalsApp.Entity
{
    public class Participants
    {
        public int ParticipantID { get; set; }
        public string ParticipantName { get; set; }
        public string ParticipantType { get; set; }
        public int EventID { get; set; }
    }
}
