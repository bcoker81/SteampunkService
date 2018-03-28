using SteampunkService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SteampunkService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICombat" in both code and config file together.
    [ServiceContract]
    public interface ICombat
    {
        [OperationContract]
        CombatResponse Attack(CombatResponse expected);
    }
}
