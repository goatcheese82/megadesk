using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Smith
{
    internal class Desk
    {
        private int _width;
        public int Width { get => _width; set => _width = value; }
        private int _height;
        public int Height { get; set; }
        private int _drawers;
        public int Drawers {  get; set; }
        private Material _material;
        public Material Material { get => _material; set => _material = value; }
        
    }

    enum Material : int
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }
}
