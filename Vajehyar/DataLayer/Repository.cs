﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vajehyar.Model;

namespace Vajehyar.DataLayer
{
    public class Repository
    {
        public static string[] Getlines()
        {
            string content = Properties.Resources.Farhang_Motaradef_Motazad + Environment.NewLine + Properties.Resources.Farhang_Teyfi;
            string[] lines = content.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            return lines;
        }
    }
}
