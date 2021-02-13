using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Infra.Data.Context
{
    public class TransDBContext: DbContext
    {
        public TransDBContext(DbContextOptions option): base(option)
        {

        }
    }
}
