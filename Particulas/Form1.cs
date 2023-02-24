namespace Particulas
{
    public partial class Form1 : Form
    {
        
        public static Graphics graphics;
        public static List<Particle> particles;
        public static float time;
        private Bitmap layer1, layer2, layer3;


        public Form1()
        {
            InitializeComponent();
        }

        

        private void TIMER_Tick(object sender, EventArgs e)
        {
            ++time;
            
            graphics.Clear(Color.Black);
            
            for (int i = 0; i < particles.Count; i++) {
                particles[i].Draw();
                particles[i].Move();
            }

            PICTURE_BOX.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            layer1 = new(PICTURE_BOX.Width, PICTURE_BOX.Height);
            graphics= Graphics.FromImage(layer1);
            particles= new List<Particle>();
            time = 0;
            PICTURE_BOX.Image = layer1;
            Random random= new Random();
            for (int i = 0; i < 250; i++)
            {
                particles.Add(new Particle(random.Next(PICTURE_BOX.Width), random.Next(PICTURE_BOX.Height/8)));

            }
           



        }
    }
}