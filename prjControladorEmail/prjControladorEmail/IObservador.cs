﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControladorEmail
{
    public interface IObservador
    {
        void ReceberEmail(ISujeito sujeito);
    }
}