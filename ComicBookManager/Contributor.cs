using System;
using System.Collections.Generic;
using System.Text;

namespace ComicBookManager
{
    enum TypeOfContributor
    {
        Writer,
        Penciller,
        Inker,
        Colorist
    }

    class Contributor
    {
        public string ContributorName { get; set; }
        public TypeOfContributor ContributorType { get; set; }
    }
}
