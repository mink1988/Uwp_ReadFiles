using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Uwp_Library;
using Windows.ApplicationModel;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography.Core;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Uwp_Read_Xml
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        public MainPage()
        {
            this.InitializeComponent();

            var doc = new System.Xml.XmlDocument();
            var path = Directory.GetCurrentDirectory() + @"\xm.xml";
            doc.Load(path);

            System.Xml.XmlNodeList nodes = doc.GetElementsByTagName("Persons");

            foreach (XmlNode node in nodes)
            {
              foreach (XmlNode child in node.ChildNodes)
            {
                    
                    ListView.Items.Add(child.InnerText);
            }
            }
            
            

        }
    
        
    
    
    }

}






//

//var doc = new System.Xml.XmlDocument();
//var path = Directory.GetCurrentDirectory() + @"\xm.xml";
//doc.Load(path);

//System.Xml.XmlNodeList nodes = doc.GetElementsByTagName("person");

//foreach (XmlNode node in nodes)
//{
  //  foreach (XmlNode child in node.ChildNodes)
    //{
      //  ListView.Items.Add(child.ChildNodes);
    //}
//}