using SynchronicWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SynchronicWorld.DAL
{
    public class ContributionProvider
    {
        public List<Contribution> GetAllContributions()
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Contributions.Include(c => c.Person).ToList();
            }
        }

        public Contribution CreateContribution(Contribution contribution)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                if (context.Contributions.Where(c => c.Name.ToLower().Equals(contribution.Name.ToLower())).Count() != 0)
                {
                    return null;
                }
                var person = contribution.Person;
                contribution.Person = null;
                Contribution newContribution = context.Contributions.Add(contribution);
                var personInDb = context.Persons.Where(p => p.Id.Equals(person.Id)).FirstOrDefault();
                newContribution.Person = personInDb;
                context.SaveChanges();
                return newContribution;
            }
        }

        public Contribution GetContributionByName(string name)
        {
            using (SynchronicWorldContext context = new SynchronicWorldContext())
            {
                return context.Contributions.Where(c => c.Name.ToLower().Equals(name.ToLower())).FirstOrDefault();
            }
        }     
    }
}
