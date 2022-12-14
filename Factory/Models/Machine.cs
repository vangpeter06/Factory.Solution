using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Machine 
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }
    [DisplayFormat(DataFormatString = "0:MM/DD/YYYY")]
    public DateTime InstallDate { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}