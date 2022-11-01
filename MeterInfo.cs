using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureEnergieMeter {
  // MeterInfo myDeserializedClass = JsonConvert.DeserializeObject<MeterInfo>(myJsonResponse);
  public class Elec {
    public Power power { get; set; }
    public Import import { get; set; }
    public Export export { get; set; }
  }

  public class Export {
    public Now now { get; set; }
  }

  public class Gas {
  }

  public class Import {
    public Now now { get; set; }
  }

  public class Max {
    public int value { get; set; }
    public string unit { get; set; }
    public int time { get; set; }
  }

  public class Min {
    public int value { get; set; }
    public string unit { get; set; }
    public int time { get; set; }
  }

  public class Now {
    public int value { get; set; }
    public string unit { get; set; }
    public int time { get; set; }
  }

  public class Power {
    public Now now { get; set; }
    public Min min { get; set; }
    public Max max { get; set; }
  }

  public class MeterWaardenMomenteel {
    public string status { get; set; }
    public Elec elec { get; set; }
    public Gas gas { get; set; }
  }
}
