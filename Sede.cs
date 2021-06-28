﻿
namespace Tarea1
{
    class Sede
    {
        private int id;
        private string descripcion;

        public Sede()
        {
        }

        public Sede(int id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public override string ToString()
        {
            return "ID_Sede: " + id + " - " + "Descripcion_Sede: " + descripcion + "\n";
        }
    }
}
