using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern.AbstractPrototype
{
    /// <summary>
    /// the abstract prototype
    /// </summary>
    public abstract class SettingComputerPrototype
    {
        public abstract SettingComputerPrototype Clone(); // shallow copy
        public abstract SettingComputerPrototype DeepCopy();

    }
}
