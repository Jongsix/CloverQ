﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystem
{
    interface IMemberStrategy
    {
        /// <summary>
        /// Estrategia para determinar el pròximo miembro diponible 
        /// </summary>
        /// <returns></returns>
        Member GetNext();
        List<Member> Members { get; set; }
    }
}