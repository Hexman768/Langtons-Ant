using System.Collections.Generic;

namespace Langton_s_Ant.Core
{
    public class Row
    {
        internal List<Block> blocks { get; set; }

        public Row()
        {
            blocks = new List<Block>();
        }

        public void AddBlock()
        {
            blocks.Add(new Block());
        }
    }
}
