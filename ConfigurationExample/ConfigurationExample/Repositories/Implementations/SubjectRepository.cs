using ConfigurationExample.DAL;
using ConfigurationExample.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationExample.Repositories.Implementations
{
    internal class SubjectRepository:Repository<Subject>
    {
        public SubjectRepository(AppDbContext context) : base(context) { }

    }
}
