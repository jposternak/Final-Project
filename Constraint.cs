using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Constraint
    {
        String ConstraintName { get; set; }
        ScheduleBlock sb { get; set; }
        
        //constrainted feature
        Features feature { get; set; }
        // O = OK, W = WARNING, E = ERROR
        char typeOfConstraint { get; set; }
        double compatibilityScore { get; set; }

        public Constraint(String ConstraintName,ScheduleBlock scheduleBlock, Features feature, char typeOfConstraint, double compatibilityScore)
        {
            this.sb = scheduleBlock;
            this.feature = feature;
            this.typeOfConstraint = typeOfConstraint;  
            this.compatibilityScore = compatibilityScore;
            this.ConstraintName = ConstraintName;
        }


    }
}
