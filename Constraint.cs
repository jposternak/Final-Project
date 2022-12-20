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
        public enum Severity
        {
            OK = 0,
            Warning = 1,
            Error = 2
        }
        public Severity constraintSeverity { get; private set; }

        public enum Type
        {
            Timing_Saturday,
            Timing_Friday,
            Simultaneous,
            Overlap,
            Capacity,
            Movement,
            Spacing

        }
        public Type typeOfConstraint { get; private set; }

        double penalty { get; set; }

        public Constraint(Type typeOfConstraint, ScheduleBlock scheduleBlock, Features feature, Severity constraintSeverity, double penalty)
        {
            this.sb = scheduleBlock;
            this.feature = feature;
            this.typeOfConstraint = typeOfConstraint;
            this.constraintSeverity = constraintSeverity;
            this.penalty = penalty;
            //this.ConstraintName = ConstraintName;
        }

        public override string ToString()
        {

            if (feature != null)
            {
                return $"Constraint: {typeOfConstraint}\t Feature: {feature.Name}\t Type: {typeOfConstraint}\t Penalty:{penalty}";
            }
            else
            {
                return $"Constraint: {typeOfConstraint}\t Type: {typeOfConstraint}\t Penalty:{penalty}";
            }

        }


        public override int GetHashCode()
        {
            int val = (int)this.typeOfConstraint;
            val *= 10000;
            val += (int)this.constraintSeverity;
            return (val);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Constraint);
        }

        public bool Equals(Constraint obj)
        {
            return obj != null && obj.GetHashCode() == this.GetHashCode();
        }

    }
}
