using DesignPattern.BehaviorPatternGroup.ProxyPattern.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.ProxyPattern.Service
{
    public class RealVideo : IVideo
    {
        private string _fileName;

        public RealVideo(string fileName)
        {
            this._fileName = fileName;
            LoadFormDisk(_fileName);
        }

        public void Display()
        {
            Console.WriteLine($"Displaying ... {_fileName}");
        }

        private void LoadFormDisk(string fileName)
        {
            Console.WriteLine($"Load form disk {fileName}");
        }
    }
}
