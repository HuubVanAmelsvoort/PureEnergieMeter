using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Windows.Forms;

namespace PureEnergieMeter {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      string basisUrl = "http://smartbridge-3636/";
      string url = "info";
      //string retoer = aanroepen(basisUrl, url);
      EnergieMeterInfo energieMeterInfo = JsonConvert.DeserializeObject<EnergieMeterInfo>(aanroepen(basisUrl, url));
      //Console.WriteLine(retoer);
      url = "meter/now";
      MeterWaardenMomenteel meterWaardenMomenteel = JsonConvert.DeserializeObject<MeterWaardenMomenteel>(aanroepen(basisUrl, url));
      textBox1.Text = energieMeterInfo.model.ToString();
    }
    // zie : https://www.c-sharpcorner.com/article/calling-web-api-using-httpclient/
    private string aanroepen(string basisUrl, string url) {
      using (var client = new HttpClient()) {
        client.BaseAddress = new Uri(basisUrl);
        client.DefaultRequestHeaders.Accept.Clear();
        HttpResponseMessage response = client.GetAsync(url).Result;
        if (response.IsSuccessStatusCode) {
          var responseContent = response.Content;
          return responseContent.ReadAsStringAsync().Result;
        }
      }
      return "fout";
    }
  }
}
