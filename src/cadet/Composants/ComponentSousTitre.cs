using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
#if (Linq35)
using System.Linq;           
#endif
using System.Text;

namespace CADET
{
    public partial class ComponentSousTitre : Component
    {
        public ComponentSousTitre()
        {
            InitializeComponent();
        }

        public ComponentSousTitre(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
