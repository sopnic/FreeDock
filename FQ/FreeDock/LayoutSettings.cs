﻿using System.Configuration;

namespace FQ.FreeDock
{
    class LayoutSettings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        public string LayoutXml
        {
            get
            {
                return (string)this["LayoutXml"];
            }
            set
            {
                this["LayoutXml"] = value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("true")]
        public bool IsDefault
        {
            get
            {
                return (bool)this["IsDefault"];
            }
            set
            {
                this["IsDefault"] = value;
            }
        }

        public LayoutSettings(string key) : base(key)
        {
        }

        public override void Save()
        {
            this.IsDefault = false;
            base.Save();
        }
    }
}
