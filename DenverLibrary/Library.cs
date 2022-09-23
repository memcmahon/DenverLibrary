using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenverLibrary
{
    internal class Library
    {
        public string Name { get; set; }
        public List<Branch> Branches { get; set; } = new List<Branch>();

        public Library(string name)
        {
            Name = name;
        }

        public void AddBranch(Branch branch)
        {
            Branches.Add(branch);
        }

        public List<string> BranchNames()
        {
            var branchNames = new List<string>();
            foreach (var branch in Branches)
            {
                branchNames.Add(branch.Name);
            }    
            return branchNames;
        }

        public List<string> AllBooks()
        {
            var authors = new List<string>();
            foreach (var branch in Branches)
            {
                foreach (var book in branch.Books)
                {
                    authors.Add(book.Title);
                }
            }
            return authors;
        }
    }
}
