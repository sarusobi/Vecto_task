using System;
using System.Collections.Generic;

public class PluginManager
{
    private List<IImagePlugin> plugins;

    public PluginManager()
    {
        plugins = new List<IImagePlugin>();
    }

    public void RegisterPlugin(IImagePlugin plugin)
    {
        plugins.Add(plugin);
    }

    public void ApplyEffects(List<Image> images, object parameter)
    {
        foreach (var plugin in plugins)
        {
            plugin.ApplyEffects(images, parameter);
        }
    }
}