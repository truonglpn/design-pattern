//using DesignPattern.BehaviorPatternGroup.ProxyPattern.Proxy;
//using DesignPattern.BehaviorPatternGroup.ProxyPattern.ServiceInterface;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPattern.BehaviorPatternGroup.ProxyPattern
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IVideo newVideo = new VideoProxy("Proxy Pattern.mp4");

//            // video first load from disk
//            newVideo.Display();

//            Console.WriteLine("after loading first time\n");
//            // video don't load again from disk
//            newVideo.Display();
//        }
//    }
//}
