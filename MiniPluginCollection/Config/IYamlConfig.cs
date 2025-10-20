namespace MiniPluginCollection.Config;

public interface IYamlConfig
{
    void Save();
    static abstract string ConfigPath { get; }
}
