using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace PureEnergieMeter {
  internal class HuubsWerk {

    HoofdScherm hoofdScherm;
    EnergieMeterInfo energieMeterInfo;
    MeterWaardenMomenteel meterWaardenMomenteel;
    public HuubsWerk(HoofdScherm hoofdScherm) {
      this.hoofdScherm = hoofdScherm;

      string basisUrl = "http://smartbridge-3636/";
      string url = "info";

      energieMeterInfo = JsonConvert.DeserializeObject<EnergieMeterInfo>(aanroepen(basisUrl, url));
      url = "meter/now";

      meterWaardenMomenteel = JsonConvert.DeserializeObject<MeterWaardenMomenteel>(aanroepen(basisUrl, url));
      OpSchermTonen();
    }

    private void OpSchermTonen() {
      hoofdScherm.textBoxBatch.Text = energieMeterInfo.batch.ToString();
      hoofdScherm.textBoxHardwareVersie.Text = energieMeterInfo.hw.ToString();
      hoofdScherm.textBoxId.Text = energieMeterInfo.id.ToString();
      hoofdScherm.textBoxLeverancier.Text = energieMeterInfo.mf.ToString();
      hoofdScherm.textBoxSoftwareVersie.Text = energieMeterInfo.fw.ToString();
      hoofdScherm.textBoxModel.Text = energieMeterInfo.model.ToString();


      hoofdScherm.textBoxGebruikMomenteel.Text = meterWaardenMomenteel.elec.power.now.value.ToString();
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
