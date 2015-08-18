using BatmanGame.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BatmanGame.Renderer
{
    public interface IGameRenderer
    {
        void Clear();

        void Draw(params GameObject[] gameObjects);
    }
}
