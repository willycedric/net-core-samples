﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class ExampleGenericOneService : IExampleGenericService<ExampleOneService>
    {
        public void DoSomething(ExampleOneService example)
        {
            throw new NotImplementedException();
        }
    }
}
