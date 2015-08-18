using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatmanGame.GameObjects
{
    public abstract class GameObject
    {
        public Position Position { get; set; }
        public Size Bouns { get; set; }
    }
}
