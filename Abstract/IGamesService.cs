using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGamesService
    {
        void Add(Games game);
        void Delete(Games game);
        void Update(Games game);

    }
}
