﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MazeRunner6.Dtos
{
    public class MazePostResponse
    {
        public Guid MazeUid { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
