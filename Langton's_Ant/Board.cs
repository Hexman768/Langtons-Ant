﻿using System.Collections.Generic;

namespace Langton_s_Ant
{
    class Board
    {
        internal List<Row> rows { get; set; }

        public Board()
        {
            rows = new List<Row>();
        }

        public void AddRow()
        {
            rows.Add(new Row());
        }
    }
}
