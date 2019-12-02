using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_JSONClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string result;
        public MainWindow()
        {
            InitializeComponent();
        }

        async void callWebServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://whoismyrepresentative.com/getall_mems.php" +
                "?zip=11735&output=json");

            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();

                resultTextBox.Text = result.ToString();

                byte[] byteArray = Encoding.UTF8.GetBytes(result);
                MemoryStream stream = new MemoryStream(byteArray);

                DataContractJsonSerializer inputSerializer;
                inputSerializer = new DataContractJsonSerializer(typeof(RepresentativeList));

                RepresentativeList rl;
                rl = (RepresentativeList)inputSerializer.ReadObject(stream);

                listViewRep.ItemsSource = rl.Representatives;
            }

            
        }
    }
}
