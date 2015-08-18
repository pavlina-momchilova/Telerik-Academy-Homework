using BatmanGame.GameObjects;
using BatmanGame.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatmanGame.Engines
{
    public class GameEngine
    {
        private IGameRenderer renderer;

        public GameEngine(IGameRenderer renderer)
        {
            this.renderer = renderer;

            this.renderer.Draw();
        }

        internal void InitGame()
        {
        }

        internal void StartGame()
        {
            var batwing = new BatwingGameObject()
            {
                Position = new Position(50, 150),
                Bouns = new Size(30, 70)
            };
            var enemy = new EnemyGameObject()
            {
                Position = new Position(800, 500),
                Bouns = new Size(30, 45)
            };
            var projectile = new ProjectileGameObject()
            {
                Position = new Position(450, 450),
                Bouns = new Size(50, 10)
            };
            this.renderer.Draw(batwing,enemy,projectile);
        }
    }
}
