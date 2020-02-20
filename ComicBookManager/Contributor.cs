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
        #region Properties
        public string ContributorName { get; set; }
        public TypeOfContributor ContributorType { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// New Contributor with selected values
        /// </summary>
        /// <param name="contributorname">Name of the contributor</param>
        /// <param name="contributortype">Type of the contributor</param>
        public Contributor(string contributorname, TypeOfContributor contributortype)
        {
            ContributorName = contributorname;
            ContributorType = contributortype;
        }
        #endregion    
    }
}
