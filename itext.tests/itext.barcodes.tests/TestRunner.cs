﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using iText.Barcodes;
using iText.IO;
using NUnitLite;

class TestRunner
{
    public static void Main(String[] args)
    {
        new AutoRun(typeof(TestRunner).GetAssembly()).Execute(args);
    }
}