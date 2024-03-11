using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string FilePath { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Artist}";

    }
}

