﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models
{
    interface IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado();
    }
}
