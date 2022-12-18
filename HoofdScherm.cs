using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Windows.Forms;

namespace PureEnergieMeter {
  public partial class HoofdScherm : Form {
    HuubsWerk huubsWerk;
    public HoofdScherm() {
      InitializeComponent();
    }

    private void buttonOpvragenGegevens_Click(object sender, EventArgs e) {
      huubsWerk = new HuubsWerk(this, false);
    }
    private void buttonContinu_Click(object sender, EventArgs e) {
      huubsWerk = new HuubsWerk(this, true);
    }

    private void buttonStop_Click(object sender, EventArgs e) {
      huubsWerk = new HuubsWerk(this);
      huubsWerk.Stop(sender, e);
    }
  }
}
