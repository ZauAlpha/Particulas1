namespace Particulas
{
    public partial class Form1 : Form
    {
        
        public static Graphics graphics;
        public static List<Particle> particles;
        public static float time;
        private Bitmap bitmap;


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

        private void PICTURE_BOX_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            time = 0;
            
            Init();

        }
        private void Init()
        {
            particles = new List<Particle>();
            PICTURE_BOX.Size = new Size(this.Size.Width - 30, this.Size.Height - 30);
            PICTURE_BOX.Location = new Point(5, 5);
            bitmap = new(PICTURE_BOX.Width, PICTURE_BOX.Height);
            graphics = Graphics.FromImage(bitmap);
            PICTURE_BOX.Image = bitmap;
            Random random = new Random();
            for (int i = 0; i < 750; i++)
            {
                particles.Add(new Particle(random.Next(PICTURE_BOX.Width), random.Next(PICTURE_BOX.Height / 8)));

            }

        }
    }
}