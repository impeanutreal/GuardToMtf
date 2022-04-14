using Exiled.API.Interfaces;
using System.ComponentModel;

namespace GuardToMtf
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
    }
}
