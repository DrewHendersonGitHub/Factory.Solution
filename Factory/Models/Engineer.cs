using System;
using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public DateTime LiscenseRenewal { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}