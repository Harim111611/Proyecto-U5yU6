using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Linq;



namespace ProyectoU5yU6
{
    public class ComentariosDB
    {
        public static void SaveToFile(List<Comentarios> comelista, string path)
        {
            StreamWriter textOut = null;

            try
            {

                textOut = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));
                foreach (var c in comelista)
                {
                    textOut.Write(c.id + "|");
                    textOut.Write(c.autor + "|");
                    textOut.Write(c.fecha + "|");
                    textOut.Write(c.Comentario + "|");
                    textOut.Write(c.Ip + "|");
                    textOut.Write(c.Vocabulario + "|");
                    textOut.WriteLine(c.Likes);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
        }

        public static List<Comentarios> ReadFromFile(string path)
        {
            List<Comentarios> comentarios= new List<Comentarios>();

            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            try
            {
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine();
                    string[] columns = row.Split('|');
                    Comentarios c = new Comentarios();

                    c.id = int.Parse(columns[0]);
                    c.autor = (columns[1]);
                    c.fecha = DateTime.Parse(columns[2]);
                    c.Comentario = (columns[3]);
                    c.Ip = (columns[4]);
                    c.Vocabulario = bool.Parse(columns[5]);
                    c.Likes = int.Parse(columns[6]);
                    comentarios.Add(c);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {


                textIn.Close();  

            }
            return comentarios;
               
        }
        public static List<Comentarios> GetLikes(string path)
        {
            List<Comentarios> comentarios;
            List<Comentarios> ComentariosOrdenadosLk = new List<Comentarios>();
            try
            {

                comentarios = ReadFromFile(path);

                var filter_comentarios = from c in comentarios
                                         orderby c.Likes descending
                                         select c;

                foreach (var c in filter_comentarios)
                    ComentariosOrdenadosLk.Add(c);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }    
                return ComentariosOrdenadosLk;
            
        }
        public static List<Comentarios> ComentariosOrenadosFC(string path)
        {
            List<Comentarios> comentarios;
            List<Comentarios> ComentariosOrenadosFC = new List<Comentarios>();
            try
            {

                comentarios = ReadFromFile(path);

                var filter_comentarios = from c in comentarios
                                         orderby c.Fecha descending
                                         select c;

                foreach (var c in filter_comentarios)
                    ComentariosOrenadosFC.Add(c);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return ComentariosOrenadosFC;

        }
        public static void AñadirComentario (List<Comentarios> Addcomentario, string path)
        {
            StreamWriter textOut = null;

            try
            {

                textOut = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write));
                foreach (var c in Addcomentario)
                {
                    textOut.Write(c.id + "|");
                    textOut.Write(c.autor + "|");
                    textOut.Write(c.fecha + "|");
                    textOut.Write(c.Comentario + "|");
                    textOut.Write(c.Ip + "|");
                    textOut.Write(c.Vocabulario + "|");
                    textOut.WriteLine(c.Likes);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            finally
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
        }


    }
}
