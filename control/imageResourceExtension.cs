using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace control
{
    [ContentProperty (nameof(Source))]
    public class imageResourceExtension : IMarkupExtension
    {
        public imageResourceExtension()
        {
        }
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if(Source == null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source, typeof(imageResourceExtension).GetTypeInfo().Assembly);
            return imageSource; 
        }
    } 

   
}
