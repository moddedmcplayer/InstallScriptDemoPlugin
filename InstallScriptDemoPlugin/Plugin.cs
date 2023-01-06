namespace InstallScriptDemoPlugin
{
    using PluginAPI.Core.Attributes;

    public class Plugin
    {
        [PluginEntryPoint("InstallScriptDemoPlugin", "1.0.0", "Description", "moddedmcplayer")]
        void Enabled(){}
    }
}