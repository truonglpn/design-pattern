using DesignPattern.PrototypePattern.AbstractPrototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    /// <summary>
    /// the concrete prototype
    /// </summary>
    class SettingComputer : SettingComputerPrototype
    {
        private string SoftKillVirus;
        private string SoftOffice;
        private int Version;

        public SettingComputer(string SoftKillVirus, string SoftOffice)
        {
            this.SoftKillVirus = SoftKillVirus;
            this.SoftOffice = SoftOffice;
        }

        public SettingComputer(string SoftKillVirus, string SoftOffice,  int Version)
        {
            this.SoftKillVirus = SoftKillVirus;
            this.SoftOffice = SoftOffice;
            this.Version = Version;
        }
        public override SettingComputerPrototype Clone()
        {
            return this.MemberwiseClone() as SettingComputer;
        }

        public override SettingComputerPrototype DeepCopy()
        {
            SettingComputer setting = (SettingComputer)this.MemberwiseClone();
            setting.SoftKillVirus = this.SoftKillVirus;
            setting.SoftOffice = this.SoftOffice;
            setting.Version = this.Version;
            return setting;
        }
    }
}
