using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Infra.Data.Context
{
    public class TransDBContext: DbContext
    {
        public TransDBContext(DbContextOptions options): base(options)
        {

        }

        //ToDo: Remove it, just for POC
        //public DbSet<string> GetTaskDetails { get; set; }
        public string GetTaskDetails { get; set; }
    }
}
