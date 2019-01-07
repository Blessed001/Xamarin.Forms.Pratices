using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Text;

namespace XConcept1.Classes
{
    public interface IConfig
    {
        string DirectoryDB { get; }

        ISQLitePlatform Platform { get; }
    }
}
