using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeatureToggleApp.Models
{
    public class HomeModel
    {
        public AlwaysToggleType AlwaysToggle
        {
            get
            {
                return new AlwaysToggleType();
            }
        }

        public SimpleToggleType SimpleToggle
        {
            get
            {
                return new SimpleToggleType();
            }
        }

        public SqlToggleType SqlToggle
        {
            get
            {
                return new SqlToggleType();
            }
        }
    }
}