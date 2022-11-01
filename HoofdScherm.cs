using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Windows.Forms;

namespace PureEnergieMeter {
  public partial class HoofdScherm : Form {
    public HoofdScherm() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      HuubsWerk huubsWerk = new HuubsWerk(this);
    }
  }
}
