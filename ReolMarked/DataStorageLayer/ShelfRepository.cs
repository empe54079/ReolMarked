﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarked.DataStorageLayer
{
    public class ShelfRepository : GenericRepository<Shelf>
    {
        public ShelfRepository(DataBaseContext dbContext) : base(dbContext)
        { 

        }
    }
}