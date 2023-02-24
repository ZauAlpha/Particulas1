using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Particulas
{
    public class Particle
    {
        public float x;
        public float y;
        public float radio;
        private int time;
        private Color color;
        private float speedX;
        private float speedY;
        private float initialX;
        private float initialY;
        private float changeAlpha;
        private int initialAlpha;
        
        public Particle(float x, float y, float radio)
        {
            this.x = x;
            this.y = y;
            var random = new Random();
            this.radio= radio;
            color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255), random.Next(255));
            speedX = random.Next();
            speedY = random.Next();
            time = random.Next();
            speedX = 0.2f;
            speedY = 0.2f;

        }
        public Particle(float x, float y)
        {
            
            var random = new Random();
            this.radio = random.Next(15)+5;
            initialAlpha = random.Next(55) + 200;
            color = Color.FromArgb(initialAlpha, random.Next(10)+135, random.Next(57)+191, random.Next(20)+235);
            speedX = 0;
            speedY = random.Next(4)+1;
            time = random.Next(75)+25;
            changeAlpha = color.A / time;
            this.initialX = this.x = x-radio;
            this.initialY = this.y = y-radio;
            
            

        }
        public void Draw() {
            Form1.graphics.FillEllipse(new SolidBrush(color), x, y, radio * 2, radio * 5);
            Form1.graphics.FillEllipse(new SolidBrush(color), x-radio/2, y+radio, radio * 3, radio * 5);
            if (color.A - changeAlpha >= 0)
            {
                color = Color.FromArgb((int)(color.A - changeAlpha),color.R, color.G, color.B);
            }else {
                x = initialX;
                y=initialY;
                color = Color.FromArgb(initialAlpha, color.R, color.G, color.B);
            }
        }
        public void Move() {
            x += speedX;
            y += speedY;
            
        }

    }
}
