using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public interface IFileReader
    {
        string[] Read(string path);
    }
}
