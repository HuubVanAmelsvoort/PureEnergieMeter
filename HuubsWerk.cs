using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PureEnergieMeter {
  internal class HuubsWerk {

    HoofdScherm hoofdScherm;
    EnergieMeterInfo energieMeterInfo;
    MeterWaardenMomenteel meterWaardenMomenteel;


    public HuubsWerk(HoofdScherm hoofdScherm, bool continu) {
      hoofdScherm.buttonStop.Enabled = false;
      hoofdScherm.backgroundWorker1.WorkerSupportsCancellation = true;

      this.hoofdScherm = hoofdScherm;
      if (continu) {
        doeContinu();
      } else {
        doeDeActie();
      }
    }

    public HuubsWerk(HoofdScherm hoofdScherm) {
      this.hoofdScherm = hoofdScherm;
    }
    private void doeContinu() {
      if (false == hoofdScherm.backgroundWorker1.IsBusy) {
        //volgende regel niet in het voorbeeld
        hoofdScherm.backgroundWorker1.DoWork += deFunctie;
        hoofdScherm.backgroundWorker1.RunWorkerAsync();
        hoofdScherm.buttonStop.Enabled = true;
        hoofdScherm.buttonContinue.Enabled = false;
      }
    }
    private void deFunctie(object sender, DoWorkEventArgs e) {
      while (!hoofdScherm.backgroundWorker1.CancellationPending) {
        hoofdScherm.Invoke((MethodInvoker)delegate {
          doeDeActie();
        });
        Thread.Sleep(300);

      } // end while
    }

    private void doeDeActie() {
      string basisUrl = "http://smartbridge-3636/";
      string url = "info";

      energieMeterInfo = JsonConvert.DeserializeObject<EnergieMeterInfo>(aanroepen(basisUrl, url));
      url = "meter/now";

      meterWaardenMomenteel = JsonConvert.DeserializeObject<MeterWaardenMomenteel>(aanroepen(basisUrl, url));
      OpSchermTonen();
    }
    internal void Stop(object sender, EventArgs e) {
      if (hoofdScherm.backgroundWorker1.IsBusy) {
        hoofdScherm.backgroundWorker1.CancelAsync();
        hoofdScherm.buttonStop.Enabled = false;
        hoofdScherm.buttonContinue.Enabled = true;
      }
    }
    private void OpSchermTonen() {
      hoofdScherm.textBoxBatch.Text = energieMeterInfo.batch.ToString();
      hoofdScherm.textBoxHardwareVersie.Text = energieMeterInfo.hw.ToString();
      hoofdScherm.textBoxId.Text = energieMeterInfo.id.ToString();
      hoofdScherm.textBoxLeverancier.Text = energieMeterInfo.mf.ToString();
      hoofdScherm.textBoxSoftwareVersie.Text = energieMeterInfo.fw.ToString();
      hoofdScherm.textBoxModel.Text = energieMeterInfo.model.ToString();


      hoofdScherm.textBoxGebruikMomenteel.Text = meterWaardenMomenteel.elec.power.now.value.ToString();
      Console.WriteLine("Gebruik momenteel : " + hoofdScherm.textBoxGebruikMomenteel.Text);
      long tijd = meterWaardenMomenteel.elec.power.now.time;
      DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
      DateTime date = start.AddSeconds(tijd).ToLocalTime();

      //      string fromTimeString = date.ToString("dd-MM-yyyy HH:mm.ss");
      string fromTimeString = date.ToString("HH:mm.ss");
      hoofdScherm.Kwh.Series["Kwh"].Points.AddXY(fromTimeString
        , meterWaardenMomenteel.elec.power.now.value.ToString());

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

