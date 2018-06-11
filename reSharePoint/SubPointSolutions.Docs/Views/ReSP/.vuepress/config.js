module.exports = {

    base: "/resp/",

    markdown: {
        lineNumbers: true
    },
    
    themeConfig: {
        
        // does not work under Docker container, hmm
        //lastUpdated: 'Last Updated',

        repo: 'SubPointSolutions/reSharePoint',
        //repoLabel: 'Contribute!',
        docsRepo: 'SubPointSolutions/reSharePoint',
        docsDir: 'reSharePoint/SubPointSolutions.Docs/Views/ReSP',
        docsBranch: 'dev',
        editLinks: true,
        editLinkText: 'Edit this page',

        nav: [
            { text: 'Home', link: '/' }
        ],

        sidebar: [
            {
                title: 'reSharePoint',
                collapsable: false,
                children: [
                  '/',
                  '/getting-started/'
                ]
            },

            {
                title: 'Inspections',
                collapsable: true,
                children: [
                  '/Inspections/aspnet/resp516902',
                  '/Inspections/aspnet/SetAutoGenerateColumnsForSPGridViewInPage',
                ]
            },

            {
                title: 'Code Completion',
                collapsable: true,
                children: [
                  'code-completion'
                ]
            },

            {
                title: 'Live Templates',
                collapsable: true,
                children: [
                  'live-templates'
                ]
            },
            
        ]
    }
  }