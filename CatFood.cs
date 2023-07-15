using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class CatFood : Product
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }
    }
}
