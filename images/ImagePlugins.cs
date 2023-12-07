using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ImagePlugins
{
    public class ResizePlugin : IImagePlugin
    {
        public string Name => "Resize Plugin";

        public void ApplyEffects(List<Image> images, object parameter)
        {
            Console.WriteLine($"Applying resize effect with parameter {parameter} to images");
            // Implement resize logic here (dummy logic for demonstration)
        }
    }

    
}