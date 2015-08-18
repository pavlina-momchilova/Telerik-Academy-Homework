using BatmanGame.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BatmanGame.Renderer
{
    public class wpfGameRenderer:IGameRenderer
    {
        private Canvas canvas;

        public wpfGameRenderer(Canvas canvas)
        {
            this.canvas = canvas;
            this.canvas.KeyDown += (sender, args) =>
            {
                var key = args.Key;
                if (key == Key.Down)
                {

                }
                else if (key == Key.Up)
                {

                }
                else if (key == Key.Space)
                {

                }

            };
        }
        public void Clear()
        {
            this.canvas.Children.Clear();
        }

        public void Draw(params GameObject[] gameObjects)
        {
            foreach (var go in gameObjects)
            {
                if (go is BatwingGameObject)
                {
                    this.DrawBatwing(go);
                }
                else if(go is EnemyGameObject)
                {
                    this.DrawEnemy(go);
                }
                else if (go is ProjectileGameObject)
                {
                    this.DrawProjectile(go);
                }
            }
            
        }

        private void DrawProjectile(GameObject projectile)
        {
            var rect = new Rectangle
            {
                Width = projectile.Bouns.Width,
                Height = projectile.Bouns.Height,
                Fill = Brushes.Red,
                StrokeThickness = 2
            };
            Canvas.SetLeft(rect, projectile.Position.Left);
            Canvas.SetTop(rect, projectile.Position.Top);
            this.canvas.Children.Add(rect);
        }

        private void DrawEnemy(GameObject enemy)
        {
            var ell = new Ellipse
            {
                Width = enemy.Bouns.Width,
                Height = enemy.Bouns.Height,
                Fill=Brushes.Brown,
                StrokeThickness=2
            };
            Canvas.SetLeft(ell, enemy.Position.Left);
            Canvas.SetTop(ell, enemy.Position.Top);
            this.canvas.Children.Add(ell);
        }

        private void DrawBatwing(GameObject batwing)
        {
            Image image = new Image();
            BitmapImage batwingImageSource = new BitmapImage();
            batwingImageSource.BeginInit();
            batwingImageSource.UriSource = new Uri("/Images/batwing.png",UriKind.Relative);
            batwingImageSource.EndInit();

            image.Source = batwingImageSource;
            image.Width = batwing.Bouns.Width;
            image.Height = batwing.Bouns.Height;

            Canvas.SetLeft(image, batwing.Position.Left);
            Canvas.SetTop(image, batwing.Position.Top);
            this.canvas.Children.Add(image);
        }
    }
}
