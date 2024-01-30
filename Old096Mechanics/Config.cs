﻿using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Old096Mechanics
{
    public class Config : IConfig
    {
        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not the debug info should be printed out.")]
        public bool Debug { get; set; } = false;

        [Description("Should 096 instakill?")]
        public bool Instakill { get; set; } = true;
    }
}
