﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysDeObjetos
{
    class PerroSalchicha : Perro
    {
        public PerroSalchicha()
        {
            Console.WriteLine("Ha nacido una aberración");
        }

        public override void Hablar()
        {
            base.Hablar();
            Console.WriteLine("Wiiiiiiiiif!");
        }
    }
}
