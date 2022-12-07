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
        public enum Type
        {
            OK,
            Warning,
            Error
        }
        Type typeOfConstraint { get; set; }
        double penalty { get; set; }

        public Constraint(String ConstraintName,ScheduleBlock scheduleBlock, Features feature, Type typeOfConstraint, double penalty)
        {
            this.sb = scheduleBlock;
            this.feature = feature;
            this.typeOfConstraint = typeOfConstraint;  
            this.penalty = penalty;
            this.ConstraintName = ConstraintName;
        }


    }
}
