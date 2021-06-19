using System;
using System.Net;



namespace ProyectoU5yU6
{
    public class Comentarios
    {
        public int id;
        public string autor;
        public DateTime fecha;
        private string comentario;
        private string ip;
        private bool vocabulario;
        private int likes;

        public Comentarios()
        {
        }

        public Comentarios(int id, string autor, DateTime fecha, string comentario, string ip, bool vocabulario, int likes)
        {
            Id = id;
            Autor = autor;
            Fecha = fecha;
            Comentario = comentario;
            Ip = ip;
            Vocabulario = vocabulario;
            Likes = likes;
        }

        public int Id { get => id; set => id = value; }
        public string Autor { get => autor; set => autor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public string Ip { get => ip; set => ip = value; }
        public bool Vocabulario { get => vocabulario; set => vocabulario = value; }
        public int Likes { get => likes; set => likes = value; }
        public override string ToString()
        {
            return string.Format($" \n ID: {id}"+ $" Autor: {Autor}"+ $" Fecha: {Fecha}"+ $"  {Comentario}"+ $" Ip: {ip}"+ $" Likes: {Likes}\n");
        }
    }
}
