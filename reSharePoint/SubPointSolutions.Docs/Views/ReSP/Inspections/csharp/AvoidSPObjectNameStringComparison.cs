using System;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using Microsoft.SharePoint.Taxonomy;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.WebControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;

namespace ReSharePoint.Docs.Basic.Inspection.Code
{
    [TestClass]
    [System.ComponentModel.Category("Category=Web Model; Subcategory=Fields; UseFullMethodBody=true;")]
    public class AvoidSPObjectNameStringComparison
    {
        [TestMethod]

        [System.ComponentModel.DisplayName("InappropriateComparison")]
        [System.ComponentModel.Description("The color used on nodes containing errors.")]
        [System.ComponentModel.Category("UseFullMethodBody=true")]
        [System.ComponentModel.Browsable(true)]

        public void InappropriateComparison(SPSite site)
        {
            var session = new TaxonomySession(site);
            var termStore = session.TermStores["Company"];

            var group = termStore.Groups["HR"];
            var termSet = group.TermSets["Review"];
            var term = termSet.Terms["Year 2012"];

            // wrong
            if (group.Name != "HR")
            {
                // wrong
                if (term.Name != "Review")
                {
                    // Do stuff
                }
            }
        }
    }
}
