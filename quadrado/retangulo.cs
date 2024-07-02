using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrado
{
    internal class retangulo
    {
		private int vertical;

		public int Vertical
		{
			get { return vertical; }

			set
			{ 
				if(vertical >= 0)
				{
					vertical = value;
				}
				else
				{
					this.vertical = 0;
				}
			}
		}
		private int orizontal;

		public int Orizontal
		{
			get { return orizontal; }
			set 
			{
                if (orizontal >= 0)
                {
                    orizontal = value;
                }
                else
                {
                    this.orizontal = 0;
                }
            }
		}

		public int Area
		{
			get { return Vertical * Orizontal; }
			
		}

		public void exibir()
		{
			Console.WriteLine("base: " + Orizontal);
            Console.WriteLine("altura: " + Vertical);
            Console.WriteLine("area: " + Area);
        }


	}
}
