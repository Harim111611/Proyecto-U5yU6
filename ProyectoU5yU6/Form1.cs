using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System;



namespace ProyectoU5yU6
{

    public partial class Form1 : Form
    {
        
        List<Comentarios> Comentarios = new List<Comentarios>();
        public Form1()
        {
            InitializeComponent();
            Comentarios.Add(new Comentarios(10, "Harim", new DateTime(2077, 06, 18), "Buenos dias", "192.69.312", false, 20));
            Comentarios.Add(new Comentarios(1132, "Seiya", new DateTime(1997, 06, 18), "Soy el caballero de la esperanza", "192.32.603", true, 50));
            Comentarios.Add(new Comentarios(117, "master chief", new DateTime(4000, 06, 18), "Halo murio en reach", "122.11.777", false, 100));
            Comentarios.Add(new Comentarios(13421, "Steve", new DateTime(8900, 06, 18), "Diamantes", "541.32.532", true, 10000));
            ComentariosDB.SaveToFile(Comentarios, @"C:\Users\Familia Luna\Files\FileComentario.txt");
            MostrarCM(Comentarios);
        }

        public void OrdenarLK(List<Comentarios> OLK)
        {
      
            OLK = ComentariosDB.GetLikes(@"C:\Users\Familia Luna\Files\FileComentario.txt");
            ComentariosDB.SaveToFile(OLK, @"C:\Users\Familia Luna\Files\FileComentario.txt");
            MostrarCM(OLK);
        }
        public void OrdenarFC(List<Comentarios> OF)
        {

            OF = ComentariosDB.ComentariosOrenadosFC(@"C:\Users\Familia Luna\Files\FileComentario.txt");
            ComentariosDB.SaveToFile(OF, @"C:\Users\Familia Luna\Files\FileComentario.txt");
            MostrarCM(OF);
        }
        public  void MostrarCM(List<Comentarios> MostrarComentarios)
        {
            MostrarComentarios = ComentariosDB.ReadFromFile(@"C:\Users\Familia Luna\Files\FileComentario.txt");
            textBox1.Clear();
            foreach (var item in MostrarComentarios)
            {
                if (item.Vocabulario == true)

                    textBox1.Text += "\r\n"+"Este comentario es inapropiado" + "\r\n";


                else
                {
                    textBox1.Text += "\r\n"+ item + "\r\n";
                }
            }
            
        }

        private void olk_Click(object sender, EventArgs e)
        {
            OrdenarLK(Comentarios);

        }

        private void OF_Click(object sender, EventArgs e)
        {
            OrdenarFC(Comentarios);
        }

        private void DelCom_Click(object sender, EventArgs e)
        {
            Comentarios.Clear();
            Comentarios Addcomentarios = new Comentarios(10, "Pitbull", DateTime.Today,textBox2.Text,"192.14.234" , false, 1);
            Comentarios.Add(Addcomentarios);
            ComentariosDB.AñadirComentario(Comentarios, @"C:\Users\Familia Luna\Files\FileComentario.txt");
            MostrarCM(Comentarios);
            textBox2.Clear();

        }
    }
}
