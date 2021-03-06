﻿using Aspose.Html.Converters;
using Aspose.Html.Rendering.Image;
using Aspose.Html.Saving;

namespace Aspose.Html.Examples.CSharp.Conversion
{
    public class HTMLtoPNG
    {
        public static void Run()
        {
            // ExStart:1
            // The path to the documents directory
            string dataDir = RunExamples.GetDataDir_Data();
            // Source HTML document  
            HTMLDocument htmlDocument = new HTMLDocument(dataDir + "input.html");
            // Initialize ImageSaveOptions 
            ImageSaveOptions options = new ImageSaveOptions(ImageFormat.Png);
            // Output file path 
            string outputFile = dataDir + "HTMLtoPNG_Output.png";
            // Convert HTML to PNG
            Converter.ConvertHTML(htmlDocument, options, outputFile);
            // ExEnd:1           
        }
    }
}
