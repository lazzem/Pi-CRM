﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private MyFinanceContexte dataContext;
        public MyFinanceContexte DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new MyFinanceContexte();
        }

        protected override void DisposeCore()
        {
            // libérer espace mémoire du context
            if(DataContext!=null)
            DataContext.Dispose();
        }
    }

}
