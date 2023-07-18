using DesignPattern.BehaviorPatternGroup.ProxyPattern.Service;
using DesignPattern.BehaviorPatternGroup.ProxyPattern.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviorPatternGroup.ProxyPattern.Proxy
{
    public class VideoProxy : IVideo
    {
        private RealVideo realVideo;
        private string fileName;
        public VideoProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realVideo == null) // lazy loading
                realVideo = new RealVideo(fileName);

            realVideo.Display();    
        }
    }
}

