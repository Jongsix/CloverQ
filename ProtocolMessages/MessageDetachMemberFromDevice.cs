﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtocolMessages
{
    public class MessageDetachMemberFromDevice : Message
    {
        public string MemberId { get; set; }
        public string DeviceId { get; set; }
    }
}
