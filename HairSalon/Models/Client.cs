using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName {get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public virtual Client Client { get; set; }
  }
}