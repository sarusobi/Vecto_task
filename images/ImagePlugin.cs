using System;
using System.Collections.Generic;

public interface IImagePlugin
{
    string Name { get; }
    void ApplyEffects(List<Image> images, object parameter);
}